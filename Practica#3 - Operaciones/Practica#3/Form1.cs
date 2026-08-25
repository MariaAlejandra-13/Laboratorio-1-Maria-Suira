using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal numero1;
            decimal numero2;
            decimal resultado;

            if (!decimal.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Ingrese un número válido en Número 1.");
                return;
            }

            if (!decimal.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Ingrese un número válido en Número 2.");
                return;
            }

            if (btnSuma.Checked)
            {
                lblOperacion.Text = "+";
                resultado = numero1 + numero2;
            }
            else if (btnResta.Checked)
            {
                lblOperacion.Text = "-";
                resultado = numero1 - numero2;
            }
            else if (btnMultiplicacion.Checked)
            {
                lblOperacion.Text = "x";
                resultado = numero1 * numero2;
            }
            else if (btnDivision.Checked)
            {
                lblOperacion.Text = "/";
                if (numero2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.");
                    return;
                }

                resultado = numero1 / numero2;
            }
            else
            {
                MessageBox.Show("Seleccione una operación.");
                return;
            }

            txtResult.Text = resultado.ToString("0.00");
        }
   
    }
}
