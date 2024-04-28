using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculodeViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A1 = double.Parse(origen.Text);
            double B2 = double.Parse(destino.Text);
            double velocidadConstante = double.Parse(velocidad.Text);

            double resultado = (A1 - B2) / velocidadConstante;
            MessageBox.Show(resultado.ToString());
        }
    }
}
