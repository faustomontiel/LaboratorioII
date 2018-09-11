using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProgramaWindowsForm
{
    public partial class FrmPantalla2 : Form
    {
        public string atributoString = "Atributo Clase FrmPantalla2 ";

        public FrmPantalla2()
        {
            InitializeComponent();
        }

        private void FrmPantalla2_Load(object sender, EventArgs e)
        {
            this.cmbPais.SelectedIndex = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach(Control  radio in  grbNacionalidad.Controls)
            {
                if(radio is RadioButton && ((RadioButton)radio).Checked)
                {
                    MessageBox.Show(radio.Text);
                }


            }


            string salida ="";
            foreach (object item in this.lstPosicion.SelectedItems)
                {
                salida += item.ToString();
            };
            MessageBox.Show(
                salida
                
             //this.chkEnviaPublicidad.Checked.ToString()
             //this.rdoArgentino.Checked ? "Argentino" : "Extranjero"
           );
        }
    }
}
