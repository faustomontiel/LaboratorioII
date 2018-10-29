using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, true))
                {
                    file.WriteLine(datos);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(archivo))
                {
                    datos = file.ReadToEnd();
                }

                return true;
            }
            catch (Exception)
            {
                datos = "";
                return false;
            }
        }


        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            

            saveFile.ShowDialog();


        }
    }
}
