# Cuadre Caja Ma Churro

Aplicación de escritorio para Windows desarrollada en C# con Windows Forms. Su objetivo es ayudar a realizar el cuadre de caja diario de Ma Churro, calculando cuánto efectivo debe separarse como liquidación y cuánto debe quedar como fondo de caja para el día siguiente.

## Estado del proyecto

Primera versión funcional. Actualmente el sistema permite ingresar ventas y descuentos por canal, calcular la liquidación esperada y obtener el fondo de caja restante a partir del efectivo contado en caja.

## Tecnologías utilizadas

- C#
- Windows Forms
- .NET 10 para Windows
- Visual Studio 2026

## Estructura del proyecto

```text
CuadreCajaMaChurro/
├── CuadreCajaMaChurro.slnx
├── README.md
├── .gitignore
└── CuadreCajaMaChurro/
    ├── CuadreCajaMaChurro.csproj
    ├── Program.cs
    ├── FrmCuadreCaja.cs
    ├── FrmCuadreCaja.Designer.cs
    └── FrmCuadreCaja.resx
```

## Qué hace la aplicación

La aplicación muestra un formulario principal llamado `FrmCuadreCaja`. En este formulario el usuario ingresa los montos del cierre diario:

- Venta total del día.
- Venta cobrada por POS.
- Venta cobrada por Rappi.
- Venta cobrada por PedidosYa.
- Venta cobrada por call center.
- Gastos realizados durante el día.
- Efectivo total contado físicamente en caja.

Con esos datos, el programa calcula automáticamente:

- Liquidación que debe colocarse en el sobre.
- Fondo de caja que debe quedar para el día siguiente.

## Fórmulas de cálculo

### Liquidación

La liquidación representa el monto que debe separarse en efectivo, descontando de la venta total los importes que no corresponden a efectivo disponible o que ya salieron como gastos.

```text
Liquidación = Venta Total - (POS + Rappi + PedidosYa + Call Center + Gastos)
```

### Fondo de caja

El fondo de caja representa cuánto efectivo queda luego de separar la liquidación.

```text
Fondo Caja = Efectivo Caja - Liquidación
```

## Explicación de archivos principales

### `CuadreCajaMaChurro.slnx`

Es el archivo de solución. Visual Studio lo usa para abrir el proyecto completo. Dentro referencia al proyecto `CuadreCajaMaChurro.csproj`.

### `CuadreCajaMaChurro.csproj`

Define la configuración principal del proyecto .NET:

```xml
<OutputType>WinExe</OutputType>
<TargetFramework>net10.0-windows</TargetFramework>
<Nullable>enable</Nullable>
<UseWindowsForms>true</UseWindowsForms>
<ImplicitUsings>enable</ImplicitUsings>
```

Qué significa cada propiedad:

- `OutputType` con valor `WinExe`: indica que el resultado será una aplicación de Windows, no una aplicación de consola.
- `TargetFramework` con valor `net10.0-windows`: indica que el proyecto usa .NET 10 con soporte específico para Windows.
- `Nullable` con valor `enable`: activa las comprobaciones de referencias nulas en C#.
- `UseWindowsForms` con valor `true`: habilita Windows Forms.
- `ImplicitUsings` con valor `enable`: permite que .NET incluya automáticamente algunos `using` comunes.

### `Program.cs`

Es el punto de entrada de la aplicación. Cuando el programa inicia, se ejecuta el método `Main`.

```csharp
[STAThread]
static void Main()
{
    ApplicationConfiguration.Initialize();
    Application.Run(new FrmCuadreCaja());
}
```

Explicación:

- `[STAThread]`: atributo requerido habitualmente en aplicaciones Windows Forms para trabajar correctamente con componentes visuales de Windows.
- `ApplicationConfiguration.Initialize()`: inicializa la configuración base de la aplicación, como DPI, fuentes y estilos visuales.
- `Application.Run(new FrmCuadreCaja())`: abre el formulario principal de cuadre de caja.

### `FrmCuadreCaja.cs`

Contiene la lógica del formulario. Aquí se calculan la liquidación y el fondo de caja cada vez que el usuario cambia un monto.

#### Constructor

```csharp
public FrmCuadreCaja()
{
    InitializeComponent();
    CalcularCuadre();
}
```

- `InitializeComponent()` crea y configura los controles visuales diseñados en `FrmCuadreCaja.Designer.cs`.
- `CalcularCuadre()` inicializa los resultados en `0.00` cuando se abre el formulario.

#### Evento de cambio de texto

```csharp
private void MontoTextBox_TextChanged(object sender, EventArgs e)
{
    CalcularCuadre();
}
```

Este evento se ejecuta cada vez que cambia el contenido de un campo de monto. Gracias a esto, el usuario no necesita presionar un botón para calcular: los resultados se actualizan automáticamente.

#### Método `CalcularCuadre`

