namespace CuadreCajaMaChurro
{
    partial class FrmCuadreCaja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ma_churro_text = new Label();
            cuadre_caja_text = new Label();
            venta_total_textbox = new TextBox();
            pos_textbox = new TextBox();
            rappi_textbox = new TextBox();
            pedidosya_textbox = new TextBox();
            call_center_textbox = new TextBox();
            gastos_textbox = new TextBox();
            liquidacion_textbox = new TextBox();
            efectivo_caja_textbox = new TextBox();
            fondo_caja_textbox = new TextBox();
            venta_total_text = new Label();
            pos_text = new Label();
            rappi_text = new Label();
            pedidosya_text = new Label();
            call_center_text = new Label();
            gastos_text = new Label();
            liquidacion_text = new Label();
            efectivo_caja_text = new Label();
            fondo_caja_text = new Label();
            SuspendLayout();
            // 
            // ma_churro_text
            // 
            ma_churro_text.AutoSize = true;
            ma_churro_text.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ma_churro_text.ForeColor = SystemColors.Highlight;
            ma_churro_text.Location = new Point(83, 32);
            ma_churro_text.Name = "ma_churro_text";
            ma_churro_text.Size = new Size(189, 31);
            ma_churro_text.TabIndex = 0;
            ma_churro_text.Text = "MA CHURRO";
            // 
            // cuadre_caja_text
            // 
            cuadre_caja_text.AutoSize = true;
            cuadre_caja_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuadre_caja_text.ForeColor = Color.Maroon;
            cuadre_caja_text.Location = new Point(115, 75);
            cuadre_caja_text.Name = "cuadre_caja_text";
            cuadre_caja_text.Size = new Size(124, 18);
            cuadre_caja_text.TabIndex = 1;
            cuadre_caja_text.Text = "Cuadre De Caja";
            // 
            // venta_total_textbox
            // 
            venta_total_textbox.Location = new Point(200, 128);
            venta_total_textbox.Name = "venta_total_textbox";
            venta_total_textbox.Size = new Size(100, 23);
            venta_total_textbox.TabIndex = 0;
            venta_total_textbox.TextChanged += MontoTextBox_TextChanged;
            // 
            // pos_textbox
            // 
            pos_textbox.Location = new Point(200, 157);
            pos_textbox.Name = "pos_textbox";
            pos_textbox.Size = new Size(100, 23);
            pos_textbox.TabIndex = 1;
            pos_textbox.TextChanged += MontoTextBox_TextChanged;
            // 
            // rappi_textbox
            // 
            rappi_textbox.Location = new Point(200, 186);
            rappi_textbox.Name = "rappi_textbox";
            rappi_textbox.Size = new Size(100, 23);
            rappi_textbox.TabIndex = 2;
            rappi_textbox.TextChanged += MontoTextBox_TextChanged;
            // 
            // pedidosya_textbox
            // 
            pedidosya_textbox.Location = new Point(200, 215);
            pedidosya_textbox.Name = "pedidosya_textbox";
            pedidosya_textbox.Size = new Size(100, 23);
            pedidosya_textbox.TabIndex = 3;
            pedidosya_textbox.TextChanged += MontoTextBox_TextChanged;
            // 
            // call_center_textbox
            // 
            call_center_textbox.Location = new Point(200, 244);
            call_center_textbox.Name = "call_center_textbox";
            call_center_textbox.Size = new Size(100, 23);
            call_center_textbox.TabIndex = 4;
            call_center_textbox.TextChanged += MontoTextBox_TextChanged;
            // 
            // gastos_textbox
            // 
            gastos_textbox.Location = new Point(200, 273);
            gastos_textbox.Name = "gastos_textbox";
            gastos_textbox.Size = new Size(100, 23);
            gastos_textbox.TabIndex = 5;
            gastos_textbox.TextChanged += MontoTextBox_TextChanged;
            // 
            // liquidacion_textbox
            // 
            liquidacion_textbox.Location = new Point(200, 334);
            liquidacion_textbox.Name = "liquidacion_textbox";
            liquidacion_textbox.ReadOnly = true;
            liquidacion_textbox.Size = new Size(100, 23);
            liquidacion_textbox.TabIndex = 7;
            liquidacion_textbox.TabStop = false;
            // 
            // efectivo_caja_textbox
            // 
            efectivo_caja_textbox.Location = new Point(200, 395);
            efectivo_caja_textbox.Name = "efectivo_caja_textbox";
            efectivo_caja_textbox.Size = new Size(100, 23);
            efectivo_caja_textbox.TabIndex = 6;
            efectivo_caja_textbox.TextChanged += MontoTextBox_TextChanged;
            // 
            // fondo_caja_textbox
            // 
            fondo_caja_textbox.Location = new Point(200, 424);
            fondo_caja_textbox.Name = "fondo_caja_textbox";
            fondo_caja_textbox.ReadOnly = true;
            fondo_caja_textbox.Size = new Size(100, 23);
            fondo_caja_textbox.TabIndex = 8;
            fondo_caja_textbox.TabStop = false;
            // 
            // venta_total_text
            // 
            venta_total_text.AutoSize = true;
            venta_total_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            venta_total_text.ForeColor = Color.Maroon;
            venta_total_text.Location = new Point(66, 129);
            venta_total_text.Name = "venta_total_text";
            venta_total_text.Size = new Size(99, 18);
            venta_total_text.TabIndex = 1;
            venta_total_text.Text = "Venta Total:";
            // 
            // pos_text
            // 
            pos_text.AutoSize = true;
            pos_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pos_text.ForeColor = Color.Maroon;
            pos_text.Location = new Point(66, 158);
            pos_text.Name = "pos_text";
            pos_text.Size = new Size(93, 18);
            pos_text.TabIndex = 1;
            pos_text.Text = "Venta POS:";
            // 
            // rappi_text
            // 
            rappi_text.AutoSize = true;
            rappi_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rappi_text.ForeColor = Color.Maroon;
            rappi_text.Location = new Point(66, 187);
            rappi_text.Name = "rappi_text";
            rappi_text.Size = new Size(102, 18);
            rappi_text.TabIndex = 1;
            rappi_text.Text = "Venta Rappi:";
            // 
            // pedidosya_text
            // 
            pedidosya_text.AutoSize = true;
            pedidosya_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pedidosya_text.ForeColor = Color.Maroon;
            pedidosya_text.Location = new Point(66, 216);
            pedidosya_text.Name = "pedidosya_text";
            pedidosya_text.Size = new Size(94, 18);
            pedidosya_text.TabIndex = 1;
            pedidosya_text.Text = "Venta PYA:";
            // 
            // call_center_text
            // 
            call_center_text.AutoSize = true;
            call_center_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            call_center_text.ForeColor = Color.Maroon;
            call_center_text.Location = new Point(66, 245);
            call_center_text.Name = "call_center_text";
            call_center_text.Size = new Size(90, 18);
            call_center_text.TabIndex = 1;
            call_center_text.Text = "Venta Call:";
            // 
            // gastos_text
            // 
            gastos_text.AutoSize = true;
            gastos_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gastos_text.ForeColor = Color.Maroon;
            gastos_text.Location = new Point(66, 274);
            gastos_text.Name = "gastos_text";
            gastos_text.Size = new Size(62, 18);
            gastos_text.TabIndex = 1;
            gastos_text.Text = "Gastos:";
            // 
            // liquidacion_text
            // 
            liquidacion_text.AutoSize = true;
            liquidacion_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            liquidacion_text.ForeColor = Color.Maroon;
            liquidacion_text.Location = new Point(66, 335);
            liquidacion_text.Name = "liquidacion_text";
            liquidacion_text.Size = new Size(98, 18);
            liquidacion_text.TabIndex = 1;
            liquidacion_text.Text = "Liquidación:";
            // 
            // efectivo_caja_text
            // 
            efectivo_caja_text.AutoSize = true;
            efectivo_caja_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            efectivo_caja_text.ForeColor = Color.Maroon;
            efectivo_caja_text.Location = new Point(66, 396);
            efectivo_caja_text.Name = "efectivo_caja_text";
            efectivo_caja_text.Size = new Size(116, 18);
            efectivo_caja_text.TabIndex = 1;
            efectivo_caja_text.Text = "Efectivo Caja:";
            // 
            // fondo_caja_text
            // 
            fondo_caja_text.AutoSize = true;
            fondo_caja_text.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fondo_caja_text.ForeColor = Color.Maroon;
            fondo_caja_text.Location = new Point(66, 425);
            fondo_caja_text.Name = "fondo_caja_text";
            fondo_caja_text.Size = new Size(100, 18);
            fondo_caja_text.TabIndex = 1;
            fondo_caja_text.Text = "Fondo Caja:";
            // 
            // FrmCuadreCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 485);
            Controls.Add(fondo_caja_textbox);
            Controls.Add(efectivo_caja_textbox);
            Controls.Add(liquidacion_textbox);
            Controls.Add(gastos_textbox);
            Controls.Add(call_center_textbox);
            Controls.Add(pedidosya_textbox);
            Controls.Add(rappi_textbox);
            Controls.Add(pos_textbox);
            Controls.Add(venta_total_textbox);
            Controls.Add(fondo_caja_text);
            Controls.Add(efectivo_caja_text);
            Controls.Add(liquidacion_text);
            Controls.Add(gastos_text);
            Controls.Add(call_center_text);
            Controls.Add(pedidosya_text);
            Controls.Add(rappi_text);
            Controls.Add(pos_text);
            Controls.Add(venta_total_text);
            Controls.Add(cuadre_caja_text);
            Controls.Add(ma_churro_text);
            Name = "FrmCuadreCaja";
            Text = "CUADRE CAJA MA CHURRO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ma_churro_text;
        private Label cuadre_caja_text;
        private TextBox venta_total_textbox;
        private TextBox pos_textbox;
        private TextBox rappi_textbox;
        private TextBox pedidosya_textbox;
        private TextBox call_center_textbox;
        private TextBox gastos_textbox;
        private TextBox liquidacion_textbox;
        private TextBox efectivo_caja_textbox;
        private TextBox fondo_caja_textbox;
        private Label venta_total_text;
        private Label pos_text;
        private Label rappi_text;
        private Label pedidosya_text;
        private Label call_center_text;
        private Label gastos_text;
        private Label liquidacion_text;
        private Label efectivo_caja_text;
        private Label fondo_caja_text;
    }
}
