namespace EngelbertSantander
{
    partial class Menú
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iIFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iIIFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iFormularioToolStripMenuItem,
            this.iIFormularioToolStripMenuItem,
            this.iIIFormularioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iFormularioToolStripMenuItem
            // 
            this.iFormularioToolStripMenuItem.Name = "iFormularioToolStripMenuItem";
            this.iFormularioToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.iFormularioToolStripMenuItem.Text = "I Formulario";
            // 
            // iIFormularioToolStripMenuItem
            // 
            this.iIFormularioToolStripMenuItem.Name = "iIFormularioToolStripMenuItem";
            this.iIFormularioToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.iIFormularioToolStripMenuItem.Text = "II Formulario";
            // 
            // iIIFormularioToolStripMenuItem
            // 
            this.iIIFormularioToolStripMenuItem.Name = "iIIFormularioToolStripMenuItem";
            this.iIIFormularioToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.iIIFormularioToolStripMenuItem.Text = "III Formulario";
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menú";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menú_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iIFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iIIFormularioToolStripMenuItem;
    }
}