```csharp
private void CalcularCuadre()
{
    decimal ventaTotal = LeerMonto(venta_total_textbox);
    decimal pos = LeerMonto(pos_textbox);
    decimal rappi = LeerMonto(rappi_textbox);
    decimal pedidosYa = LeerMonto(pedidosya_textbox);
    decimal callCenter = LeerMonto(call_center_textbox);
    decimal gastos = LeerMonto(gastos_textbox);
    decimal efectivoCaja = LeerMonto(efectivo_caja_textbox);

    decimal liquidacion = ventaTotal - (pos + rappi + pedidosYa + callCenter + gastos);
    decimal fondoCaja = efectivoCaja - liquidacion;

    liquidacion_textbox.Text = FormatearMonto(liquidacion);
    fondo_caja_textbox.Text = FormatearMonto(fondoCaja);
}
```

Este método:

1. Lee todos los montos ingresados por el usuario.
2. Convierte los textos a valores numéricos tipo `decimal`.
3. Calcula la liquidación.
4. Calcula el fondo de caja.
5. Muestra ambos resultados en sus campos correspondientes.

Se usa `decimal` porque es el tipo recomendado para cálculos monetarios en C#.

#### Método `LeerMonto`

```csharp
private static decimal LeerMonto(TextBox textBox)
```

Este método recibe un `TextBox`, toma su texto e intenta convertirlo en número decimal.

Características:

- Si el campo está vacío, devuelve `0`.
- Si el usuario escribe `S/`, lo ignora para poder leer solo el monto.
- Intenta leer el número usando la cultura actual de Windows.
- Si eso falla, intenta leerlo con cultura invariante.
- Si no puede convertir el texto, devuelve `0` para evitar que el programa se cierre por error.

#### Método `FormatearMonto`

```csharp
private static string FormatearMonto(decimal monto)
{
    return monto.ToString("0.00", CultureInfo.CurrentCulture);
}
```

Este método muestra los resultados siempre con dos decimales, por ejemplo:

```text
150.00
25.50
0.00
```

### `FrmCuadreCaja.Designer.cs`

Contiene la definición visual del formulario. Visual Studio genera y modifica este archivo cuando se usa el diseñador gráfico.

Aquí se crean controles como:

- `Label`: textos visibles del formulario.
- `TextBox`: cajas de texto donde se ingresan o muestran montos.

También se definen propiedades visuales como:

- Posición (`Location`).
- Tamaño (`Size`).
- Fuente (`Font`).
- Color (`ForeColor`).
- Texto visible (`Text`).
- Nombre interno del control (`Name`).

Los campos `liquidacion_textbox` y `fondo_caja_textbox` están configurados como solo lectura:

```csharp
liquidacion_textbox.ReadOnly = true;
fondo_caja_textbox.ReadOnly = true;
```

Esto evita que el usuario cambie manualmente los resultados calculados.

### `FrmCuadreCaja.resx`

Archivo de recursos asociado al formulario. Windows Forms lo usa para almacenar recursos del diseñador, como configuraciones o recursos visuales si se agregan en el futuro.

## Controles del formulario

| Control | Tipo | Uso |
| --- | --- | --- |
| `venta_total_textbox` | TextBox | Monto total vendido en el día. |
| `pos_textbox` | TextBox | Ventas cobradas por POS. |
| `rappi_textbox` | TextBox | Ventas cobradas por Rappi. |
| `pedidosya_textbox` | TextBox | Ventas cobradas por PedidosYa. |
| `call_center_textbox` | TextBox | Ventas cobradas por call center. |
| `gastos_textbox` | TextBox | Gastos realizados durante el día. |
| `liquidacion_textbox` | TextBox | Resultado calculado de la liquidación. |
| `efectivo_caja_textbox` | TextBox | Efectivo físico contado en caja. |
| `fondo_caja_textbox` | TextBox | Resultado calculado del fondo de caja para el día siguiente. |

## Cómo ejecutar el proyecto

1. Abrir Visual Studio 2026.
2. Abrir el archivo `CuadreCajaMaChurro.slnx`.
3. Esperar a que Visual Studio restaure y cargue el proyecto.
4. Presionar `F5` o el botón de iniciar.
5. Ingresar los montos del día.
6. Revisar los campos `Liquidación` y `Fondo Caja`.

## Ejemplo de uso

Si el usuario ingresa:

```text
Venta Total: 1000.00
POS: 200.00
Rappi: 100.00
PedidosYa: 50.00
Call Center: 30.00
Gastos: 20.00
Efectivo Caja: 650.00
```

La aplicación calcula:

```text
Liquidación = 1000.00 - (200.00 + 100.00 + 50.00 + 30.00 + 20.00)
Liquidación = 600.00

Fondo Caja = 650.00 - 600.00
Fondo Caja = 50.00
```

## Recomendaciones para próximas versiones

Algunas funciones que se pueden agregar después:

- Botón para limpiar todos los campos.
- Validación visual cuando el usuario escribe letras o valores inválidos.
- Guardar cierres diarios en una base de datos.
- Generar reportes por fecha.
- Imprimir o exportar el cuadre a PDF.
- Registrar usuario o cajero responsable del cierre.
- Agregar fecha y turno.
- Manejar diferentes locales o sedes.
- Crear historial de liquidaciones.

## Convención de ramas sugerida

- `main`: versión estable del proyecto.
- `version-1-cuadre-basico`: primera versión funcional con cálculo de liquidación y fondo de caja.

## Autor

Proyecto desarrollado por Alonso Castillo.

GitHub: [alonsocastilloupn](https://github.com/alonsocastilloupn)

Correo: n00491764@upn.pe
