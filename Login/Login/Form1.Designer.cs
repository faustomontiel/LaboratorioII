namespace Login
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
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Location = new System.Drawing.Point(338, 57);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(60, 13);
            this.lblRegistrarse.TabIndex = 0;
            this.lblRegistrarse.Text = "Registrarse";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre.Location = new System.Drawing.Point(262, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApellido.Location = new System.Drawing.Point(368, 86);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido";
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCorreo.Location = new System.Drawing.Point(262, 123);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(206, 20);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "Direccion de correo electronico@yahoo.com";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContrasenia.Location = new System.Drawing.Point(262, 160);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(206, 20);
            this.txtContrasenia.TabIndex = 4;
            this.txtContrasenia.Text = "Contraseña";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+93",
            "+215",
            "+5",
            "+011",
            "+78",
            "+115"});
            this.comboBox1.Location = new System.Drawing.Point(262, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(321, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Numero de celular";
            // 
            // cmbMes
            // 
            this.cmbMes.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrebro",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(262, 238);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(100, 21);
            this.cmbMes.TabIndex = 7;
            this.cmbMes.Text = "Mes";
            // 
            // txtDia
            // 
            this.txtDia.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDia.Location = new System.Drawing.Point(368, 239);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(41, 20);
            this.txtDia.TabIndex = 8;
            this.txtDia.Text = "Dia";
            this.txtDia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAnio
            // 
            this.txtAnio.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnio.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAnio.Location = new System.Drawing.Point(424, 239);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(44, 20);
            this.txtAnio.TabIndex = 9;
            this.txtAnio.Text = "Año";
            this.txtAnio.TextChanged += new System.EventHandler(this.txtAnio_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(262, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Sexo (Opcional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "                     Al hacer clic en “Continuar”,\r\n       aceptas los Términos y" +
    " Condiciones (Actualizada) \r\n               y la Política de privacidad (Actuali" +
    "zada)";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinuar.Location = new System.Drawing.Point(298, 342);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(130, 25);
            this.btnContinuar.TabIndex = 12;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRegistrarse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinuar;
    }
}

