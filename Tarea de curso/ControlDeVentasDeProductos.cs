using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_curso
{
    public partial class ControlDeVentasDeProductos : Form
    {
        public ControlDeVentasDeProductos()
        {
            InitializeComponent();
        }

        private void ControlDeVentasDeProductos_Load(object sender, EventArgs e)
        {
            TXTPrecioFijo.Enabled = false;
            TXTConDescuento.Enabled = false;
            TXTSaldoFinal.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double monto, SaldoFinal;
            double Precio, Valor, Valor2;
            Precio = 1600;

            if (MTBMonto.Text == "")
            {
                MessageBox.Show("Favor agregar su saldo inicial", "Error");
                MTBMonto.Focus();
            }

            else
            {
                monto = double.Parse(MTBMonto.Text);
                if (monto < 5000 || monto > 65000)
                {
                    MessageBox.Show("Error, el rango no puede ser menor que 5000 y mayor que 65000");
                }
                else
                {
                    if (CBCantidad.Text.Equals("1"))
                    {
                        Valor = Precio * 0.11;
                        Valor2 = Precio - Valor;
                        TXTConDescuento.Text = Valor2.ToString();
                        SaldoFinal = monto - Valor2;
                        TXTSaldoFinal.Text = SaldoFinal.ToString();

                    }
                    else if (CBCantidad.Text.Equals("2"))
                    {
                        Valor = (Precio * 2) * 0.11;
                        Valor2 = (Precio * 2) - Valor;
                        TXTConDescuento.Text = Valor2.ToString();
                        SaldoFinal = monto - Valor2;
                        TXTSaldoFinal.Text = SaldoFinal.ToString();

                    }
                    else if (CBCantidad.Text.Equals("3"))
                    {
                        Valor = (Precio * 3) * 0.11;
                        Valor2 = (Precio * 3) - Valor;
                        TXTConDescuento.Text = Valor2.ToString();
                        SaldoFinal = monto - Valor2;
                        TXTSaldoFinal.Text = SaldoFinal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una Cantidad", "Error");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXTSaldoFinal.Clear();
            TXTConDescuento.Clear();
            MTBMonto.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿En verdad quiere salir?" , "ControlDeVentas " ,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}//:)
