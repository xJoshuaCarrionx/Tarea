using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_curso
{
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double TotalParcial1, TotalParcial2, TotalParcial3, TotalExamenes1, TotalExamenes2,
                TotalExamenes3, NotaFinal1, NotaFinal2, NotaFinal3, Porcentaje1, Porcentaje2, Porcentaje3;

            if (TXT1ER.Text == "")
            {
                MessageBox.Show("Favor agregue la nota final de los dos parciales para estudiante 1");
                TXT1ER.Text = "";
                TXT1ER.Focus();

            }
            else if (TXT2DO.Text == "")
            {
                MessageBox.Show("Favor agregue la nota final de los dos parciales para estudiante 2");
                TXT2DO.Text = "";
                TXT2DO.Focus();
            }
            else if (TXT3RO.Text == "")
            {
                MessageBox.Show("Favor agregue la nota final de los dos parciales para estudiante 3");
                TXT3RO.Text = "";
                TXT3RO.Focus();
            }
            else if (TXTex1.Text == "")
            {
                MessageBox.Show("Favor agregue la nota final de los dos examenes parciales para estudiante 1");
                TXTex1.Text = "";
                TXTex1.Focus();
            }
            else if (TXTex2.Text == "")
            {
                MessageBox.Show("Favor agregue la nota final de los dos examenes parciales para estudiante 2");
                TXTex2.Text = "";
                TXTex2.Focus();

            }
            else if (TXTex3.Text == "")
            {
                MessageBox.Show("Favor agregue la nota final de los dos examenes parciales para estudiante 3");
                TXTex3.Text = "";
                TXTex3.Focus();
            }
            else
            {
                TotalParcial1 = double.Parse(TXT1ER.Text);
                TotalParcial2 = double.Parse(TXT2DO.Text);
                TotalParcial3 = double.Parse(TXT3RO.Text);
                TotalExamenes1 = double.Parse(TXTex1.Text);
                TotalExamenes2 = double.Parse(TXTex2.Text);
                TotalExamenes3 = double.Parse(TXTex3.Text);

                if (TotalParcial1 > 30 || TotalParcial1 < 0)
                {
                    MessageBox.Show("Error, La nota 1 no puede ser mayor de 30 y menor que 0", "Error");
                    TXTNota1.Text = "";
                    TXTNota1.Focus();
                }
                else if (TotalParcial2 > 30 || TotalParcial2 < 0)
                {

                    MessageBox.Show("Error, La nota 2 no puede ser mayor de 30 y menor que 0", "Error");
                    TXTNota2.Text = "";
                    TXTNota2.Focus();

                }
                else if (TotalParcial3 > 30 || TotalParcial3 < 0)
                {
                    MessageBox.Show("Error, La nota 3 no puede ser mayor de 30 y menor que 0", "Error");
                    TXTNota3.Text = "";
                    TXTNota3.Focus();
                }
                else if (TotalExamenes1 > 70 || TotalExamenes1 < 0)
                {
                    MessageBox.Show("Error, La nota del examen del estudiante 1 no puede ser mayor que 70 y menor que 0", "Error");
                    TXTex1.Text = "";
                    TXTex1.Focus();
                }
                else if (TotalExamenes2 > 70 || TotalExamenes2 < 0)
                {

                    MessageBox.Show("Error, La nota del examen del estudiante 2 no puede ser mayor que 70 y menor que 0", "Error");
                    TXTex2.Text = "";
                    TXTex2.Focus();

                }
                else if (TotalExamenes3 > 70 || TotalExamenes3 < 0)
                {
                    MessageBox.Show("Error, La nota del examen del estudiante 3 no puede ser mayor que 70 y menor que 0", "Error");
                    TXTex3.Text = "";
                    TXTex3.Focus();
                }
                else
                {
                    NotaFinal1 = TotalParcial1 + TotalExamenes1;
                    TXTNota1.Text = NotaFinal1.ToString();
                    NotaFinal2 = TotalParcial2 + TotalExamenes2;
                    TXTNota2.Text = NotaFinal2.ToString();
                    NotaFinal3 = TotalParcial3 + TotalExamenes3;
                    TXTNota3.Text = NotaFinal3.ToString();

                    Porcentaje1 = (NotaFinal1 / 60) * 100;
                    TXTpor1.Text = Porcentaje1.ToString();
                    Porcentaje2 = (NotaFinal2 / 60) * 100;
                    TXTpor2.Text = Porcentaje2.ToString();
                    Porcentaje3 = (NotaFinal3 / 60) * 100;
                    TXTpor3.Text = Porcentaje3.ToString();

                }




            }

        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            TXTNota1.Enabled = false;
            TXTNota2.Enabled = false;
            TXTNota3.Enabled = false;
            TXTpor1.Enabled = false;
            TXTpor2.Enabled = false;
            TXTpor3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXT1ER.Clear();
            TXT2DO.Clear();
            TXT3RO.Clear();
            TXTpor1.Clear();
            TXTpor2.Clear();
            TXTpor3.Clear();
            TXTex1.Clear();
            TXTex2.Clear();
            TXTex3.Clear();
            TXTNota1.Clear(); TXTNota2.Clear(); TXTNota3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Seguro que desea salir?", "PromedioDeNotas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}//:)
