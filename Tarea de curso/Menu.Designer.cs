namespace Tarea_de_curso
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            trabajosEnCasaToolStripMenuItem = new ToolStripMenuItem();
            tiendaToolStripMenuItem = new ToolStripMenuItem();
            promedioDeNotasToolStripMenuItem = new ToolStripMenuItem();
            conversionDeMedidasToolStripMenuItem = new ToolStripMenuItem();
            capitalDeEmpresaToolStripMenuItem = new ToolStripMenuItem();
            controlDeVentasDeProductosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trabajosEnCasaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(380, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // trabajosEnCasaToolStripMenuItem
            // 
            trabajosEnCasaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiendaToolStripMenuItem, promedioDeNotasToolStripMenuItem, conversionDeMedidasToolStripMenuItem, capitalDeEmpresaToolStripMenuItem, controlDeVentasDeProductosToolStripMenuItem });
            trabajosEnCasaToolStripMenuItem.Name = "trabajosEnCasaToolStripMenuItem";
            trabajosEnCasaToolStripMenuItem.Size = new Size(99, 20);
            trabajosEnCasaToolStripMenuItem.Text = "Trabajo en casa";
            // 
            // tiendaToolStripMenuItem
            // 
            tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            tiendaToolStripMenuItem.Size = new Size(240, 22);
            tiendaToolStripMenuItem.Text = "Tienda";
            tiendaToolStripMenuItem.Click += tiendaToolStripMenuItem_Click;
            // 
            // promedioDeNotasToolStripMenuItem
            // 
            promedioDeNotasToolStripMenuItem.Name = "promedioDeNotasToolStripMenuItem";
            promedioDeNotasToolStripMenuItem.Size = new Size(240, 22);
            promedioDeNotasToolStripMenuItem.Text = "Promedio de notas";
            promedioDeNotasToolStripMenuItem.Click += promedioDeNotasToolStripMenuItem_Click;
            // 
            // conversionDeMedidasToolStripMenuItem
            // 
            conversionDeMedidasToolStripMenuItem.Name = "conversionDeMedidasToolStripMenuItem";
            conversionDeMedidasToolStripMenuItem.Size = new Size(240, 22);
            conversionDeMedidasToolStripMenuItem.Text = "Conversion de medidas";
            conversionDeMedidasToolStripMenuItem.Click += conversionDeMedidasToolStripMenuItem_Click;
            // 
            // capitalDeEmpresaToolStripMenuItem
            // 
            capitalDeEmpresaToolStripMenuItem.Name = "capitalDeEmpresaToolStripMenuItem";
            capitalDeEmpresaToolStripMenuItem.Size = new Size(240, 22);
            capitalDeEmpresaToolStripMenuItem.Text = "Capital de empresa";
            capitalDeEmpresaToolStripMenuItem.Click += capitalDeEmpresaToolStripMenuItem_Click;
            // 
            // controlDeVentasDeProductosToolStripMenuItem
            // 
            controlDeVentasDeProductosToolStripMenuItem.Name = "controlDeVentasDeProductosToolStripMenuItem";
            controlDeVentasDeProductosToolStripMenuItem.Size = new Size(240, 22);
            controlDeVentasDeProductosToolStripMenuItem.Text = "Control de ventas de productos";
            controlDeVentasDeProductosToolStripMenuItem.Click += controlDeVentasDeProductosToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(380, 250);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trabajosEnCasaToolStripMenuItem;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem promedioDeNotasToolStripMenuItem;
        private ToolStripMenuItem conversionDeMedidasToolStripMenuItem;
        private ToolStripMenuItem capitalDeEmpresaToolStripMenuItem;
        private ToolStripMenuItem controlDeVentasDeProductosToolStripMenuItem;
    }
}