using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_curso
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Tiendita();
            f.Show();
        }

        private void promedioDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Estudiantes();
            f.Show();
        }

        private void conversionDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ConversionDeMedidas();
            f.Show();
        }

        private void capitalDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CapitalDeEmpresa();
            f.Show();
        }

        private void controlDeVentasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ControlDeVentasDeProductos();
            f.Show();
        }
    }
}
