using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Notepad
{
  public partial class Form1 : Form
  {

    string path = null;
    OpenFileDialog openFileDialog = new OpenFileDialog();
    public Form1()
    {
      InitializeComponent();
      toolStripStatusLabel1.Text = "0 caracteres";
    }

    private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //si el path existe guardo el texto en el mismo.
      if (path != null)
      {
        StreamWriter file = new StreamWriter(path);
        file.WriteLine(rchText.Text);        
        file.Close();
      }
      else
      {
        //sino llamo a guardar como.
        guardarComoToolStripMenuItem_Click(sender, e);
      }
    }
    
    private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //clase la cual me ayuda a elegir la carpeta donde la guardo.
      SaveFileDialog saveFile = new SaveFileDialog();

      //si el usuario se decidio a elegir la carpeta y el nombre para guardarlo,
      if (saveFile.ShowDialog() == DialogResult.OK)
      {
        try
        {
          //guardo el nombre del archivo en la variable path.
          path = saveFile.FileName;

          //apartir del path, obtengo lo escrito por el usuario en en rchText y lo guardo .
          StreamWriter file = new StreamWriter(path);
          file.WriteLine(rchText.Text);
          file.Close();
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }

    }

    private void rchText_TextChanged(object sender, EventArgs e)
    {
      toolStripStatusLabel1.Text = String.Format("{0} caracteres", rchText.Text.Length);
    }

    private void mnuAbrir_Click(object sender, EventArgs e)
    {

      
      openFileDialog.Filter = "Archivo Texto|*.txt";

     //si el usuario eligio el archivo de texto,
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          //guardo el nombre en el path.
          path = openFileDialog.FileName;


          //lo leo y lo exibo en el rchText.
          StreamReader file = new StreamReader(path);
          rchText.Text = file.ReadToEnd();
          file.Close();
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }
      
    }
  }
}
