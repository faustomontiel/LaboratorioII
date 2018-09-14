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
                //mal
                pesoE = (Pesos)nuevoEuro;
                txtEuroAPeso.Text = Convert.ToString(pesoE.GetCantidad());


            }
            else
            {
                txtEuroAEuro.Text = "Invalido";
                txtEuroADolar.Text = "Invalido";
                txtEuroAPeso.Text = "Invalido";

            }



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
                //bien
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

        private void btnConverPeso_Click(object sender, EventArgs e)
        {
            double peso;
            Euro euroPeso;
            Dolar pesosDolar;


            if (double.TryParse(txtPeso.Text, out peso))
            {
                txtPesoAPeso.Text = Convert.ToString(peso);


                Pesos nuevoPeso = new Pesos(peso);

                euroPeso = (Euro)nuevoPeso;

                txtPesoAEuro.Text = Convert.ToString(euroPeso.GetCantidad());
                //bien
                pesosDolar = (Dolar)nuevoPeso;
                txtPesoADolar.Text = Convert.ToString(pesosDolar.GetCantidad());


            }
            else
            {
                txtPesoAPeso.Text = "Invalido";
                txtPesoAEuro.Text = "Invalido";
                txtPesoADolar.Text = "Invalido";

            }

        }
    }
}
