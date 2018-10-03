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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        private Curso curso;

        public Form1()
        {
            InitializeComponent();
            //  Inicializo los combo box con los tipo de divisiones de la clase Divisiones.
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Valido que la opcion de la Division sea la correcta.
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            //Tomo los datos de los Eventos del formulario y los cargo para crear un nuevo curso.
            this.curso = new Curso(short.Parse(nudAnioCurso.Text), division, new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, DateTime.Parse(dtpFecha.Text)));
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            //Muestro el curso.
            rbtDtos.Text = (string)curso;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //Valido la division.
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            //Tomo los datos de los Eventos del formulario y los cargo para Agrgar un alumno a un curso.
            Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, short.Parse(nudAnio.Text), division);
            //agrego el alumno al curso.
            this.curso += alumno;
        }
    }
}