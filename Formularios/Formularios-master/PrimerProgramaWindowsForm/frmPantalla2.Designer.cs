namespace PrimerProgramaWindowsForm
{
    partial class FrmPantalla2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkEnviaPublicidad = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbNacionalidad = new System.Windows.Forms.GroupBox();
            this.rdoArgentino = new System.Windows.Forms.RadioButton();
            this.rdoExtranjero = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lstPosicion = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.grbNacionalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnviaPublicidad
            // 
            this.chkEnviaPublicidad.AutoSize = true;
            this.chkEnviaPublicidad.Checked = true;
            this.chkEnviaPublicidad.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEnviaPublicidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEnviaPublicidad.Location = new System.Drawing.Point(42, 22);
            this.chkEnviaPublicidad.Name = "chkEnviaPublicidad";
            this.chkEnviaPublicidad.Size = new System.Drawing.Size(105, 17);
            this.chkEnviaPublicidad.TabIndex = 0;
            this.chkEnviaPublicidad.Text = "Envia Publicidad";
            this.chkEnviaPublicidad.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(78, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbNacionalidad
            // 
            this.grbNacionalidad.Controls.Add(this.rdoExtranjero);
            this.grbNacionalidad.Controls.Add(this.rdoArgentino);
            this.grbNacionalidad.Location = new System.Drawing.Point(52, 55);
            this.grbNacionalidad.Name = "grbNacionalidad";
            this.grbNacionalidad.Size = new System.Drawing.Size(200, 111);
            this.grbNacionalidad.TabIndex = 2;
            this.grbNacionalidad.TabStop = false;
            this.grbNacionalidad.Text = "Estudiante";
            // 
            // rdoArgentino
            // 
            this.rdoArgentino.AutoSize = true;
            this.rdoArgentino.Location = new System.Drawing.Point(10, 32);
            this.rdoArgentino.Name = "rdoArgentino";
            this.rdoArgentino.Size = new System.Drawing.Size(85, 17);
            this.rdoArgentino.TabIndex = 0;
            this.rdoArgentino.TabStop = true;
            this.rdoArgentino.Text = "radioButton1";
            this.rdoArgentino.UseVisualStyleBackColor = true;
            // 
            // rdoExtranjero
            // 
            this.rdoExtranjero.AutoSize = true;
            this.rdoExtranjero.Location = new System.Drawing.Point(10, 70);
            this.rdoExtranjero.Name = "rdoExtranjero";
            this.rdoExtranjero.Size = new System.Drawing.Size(85, 17);
            this.rdoExtranjero.TabIndex = 1;
            this.rdoExtranjero.TabStop = true;
            this.rdoExtranjero.Text = "radioButton2";
            this.rdoExtranjero.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(278, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton2";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(278, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lstPosicion
            // 
            this.lstPosicion.FormattingEnabled = true;
            this.lstPosicion.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sesto",
            "Septimo"});
            this.lstPosicion.Location = new System.Drawing.Point(474, 47);
            this.lstPosicion.Name = "lstPosicion";
            this.lstPosicion.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPosicion.Size = new System.Drawing.Size(120, 95);
            this.lstPosicion.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(275, 170);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(335, 167);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 69);
            this.txtNombre.TabIndex = 7;
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Items.AddRange(new object[] {
            "Argentina",
            "Bolivia",
            "Brasil",
            "Chile",
            "Ecuador",
            "Paraguay",
            "Peru",
            "Uruguay",
            "Venezuela"});
            this.cmbPais.Location = new System.Drawing.Point(510, 162);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 8;
            // 
            // FrmPantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 400);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstPosicion);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.grbNacionalidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkEnviaPublicidad);
            this.Name = "FrmPantalla2";
            this.Text = "frmPantalla2";
            this.Load += new System.EventHandler(this.FrmPantalla2_Load);
            this.grbNacionalidad.ResumeLayout(false);
            this.grbNacionalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnviaPublicidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grbNacionalidad;
        private System.Windows.Forms.RadioButton rdoExtranjero;
        private System.Windows.Forms.RadioButton rdoArgentino;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox lstPosicion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbPais;
    }
}