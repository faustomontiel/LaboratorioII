using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamiento
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(1,"Moniotor 21'", 4000);
            Producto productoDos = new Producto(2, "Teclado", 500);
            Factura factura = new Factura();
            factura[producto.Identificador] = producto;
            factura[productoDos.Identificador] = productoDos;
            
            
            MessageBox.Show(factura.Total.ToString());
            
            
        }
    }
}
