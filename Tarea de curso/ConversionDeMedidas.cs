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
    public partial class ConversionDeMedidas : Form
    {
        public ConversionDeMedidas()
        {
            InitializeComponent();
        }

        private void BTTAgregar_Click(object sender, EventArgs e)
        {
            // Capturando el valor en metros
            double metros = double.Parse(MTTMetros.Text);

            // Realizando conversiones
            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            // Mostrando los resultados de la conversión
            LTBConversion.Items.Add("** RESUMEN DE CONVERSIONES **");
            LTBConversion.Items.Add("MEDIDA EN METROS: " + metros.ToString("0.00"));
            LTBConversion.Items.Add("--------------------------------------------");
            LTBConversion.Items.Add("MEDIDA EN CENTÍMETROS: " + centimetros.ToString("0.00"));
            LTBConversion.Items.Add("MEDIDA EN PULGADAS: " + pulgadas.ToString("0.00"));
            LTBConversion.Items.Add("MEDIDA EN PIES: " + pies.ToString("0.00"));
            LTBConversion.Items.Add("MEDIDA EN YARDAS: " + yardas.ToString("0.00"));
        }

        private void BTTLimpiar_Click(object sender, EventArgs e)
        {
            MTTMetros.Clear();
            LTBConversion.Items.Clear();
            MTTMetros.Focus();
        }

        private void BTTSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
