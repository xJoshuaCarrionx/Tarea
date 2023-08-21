namespace Tarea_de_curso
{
    partial class ControlDeVentasDeProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MTBMonto = new MaskedTextBox();
            TXTSaldoFinal = new TextBox();
            TXTPrecioFijo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            CBCantidad = new ComboBox();
            TXTConDescuento = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 195);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su monto total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio de Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(290, 15);
            label3.TabIndex = 2;
            label3.Text = "Por la compra del producto lleve el 11% de descuento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(56, 9);
            label4.Name = "label4";
            label4.Size = new Size(233, 32);
            label4.TabIndex = 3;
            label4.Text = "Oferta De Productos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 120);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad De Productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 155);
            label6.Name = "label6";
            label6.Size = new Size(128, 15);
            label6.TabIndex = 5;
            label6.Text = "Esto pagará con el 11%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(285, 257);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            // 
            // MTBMonto
            // 
            MTBMonto.Location = new Point(158, 187);
            MTBMonto.Mask = "00000000";
            MTBMonto.Name = "MTBMonto";
            MTBMonto.Size = new Size(52, 23);
            MTBMonto.TabIndex = 7;
            // 
            // TXTSaldoFinal
            // 
            TXTSaldoFinal.Location = new Point(158, 216);
            TXTSaldoFinal.Name = "TXTSaldoFinal";
            TXTSaldoFinal.Size = new Size(100, 23);
            TXTSaldoFinal.TabIndex = 8;
            // 
            // TXTPrecioFijo
            // 
            TXTPrecioFijo.Location = new Point(158, 87);
            TXTPrecioFijo.Name = "TXTPrecioFijo";
            TXTPrecioFijo.Size = new Size(41, 23);
            TXTPrecioFijo.TabIndex = 9;
            TXTPrecioFijo.Text = "1600";
            // 
            // button1
            // 
            button1.Location = new Point(13, 257);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(135, 256);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(243, 256);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CBCantidad
            // 
            CBCantidad.FormattingEnabled = true;
            CBCantidad.Items.AddRange(new object[] { "1", "2", "3" });
            CBCantidad.Location = new Point(158, 120);
            CBCantidad.Name = "CBCantidad";
            CBCantidad.Size = new Size(121, 23);
            CBCantidad.TabIndex = 13;
            // 
            // TXTConDescuento
            // 
            TXTConDescuento.Location = new Point(158, 155);
            TXTConDescuento.Name = "TXTConDescuento";
            TXTConDescuento.Size = new Size(108, 23);
            TXTConDescuento.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 224);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 16;
            label8.Text = "Saldo Final";
            // 
            // ControlDeVentasDeProductos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(330, 350);
            Controls.Add(label8);
            Controls.Add(TXTConDescuento);
            Controls.Add(CBCantidad);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TXTPrecioFijo);
            Controls.Add(TXTSaldoFinal);
            Controls.Add(MTBMonto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ControlDeVentasDeProductos";
            Text = "ControlDeVentasDeProductos";
            Load += ControlDeVentasDeProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox MTBMonto;
        private TextBox TXTSaldoFinal;
        private TextBox TXTPrecioFijo;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox CBCantidad;
        private TextBox TXTConDescuento;
        private Label label8;
    }
}