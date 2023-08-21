namespace Tarea_de_curso
{
    partial class Estudiantes
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
            label9 = new Label();
            label11 = new Label();
            TXTex2 = new TextBox();
            TXTNota1 = new TextBox();
            TXTNota2 = new TextBox();
            TXTNota3 = new TextBox();
            TXTpor1 = new TextBox();
            TXTpor2 = new TextBox();
            TXTpor3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            TXT2DO = new TextBox();
            TXT3RO = new TextBox();
            TXTex3 = new TextBox();
            TXT1ER = new TextBox();
            TXTex1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 25);
            label1.TabIndex = 0;
            label1.Text = "APP PARA CALCULAR PORCENTAJE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 58);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Estudiante 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 58);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Estudiante 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 58);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "Estudiante 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 94);
            label5.Name = "label5";
            label5.Size = new Size(196, 15);
            label5.TabIndex = 4;
            label5.Text = "Notal total de los parciales(1er, 2do)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 133);
            label6.Name = "label6";
            label6.Size = new Size(201, 15);
            label6.TabIndex = 5;
            label6.Text = "Nota Final de los examenes(1er, 2do)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 174);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 8;
            label9.Text = "Nota Final";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 208);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 10;
            label11.Text = "Porcentaje dado";
            // 
            // TXTex2
            // 
            TXTex2.Location = new Point(313, 125);
            TXTex2.Name = "TXTex2";
            TXTex2.Size = new Size(71, 23);
            TXTex2.TabIndex = 16;
            // 
            // TXTNota1
            // 
            TXTNota1.Location = new Point(217, 166);
            TXTNota1.Name = "TXTNota1";
            TXTNota1.Size = new Size(71, 23);
            TXTNota1.TabIndex = 21;
            // 
            // TXTNota2
            // 
            TXTNota2.Location = new Point(313, 166);
            TXTNota2.Name = "TXTNota2";
            TXTNota2.Size = new Size(71, 23);
            TXTNota2.TabIndex = 25;
            // 
            // TXTNota3
            // 
            TXTNota3.Location = new Point(409, 166);
            TXTNota3.Name = "TXTNota3";
            TXTNota3.Size = new Size(71, 23);
            TXTNota3.TabIndex = 26;
            // 
            // TXTpor1
            // 
            TXTpor1.Location = new Point(217, 208);
            TXTpor1.Name = "TXTpor1";
            TXTpor1.Size = new Size(71, 23);
            TXTpor1.TabIndex = 27;
            // 
            // TXTpor2
            // 
            TXTpor2.Location = new Point(313, 208);
            TXTpor2.Name = "TXTpor2";
            TXTpor2.Size = new Size(71, 23);
            TXTpor2.TabIndex = 28;
            // 
            // TXTpor3
            // 
            TXTpor3.Location = new Point(409, 208);
            TXTpor3.Name = "TXTpor3";
            TXTpor3.Size = new Size(71, 23);
            TXTpor3.TabIndex = 29;
            // 
            // button1
            // 
            button1.Location = new Point(12, 254);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 254);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 31;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(383, 254);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 32;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TXT2DO
            // 
            TXT2DO.Location = new Point(313, 86);
            TXT2DO.Name = "TXT2DO";
            TXT2DO.Size = new Size(71, 23);
            TXT2DO.TabIndex = 33;
            // 
            // TXT3RO
            // 
            TXT3RO.Location = new Point(409, 86);
            TXT3RO.Name = "TXT3RO";
            TXT3RO.Size = new Size(71, 23);
            TXT3RO.TabIndex = 34;
            // 
            // TXTex3
            // 
            TXTex3.Location = new Point(409, 125);
            TXTex3.Name = "TXTex3";
            TXTex3.Size = new Size(71, 23);
            TXTex3.TabIndex = 35;
            // 
            // TXT1ER
            // 
            TXT1ER.Location = new Point(217, 86);
            TXT1ER.Name = "TXT1ER";
            TXT1ER.Size = new Size(75, 23);
            TXT1ER.TabIndex = 36;
            // 
            // TXTex1
            // 
            TXTex1.Location = new Point(217, 125);
            TXTex1.Name = "TXTex1";
            TXTex1.Size = new Size(75, 23);
            TXTex1.TabIndex = 37;
            // 
            // Estudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 305);
            Controls.Add(TXTex1);
            Controls.Add(TXT1ER);
            Controls.Add(TXTex3);
            Controls.Add(TXT3RO);
            Controls.Add(TXT2DO);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TXTpor3);
            Controls.Add(TXTpor2);
            Controls.Add(TXTpor1);
            Controls.Add(TXTNota3);
            Controls.Add(TXTNota2);
            Controls.Add(TXTNota1);
            Controls.Add(TXTex2);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Estudiantes";
            Text = "PromedioDeNotas";
            Load += Estudiantes_Load;
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
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox TXTes1par1;
        private TextBox TXTes2par1;
        private TextBox TXTes3par1;
        private TextBox TXTes1ex1;
        private TextBox TXTes3ex1;
        private TextBox TXTex2;
        private TextBox TXTes2par2;
        private TextBox TXTes1par2;
        private TextBox TXTes3par2;
        private TextBox TXTes1ex2;
        private TextBox TXTNota1;
        private TextBox TXTes2ex2;
        private TextBox TXTes3ex2;
        private TextBox TXTNota2;
        private TextBox TXTNota3;
        private TextBox TXTpor1;
        private TextBox TXTpor2;
        private TextBox TXTpor3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox TXT2DO;
        private TextBox TXT3RO;
        private TextBox TXTex3;
        private TextBox TXT1ER;
        private TextBox TXTex1;
    }
}