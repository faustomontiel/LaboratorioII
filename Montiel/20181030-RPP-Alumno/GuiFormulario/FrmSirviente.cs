using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace GuiFormulario
{
    public partial class FrmSirviente : Form
    {
    RobotSirviente robot;
        public FrmSirviente()
        {
            InitializeComponent();
        }


    private void btnCrear_Click_1(object sender, EventArgs e)
    {
      int energia;
      int.TryParse(txtEnergia.Text,out energia);
      robot = new RobotSirviente(energia, txtOrigen.Text);    
      MessageBox.Show(robot.ToString());

    }
  }
}
