namespace frmConversor
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
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnConverEuro = new System.Windows.Forms.Button();
            this.btnConverDolar = new System.Windows.Forms.Button();
            this.btnConverPeso = new System.Windows.Forms.Button();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.lblPeso2 = new System.Windows.Forms.Label();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(35, 41);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(35, 76);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(35, 113);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(71, 41);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(77, 20);
            this.txtEuro.TabIndex = 3;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(71, 76);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(77, 20);
            this.txtDolar.TabIndex = 4;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(71, 106);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(77, 20);
            this.txtPeso.TabIndex = 5;
            // 
            // btnConverEuro
            // 
            this.btnConverEuro.Location = new System.Drawing.Point(155, 37);
            this.btnConverEuro.Name = "btnConverEuro";
            this.btnConverEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConverEuro.TabIndex = 6;
            this.btnConverEuro.Text = "->";
            this.btnConverEuro.UseVisualStyleBackColor = true;
            this.btnConverEuro.Click += new System.EventHandler(this.btnConverEuro_Click);
            // 
            // btnConverDolar
            // 
            this.btnConverDolar.Location = new System.Drawing.Point(155, 76);
            this.btnConverDolar.Name = "btnConverDolar";
            this.btnConverDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConverDolar.TabIndex = 7;
            this.btnConverDolar.Text = "->";
            this.btnConverDolar.UseVisualStyleBackColor = true;
            this.btnConverDolar.Click += new System.EventHandler(this.btnConverDolar_Click);
            // 
            // btnConverPeso
            // 
            this.btnConverPeso.Location = new System.Drawing.Point(155, 108);
            this.btnConverPeso.Name = "btnConverPeso";
            this.btnConverPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConverPeso.TabIndex = 8;
            this.btnConverPeso.Text = "->";
            this.btnConverPeso.UseVisualStyleBackColor = true;
            this.btnConverPeso.Click += new System.EventHandler(this.btnConverPeso_Click);
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Location = new System.Drawing.Point(279, 21);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(29, 13);
            this.lblEuro2.TabIndex = 9;
            this.lblEuro2.Text = "Euro";
            // 
            // lblDolar2
            // 
            this.lblDolar2.AutoSize = true;
            this.lblDolar2.Location = new System.Drawing.Point(357, 21);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(32, 13);
            this.lblDolar2.TabIndex = 10;
            this.lblDolar2.Text = "Dolar";
            // 
            // lblPeso2
            // 
            this.lblPeso2.AutoSize = true;
            this.lblPeso2.Location = new System.Drawing.Point(442, 21);
            this.lblPeso2.Name = "lblPeso2";
            this.lblPeso2.Size = new System.Drawing.Size(31, 13);
            this.lblPeso2.TabIndex = 11;
            this.lblPeso2.Text = "Peso";
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(253, 41);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(75, 20);
            this.txtEuroAEuro.TabIndex = 12;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Enabled = false;
            this.txtEuroAPeso.Location = new System.Drawing.Point(415, 41);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(75, 20);
            this.txtEuroAPeso.TabIndex = 13;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(334, 41);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(75, 20);
            this.txtEuroADolar.TabIndex = 14;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(253, 73);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(75, 20);
            this.txtDolarAEuro.TabIndex = 15;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(334, 73);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(75, 20);
            this.txtDolarADolar.TabIndex = 16;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Enabled = false;
            this.txtDolarAPeso.Location = new System.Drawing.Point(415, 73);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(75, 20);
            this.txtDolarAPeso.TabIndex = 17;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Enabled = false;
            this.txtPesoAEuro.Location = new System.Drawing.Point(253, 106);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(75, 20);
            this.txtPesoAEuro.TabIndex = 18;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Enabled = false;
            this.txtPesoADolar.Location = new System.Drawing.Point(334, 106);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(75, 20);
            this.txtPesoADolar.TabIndex = 19;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Enabled = false;
            this.txtPesoAPeso.Location = new System.Drawing.Point(415, 106);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(75, 20);
            this.txtPesoAPeso.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 151);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.lblPeso2);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.btnConverPeso);
            this.Controls.Add(this.btnConverDolar);
            this.Controls.Add(this.btnConverEuro);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblEuro;
    private System.Windows.Forms.Label lblDolar;
    private System.Windows.Forms.Label lblPeso;
    private System.Windows.Forms.TextBox txtEuro;
    private System.Windows.Forms.TextBox txtDolar;
    private System.Windows.Forms.TextBox txtPeso;
    private System.Windows.Forms.Button btnConverEuro;
    private System.Windows.Forms.Button btnConverDolar;
    private System.Windows.Forms.Button btnConverPeso;
    private System.Windows.Forms.Label lblEuro2;
    private System.Windows.Forms.Label lblDolar2;
    private System.Windows.Forms.Label lblPeso2;
    private System.Windows.Forms.TextBox txtEuroAEuro;
    private System.Windows.Forms.TextBox txtEuroAPeso;
    private System.Windows.Forms.TextBox txtEuroADolar;
    private System.Windows.Forms.TextBox txtDolarAEuro;
    private System.Windows.Forms.TextBox txtDolarADolar;
    private System.Windows.Forms.TextBox txtDolarAPeso;
    private System.Windows.Forms.TextBox txtPesoAEuro;
    private System.Windows.Forms.TextBox txtPesoADolar;
    private System.Windows.Forms.TextBox txtPesoAPeso;
  }
}

