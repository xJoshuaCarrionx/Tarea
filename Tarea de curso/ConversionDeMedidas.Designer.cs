namespace Tarea_de_curso
{
    partial class ConversionDeMedidas
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
            LTBConversion = new ListBox();
            MTTMetros = new MaskedTextBox();
            BTTAgregar = new Button();
            BTTLimpiar = new Button();
            BTTSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(366, 40);
            label1.TabIndex = 0;
            label1.Text = "App Para Calcular Medidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el valor deseado en metros";
            // 
            // LTBConversion
            // 
            LTBConversion.FormattingEnabled = true;
            LTBConversion.ItemHeight = 15;
            LTBConversion.Location = new Point(72, 123);
            LTBConversion.Name = "LTBConversion";
            LTBConversion.Size = new Size(228, 169);
            LTBConversion.TabIndex = 2;
            // 
            // MTTMetros
            // 
            MTTMetros.Location = new Point(219, 81);
            MTTMetros.Mask = "000000";
            MTTMetros.Name = "MTTMetros";
            MTTMetros.Size = new Size(41, 23);
            MTTMetros.TabIndex = 3;
            // 
            // BTTAgregar
            // 
            BTTAgregar.Location = new Point(12, 318);
            BTTAgregar.Name = "BTTAgregar";
            BTTAgregar.Size = new Size(74, 25);
            BTTAgregar.TabIndex = 4;
            BTTAgregar.Text = "Agregar";
            BTTAgregar.UseVisualStyleBackColor = true;
            BTTAgregar.Click += BTTAgregar_Click;
            // 
            // BTTLimpiar
            // 
            BTTLimpiar.Location = new Point(165, 320);
            BTTLimpiar.Name = "BTTLimpiar";
            BTTLimpiar.Size = new Size(75, 23);
            BTTLimpiar.TabIndex = 5;
            BTTLimpiar.Text = "Limpiar";
            BTTLimpiar.UseVisualStyleBackColor = true;
            BTTLimpiar.Click += BTTLimpiar_Click;
            // 
            // BTTSalir
            // 
            BTTSalir.Location = new Point(285, 354);
            BTTSalir.Name = "BTTSalir";
            BTTSalir.Size = new Size(75, 23);
            BTTSalir.TabIndex = 6;
            BTTSalir.Text = "Salir";
            BTTSalir.UseVisualStyleBackColor = true;
            BTTSalir.Click += BTTSalir_Click;
            // 
            // ConversionDeMedidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(376, 382);
            Controls.Add(BTTSalir);
            Controls.Add(BTTLimpiar);
            Controls.Add(BTTAgregar);
            Controls.Add(MTTMetros);
            Controls.Add(LTBConversion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConversionDeMedidas";
            Text = "ConversionDeMedidas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox LTBConversion;
        private MaskedTextBox MTTMetros;
        private Button BTTAgregar;
        private Button BTTLimpiar;
        private Button BTTSalir;
    }
}