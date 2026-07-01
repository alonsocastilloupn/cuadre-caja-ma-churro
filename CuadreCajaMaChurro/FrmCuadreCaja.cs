using System.Globalization;

namespace CuadreCajaMaChurro
{
    public partial class FrmCuadreCaja : Form
    {
        public FrmCuadreCaja()
        {
            InitializeComponent();
            CalcularCuadre();
        }

        private void MontoTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularCuadre();
        }

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

        private static decimal LeerMonto(TextBox textBox)
        {
            string valor = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                return 0m;
            }

            valor = valor.Replace("S/", "", StringComparison.OrdinalIgnoreCase).Trim();

            if (decimal.TryParse(valor, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal monto))
            {
                return monto;
            }

            if (decimal.TryParse(valor, NumberStyles.Number, CultureInfo.InvariantCulture, out monto))
            {
                return monto;
            }

            return 0m;
        }

        private static string FormatearMonto(decimal monto)
        {
            return monto.ToString("0.00", CultureInfo.CurrentCulture);
        }
    }
}
