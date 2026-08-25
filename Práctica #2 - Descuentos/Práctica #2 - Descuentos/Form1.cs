using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescuentosMaria
{
    public partial class PracticaEstructuraIf : Form
    {
        public PracticaEstructuraIf()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorVenta;
            decimal porcentaje;
            decimal descuento;
            decimal ventaFinal;

            if (string.IsNullOrWhiteSpace(txtValorVenta.Text))
            {
                MessageBox.Show("Debe ingresar el valor de la venta.");
                return;
            }

            if (!decimal.TryParse(txtValorVenta.Text, out valorVenta))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            if (valorVenta >= 500)
            {
                porcentaje = 30;
            }
            else if (valorVenta > 300 && valorVenta <= 499)
            {
                porcentaje = 20;
            }
            else if (valorVenta > 100 && valorVenta <= 300)
            {
                porcentaje = 10;
            }
            else
            {
                porcentaje = 0;
            }

            descuento = valorVenta * porcentaje / 100;
            ventaFinal = valorVenta - descuento;

            txtDescuentoPorcentaje.Text = porcentaje.ToString("0") + "%";
            txtDescuentoDolares.Text = descuento.ToString("0.00");
            txtVentaFinal.Text = ventaFinal.ToString("0.00");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVenta.Clear();
            txtDescuentoPorcentaje.Clear();
            txtDescuentoDolares.Clear();
            txtVentaFinal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana");

            MessageBox.Show("Cerrando");

            this.Close();
        }
    }
}
