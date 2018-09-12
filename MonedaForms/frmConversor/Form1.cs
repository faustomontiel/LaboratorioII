using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace frmConversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverEuro_Click(object sender, EventArgs e)
        {
            double euro;
            Pesos pesoE;
            Dolar dolarE;

            if (double.TryParse(txtEuro.Text, out euro))
            {

                txtEuroAEuro.Text = Convert.ToString(euro);

                Euro nuevoEuro = new Euro(euro);

                dolarE = (Dolar)nuevoEuro;

                txtEuroADolar.Text = Convert.ToString(dolarE.GetCantidad());

                Euro pesoEuro = new Euro(euro);
                pesoE = (Pesos)pesoEuro;
                txtEuroAPeso.Text = Convert.ToString(pesoE.GetCantidad());


            }
            else
            {
                txtEuroAEuro.Text = "Invalido";
                txtEuroADolar.Text = "Invalido";
                txtEuroAPeso.Text = "Invalido";

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverDolar_Click(object sender, EventArgs e)
        {
            double dolar;
            Euro euroDolar;
            Pesos pesosDolar;
           

            if (double.TryParse(txtDolar.Text, out dolar))
            {
                txtDolarADolar.Text = Convert.ToString(dolar);


                Dolar nuevoDolar = new Dolar(dolar);

                euroDolar = (Euro)nuevoDolar;

                txtDolarAEuro.Text = Convert.ToString(euroDolar.GetCantidad());

                pesosDolar = (Pesos)nuevoDolar;
                txtDolarAPeso.Text = Convert.ToString(pesosDolar.GetCantidad());


            }
            else
            {
                txtDolarADolar.Text = "Invalido";
                txtDolarAEuro.Text = "Invalido";
                txtDolarAPeso.Text = "Invalido";

            }
        }
    }
}
