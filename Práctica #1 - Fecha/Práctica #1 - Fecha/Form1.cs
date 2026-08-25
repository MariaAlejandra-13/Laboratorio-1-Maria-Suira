using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectodePrueba
{
    public partial class PractControles : Form
    {
        public PractControles()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDia.Text) ||
        string.IsNullOrWhiteSpace(txtMes.Text) ||
        string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }

            int dia;
            int mes;
            int anio;

            if (!int.TryParse(txtDia.Text, out dia) ||
                !int.TryParse(txtMes.Text, out mes) ||
                !int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("Día, mes y año deben ser números.");
                return;
            }

            else if ((dia > 31) || (dia < 1))
            {
                MessageBox.Show("Ingrese un valor valido para el dia.");
                return;
            }
        
            else if ((mes > 12)||(mes < 1))
            {
                MessageBox.Show("Ingrese un valor valido para el mes. Hay 12 meses.");
                return;
            }
            else if (anio < 0)
            {
                MessageBox.Show("Ingrese un valor valido para el año");
                return;
            }
            else
            {
                lblFecha.Text = "La fecha es: " +
                                txtDia.Text + " / " +
                                txtMes.Text + " / " +
                                txtAnio.Text;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Se cerrará la ventana");

            MessageBox.Show("Cerrando");

            this.Close();
        }
    }
}
