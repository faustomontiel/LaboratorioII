namespace GuiFormulario
{
    partial class FrmSirviente
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
            this.lblEnergia = new System.Windows.Forms.Label();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.nudCodigo = new System.Windows.Forms.NumericUpDown();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Location = new System.Drawing.Point(12, 9);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(45, 13);
            this.lblEnergia.TabIndex = 0;
            this.lblEnergia.Text = "Energía";
            // 
            // txtEnergia
            // 
            this.txtEnergia.Location = new System.Drawing.Point(15, 25);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(196, 20);
            this.txtEnergia.TabIndex = 1;
            // 
            // nudCodigo
            // 
            this.nudCodigo.Location = new System.Drawing.Point(217, 25);
            this.nudCodigo.Name = "nudCodigo";
            this.nudCodigo.Size = new System.Drawing.Size(120, 20);
            this.nudCodigo.TabIndex = 2;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(15, 64);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(196, 20);
            this.txtOrigen.TabIndex = 4;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(12, 48);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Origen";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(214, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 125);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(325, 23);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // FrmSirviente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 173);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.nudCodigo);
            this.Controls.Add(this.txtEnergia);
            this.Controls.Add(this.lblEnergia);
            this.Name = "FrmSirviente";
            this.Text = "Crear Robot Sirviente";
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.TextBox txtEnergia;
        private System.Windows.Forms.NumericUpDown nudCodigo;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblCodigo;
    private System.Windows.Forms.Button btnCrear;
  }
}

