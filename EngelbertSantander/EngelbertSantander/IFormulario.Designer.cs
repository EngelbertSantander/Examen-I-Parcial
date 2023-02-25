namespace EngelbertSantander
{
    partial class IFormulario
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iIIFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(295, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 196);
            this.listBox1.TabIndex = 6;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(295, 363);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(193, 40);
            this.CalcularButton.TabIndex = 7;
            this.CalcularButton.Text = "Calcular Interés";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.formularioIIToolStripMenuItem,
            this.iIIFormularioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // formularioIIToolStripMenuItem
            // 
            this.formularioIIToolStripMenuItem.Name = "formularioIIToolStripMenuItem";
            this.formularioIIToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.formularioIIToolStripMenuItem.Text = "II Formulario";
            // 
            // iIIFormularioToolStripMenuItem
            // 
            this.iIIFormularioToolStripMenuItem.Name = "iIIFormularioToolStripMenuItem";
            this.iIIFormularioToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.iIIFormularioToolStripMenuItem.Text = "III Formulario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Calculo de interés por L200,000.00, a una tasa del 1.5% mensual y con 12 meses de" +
    " plazo";
            // 
            // IFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I Formulario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iIIFormularioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}