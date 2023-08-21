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
    public partial class Tiendita : Form
    {
        public Tiendita()
        {
            InitializeComponent();
        }

        private void Tiendita_Load(object sender, EventArgs e)
        {
            MtbSaldo.Enabled = false;
        }

        private void BttSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿En verdad quiere salir?", "Tiendita ",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BttCalcular_Click(object sender, EventArgs e)
        {
            double Monto, Valor;
            double Saldo;
            int Cantidad;


            if (MtbMonto.Text == "")
            {
                MessageBox.Show("Agrege su monto", "Error");
                MtbMonto.Text = "";
                MtbMonto.Focus();

            }
            else if (MtbCantidad.Text == "")
            {
                MessageBox.Show("Agrege la cantidad a elegir", "Error");
                MtbCantidad.Text = "";
                MtbCantidad.Focus();
            }
            else
            {
                Monto = double.Parse(MtbMonto.Text);
                Cantidad = int.Parse(MtbCantidad.Text);

                if (Monto > 2500 || Monto < 12)
                {
                    MessageBox.Show("Error, el Monto no puede superar los 2500 y no puede ser menor de 12", "Error");
                    MtbMonto.Text = "";
                    MtbMonto.Focus();
                }
                else if (Cantidad > 8)
                {
                    MessageBox.Show("Error, La cantidad debe ser menor de 8 ", "Error");
                    MtbCantidad.Text = "";
                    MtbCantidad.Focus();
                }
                else
                {
                    if (CBProductos.Text.Equals("Arroz $12"))
                    {
                        Valor = 12 * Cantidad;
                        Saldo = Monto - Valor;
                        MtbSaldo.Text = Saldo.ToString();

                    }
                    else if (CBProductos.Text.Equals("Frijoles $25"))
                    {
                        Valor = 25 * Cantidad;
                        Saldo = Monto - Valor;
                        MtbSaldo.Text = Saldo.ToString();

                    }
                    else if (CBProductos.Text.Equals("Aceite $65"))
                    {
                        Valor = 65 * Cantidad;
                        Saldo = Monto - Valor;
                        MtbSaldo.Text = Saldo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Producto");
                    }



                }

            }

        }

        private void BttLimpiar_Click(object sender, EventArgs e)
        {
            MtbCantidad.Clear();
            MtbMonto.Clear();
            MtbSaldo.Clear();

        }
    }
}
//:)