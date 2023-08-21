namespace Tarea_de_curso
{
    partial class Tiendita
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CBProductos = new ComboBox();
            MtbMonto = new MaskedTextBox();
            MtbSaldo = new MaskedTextBox();
            BttCalcular = new Button();
            BttLimpiar = new Button();
            BttSalir = new Button();
            label1 = new Label();
            Cantidad = new Label();
            MtbCantidad = new MaskedTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(75, 9);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 1;
            label2.Text = "TIENDITA ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 182);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Saldo";
            // 
            // CBProductos
            // 
            CBProductos.FormattingEnabled = true;
            CBProductos.Items.AddRange(new object[] { "Arroz $12", "Frijoles $25", "Aceite $65" });
            CBProductos.Location = new Point(111, 93);
            CBProductos.Name = "CBProductos";
            CBProductos.Size = new Size(121, 23);
            CBProductos.TabIndex = 5;
            CBProductos.Text = "Seleccione";
            // 
            // MtbMonto
            // 
            MtbMonto.Location = new Point(111, 59);
            MtbMonto.Mask = "000000000";
            MtbMonto.Name = "MtbMonto";
            MtbMonto.Size = new Size(100, 23);
            MtbMonto.TabIndex = 6;
            // 
            // MtbSaldo
            // 
            MtbSaldo.Location = new Point(111, 174);
            MtbSaldo.Mask = "00000000";
            MtbSaldo.Name = "MtbSaldo";
            MtbSaldo.Size = new Size(100, 23);
            MtbSaldo.TabIndex = 7;
            // 
            // BttCalcular
            // 
            BttCalcular.Location = new Point(12, 225);
            BttCalcular.Name = "BttCalcular";
            BttCalcular.Size = new Size(75, 23);
            BttCalcular.TabIndex = 8;
            BttCalcular.Text = "Calcular";
            BttCalcular.UseVisualStyleBackColor = true;
            BttCalcular.Click += BttCalcular_Click;
            // 
            // BttLimpiar
            // 
            BttLimpiar.Location = new Point(111, 225);
            BttLimpiar.Name = "BttLimpiar";
            BttLimpiar.Size = new Size(75, 23);
            BttLimpiar.TabIndex = 9;
            BttLimpiar.Text = "Limpiar";
            BttLimpiar.UseVisualStyleBackColor = true;
            BttLimpiar.Click += BttLimpiar_Click;
            // 
            // BttSalir
            // 
            BttSalir.Location = new Point(206, 257);
            BttSalir.Name = "BttSalir";
            BttSalir.Size = new Size(75, 23);
            BttSalir.TabIndex = 10;
            BttSalir.Text = "Salir";
            BttSalir.UseVisualStyleBackColor = true;
            BttSalir.Click += BttSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 101);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 11;
            label1.Text = "Productos";
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Location = new Point(12, 136);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(55, 15);
            Cantidad.TabIndex = 12;
            Cantidad.Text = "Cantidad";
            // 
            // MtbCantidad
            // 
            MtbCantidad.Location = new Point(111, 136);
            MtbCantidad.Mask = "00";
            MtbCantidad.Name = "MtbCantidad";
            MtbCantidad.Size = new Size(24, 23);
            MtbCantidad.TabIndex = 13;
            // 
            // Tiendita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(293, 292);
            Controls.Add(MtbCantidad);
            Controls.Add(Cantidad);
            Controls.Add(label1);
            Controls.Add(BttSalir);
            Controls.Add(BttLimpiar);
            Controls.Add(BttCalcular);
            Controls.Add(MtbSaldo);
            Controls.Add(MtbMonto);
            Controls.Add(CBProductos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Tiendita";
            Text = "Tiendita";
            Load += Tiendita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox CBProductos;
        private MaskedTextBox MtbMonto;
        private MaskedTextBox MtbSaldo;
        private Button BttCalcular;
        private Button BttLimpiar;
        private Button BttSalir;
        private Label label1;
        private Label Cantidad;
        private MaskedTextBox MtbCantidad;
    }
}