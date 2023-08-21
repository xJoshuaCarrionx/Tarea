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
    public partial class CapitalDeEmpresa : Form
    {
        public CapitalDeEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Capital1, Capital2, Capital3, TotalCapital;
            double Porcentaje1, Porcentaje2, Porcentaje3, TotalPorcentaje;

            if (TXTAportacion1.Text == "")
            {
                MessageBox.Show("Errror, no se permite espacio vacios en el cuadro 1", "Error");
                TXTAportacion1.Text = "";
                TXTAportacion1.Focus();

            }
            else if (TXTAportacion2.Text == "")
            {
                MessageBox.Show("Errror, no se permite espacio vacios en el cuadro 2", "Error");
                TXTAportacion2.Text = "";
                TXTAportacion2.Focus();

            }
            else if (TXTAportacion3.Text == "")
            {
                MessageBox.Show("Errror, no se permite espacio vacios en el cuadro 3", "Error");
                TXTAportacion3.Text = "";
                TXTAportacion3.Focus();

            }
            else
            {
                Capital1 = double.Parse(TXTAportacion1.Text);
                Capital2 = double.Parse(TXTAportacion2.Text);
                Capital3 = double.Parse(TXTAportacion3.Text);

                if (Capital1 < 10000)
                {
                    MessageBox.Show("El usuario 1 no cuenta con suficiente monto, lo minimo debe ser 10000", "Error");
                    TXTAportacion1.Text = "";
                    TXTAportacion1.Focus();

                }
                else if (Capital2 < 10000)
                {
                    MessageBox.Show("El usuario 2 no cuenta con suficiente monto, lo minimo debe ser 10000", "Error");
                    TXTAportacion2.Text = "";
                    TXTAportacion2.Focus();
                }
                else if (Capital3 < 10000)
                {

                    MessageBox.Show("El usuario 3 no cuenta con suficiente monto, lo minimo debe ser 10000", "Error");
                    TXTAportacion3.Text = "";
                    TXTAportacion3.Focus();
                }
                else
                {
                    TotalCapital = Capital1 + Capital2 + Capital3;
                    TXTCapitalTotal.Text = TotalCapital.ToString();

                    Porcentaje1 = (Capital1 / TotalCapital) * 100;
                    TXTPorcentaje1.Text = Porcentaje1.ToString();
                    Porcentaje2 = (Capital2 / TotalCapital) * 100;
                    TXTPorcentaje2.Text = Porcentaje2.ToString();
                    Porcentaje3 = (Capital3 / TotalCapital) * 100;
                    TXTPorcentaje3.Text = Porcentaje3.ToString();

                    TotalPorcentaje = Porcentaje1 + Porcentaje2 + Porcentaje3;
                    TXTTotalPorcentaje.Text = TotalPorcentaje.ToString();
                }
            }
        }

        private void CapitalDeEmpresa_Load(object sender, EventArgs e)
        {
            TXTCapitalTotal.Enabled = false;
            TXTPorcentaje1.Enabled = false;
            TXTPorcentaje2.Enabled = false;
            TXTPorcentaje3.Enabled = false;
            TXTTotalPorcentaje.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXTAportacion1.Clear();
            TXTAportacion2.Clear();
            TXTAportacion3.Clear();
            TXTCapitalTotal.Clear();
            TXTPorcentaje1.Clear(); TXTPorcentaje2.Clear(); TXTPorcentaje3.Clear(); TXTTotalPorcentaje.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult r = MessageBox.Show("¿Esta seguro que desea salir de la app?" , "CapitalDeEmpresa" ,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}//:)
