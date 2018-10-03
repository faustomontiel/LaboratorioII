namespace VistaForm
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblAnioProfe = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.gpbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbDivisionAlumno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtDtos = new System.Windows.Forms.RichTextBox();
            this.gpbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.gpbDatosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.dtpFecha);
            this.gpbDatosCurso.Controls.Add(this.lblIngreso);
            this.gpbDatosCurso.Controls.Add(this.lblDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.lblDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.lblAnioProfe);
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.btnCrear);
            this.gpbDatosCurso.Controls.Add(this.txtDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.nudAnioCurso);
            this.gpbDatosCurso.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(329, 215);
            this.gpbDatosCurso.TabIndex = 0;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Curso";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(92, 150);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(231, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(27, 152);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 12;
            this.lblIngreso.Text = "Ingreso";
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(27, 130);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoProfe.TabIndex = 11;
            this.lblDocumentoProfe.Text = "DNI";
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(24, 105);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 10;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(24, 79);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 9;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(24, 53);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 8;
            this.lblDivisionCurso.Text = "Division";
            // 
            // lblAnioProfe
            // 
            this.lblAnioProfe.AutoSize = true;
            this.lblAnioProfe.Location = new System.Drawing.Point(24, 26);
            this.lblAnioProfe.Name = "lblAnioProfe";
            this.lblAnioProfe.Size = new System.Drawing.Size(26, 13);
            this.lblAnioProfe.TabIndex = 7;
            this.lblAnioProfe.Text = "Año";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(243, 179);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(80, 30);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(6, 179);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(80, 30);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(92, 124);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(231, 20);
            this.txtDocumentoProfe.TabIndex = 4;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(92, 98);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(231, 20);
            this.txtApellidoProfe.TabIndex = 3;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(92, 72);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(231, 20);
            this.txtNombreProfe.TabIndex = 2;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(92, 45);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionCurso.TabIndex = 1;
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(92, 19);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(121, 20);
            this.nudAnioCurso.TabIndex = 0;
            this.nudAnioCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gpbDatosAlumnos
            // 
            this.gpbDatosAlumnos.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumnos.Controls.Add(this.cmbDivisionAlumno);
            this.gpbDatosAlumnos.Controls.Add(this.label4);
            this.gpbDatosAlumnos.Controls.Add(this.nudAnio);
            this.gpbDatosAlumnos.Controls.Add(this.label3);
            this.gpbDatosAlumnos.Controls.Add(this.txtDocumento);
            this.gpbDatosAlumnos.Controls.Add(this.lblDocumento);
            this.gpbDatosAlumnos.Controls.Add(this.txtApellido);
            this.gpbDatosAlumnos.Controls.Add(this.label2);
            this.gpbDatosAlumnos.Controls.Add(this.txtNombre);
            this.gpbDatosAlumnos.Controls.Add(this.label1);
            this.gpbDatosAlumnos.Location = new System.Drawing.Point(347, 12);
            this.gpbDatosAlumnos.Name = "gpbDatosAlumnos";
            this.gpbDatosAlumnos.Size = new System.Drawing.Size(329, 215);
            this.gpbDatosAlumnos.TabIndex = 1;
            this.gpbDatosAlumnos.TabStop = false;
            this.gpbDatosAlumnos.Text = "Datos Alumnos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(243, 179);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // cmbDivisionAlumno
            // 
            this.cmbDivisionAlumno.FormattingEnabled = true;
            this.cmbDivisionAlumno.Location = new System.Drawing.Point(92, 130);
            this.cmbDivisionAlumno.Name = "cmbDivisionAlumno";
            this.cmbDivisionAlumno.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionAlumno.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Division";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(92, 105);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(121, 20);
            this.nudAnio.TabIndex = 14;
            this.nudAnio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Año";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(92, 79);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(231, 20);
            this.txtDocumento.TabIndex = 16;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(27, 79);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(39, 13);
            this.lblDocumento.TabIndex = 14;
            this.lblDocumento.Text = "Legajo";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(92, 53);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(231, 20);
            this.txtApellido.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // rbtDtos
            // 
            this.rbtDtos.Location = new System.Drawing.Point(12, 233);
            this.rbtDtos.Name = "rbtDtos";
            this.rbtDtos.Size = new System.Drawing.Size(664, 197);
            this.rbtDtos.TabIndex = 2;
            this.rbtDtos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.rbtDtos);
            this.Controls.Add(this.gpbDatosAlumnos);
            this.Controls.Add(this.gpbDatosCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.gpbDatosAlumnos.ResumeLayout(false);
            this.gpbDatosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gpbDatosCurso;
    private System.Windows.Forms.GroupBox gpbDatosAlumnos;
    private System.Windows.Forms.Label lblIngreso;
    private System.Windows.Forms.Label lblDocumentoProfe;
    private System.Windows.Forms.Label lblApellidoProfe;
    private System.Windows.Forms.Label lblNombreProfe;
    private System.Windows.Forms.Label lblDivisionCurso;
    private System.Windows.Forms.Label lblAnioProfe;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.TextBox txtDocumentoProfe;
    private System.Windows.Forms.TextBox txtApellidoProfe;
    private System.Windows.Forms.TextBox txtNombreProfe;
    private System.Windows.Forms.ComboBox cmbDivisionCurso;
    private System.Windows.Forms.NumericUpDown nudAnioCurso;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.ComboBox cmbDivisionAlumno;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown nudAnio;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.Label lblDocumento;
    private System.Windows.Forms.TextBox txtApellido;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox rbtDtos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}

