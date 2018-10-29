namespace Notepad
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.stsCaracteres = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rchText = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip2.SuspendLayout();
            this.stsCaracteres.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbrir,
            this.mnuGuardar,
            this.mnuGuardarComo});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuAbrir
            // 
            this.mnuAbrir.Name = "mnuAbrir";
            this.mnuAbrir.Size = new System.Drawing.Size(180, 22);
            this.mnuAbrir.Text = "Abrir";
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.Size = new System.Drawing.Size(180, 22);
            this.mnuGuardar.Text = "Guardar";
            this.mnuGuardar.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // mnuGuardarComo
            // 
            this.mnuGuardarComo.Name = "mnuGuardarComo";
            this.mnuGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.mnuGuardarComo.Text = "Guardar como...";
            this.mnuGuardarComo.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // stsCaracteres
            // 
            this.stsCaracteres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsCaracteres.Location = new System.Drawing.Point(0, 428);
            this.stsCaracteres.Name = "stsCaracteres";
            this.stsCaracteres.Size = new System.Drawing.Size(800, 22);
            this.stsCaracteres.TabIndex = 3;
            this.stsCaracteres.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // rchText
            // 
            this.rchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchText.Location = new System.Drawing.Point(0, 24);
            this.rchText.Name = "rchText";
            this.rchText.Size = new System.Drawing.Size(800, 404);
            this.rchText.TabIndex = 4;
            this.rchText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchText);
            this.Controls.Add(this.stsCaracteres);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.stsCaracteres.ResumeLayout(false);
            this.stsCaracteres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardar;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardarComo;
        private System.Windows.Forms.StatusStrip stsCaracteres;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox rchText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

