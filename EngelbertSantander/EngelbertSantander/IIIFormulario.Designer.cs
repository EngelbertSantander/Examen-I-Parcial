namespace EngelbertSantander
{
    partial class IIIFormulario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iIFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.NombreListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.iFormularioToolStripMenuItem,
            this.iIFormularioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            this.menúToolStripMenuItem.Click += new System.EventHandler(this.menúToolStripMenuItem_Click);
            // 
            // iFormularioToolStripMenuItem
            // 
            this.iFormularioToolStripMenuItem.Name = "iFormularioToolStripMenuItem";
            this.iFormularioToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.iFormularioToolStripMenuItem.Text = "I Formulario";
            this.iFormularioToolStripMenuItem.Click += new System.EventHandler(this.iFormularioToolStripMenuItem_Click);
            // 
            // iIFormularioToolStripMenuItem
            // 
            this.iIFormularioToolStripMenuItem.Name = "iIFormularioToolStripMenuItem";
            this.iIFormularioToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.iIFormularioToolStripMenuItem.Text = "II Formulario";
            this.iIFormularioToolStripMenuItem.Click += new System.EventHandler(this.iIFormularioToolStripMenuItem_Click);
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(225, 337);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(230, 48);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // NombreListBox
            // 
            this.NombreListBox.FormattingEnabled = true;
            this.NombreListBox.ItemHeight = 16;
            this.NombreListBox.Location = new System.Drawing.Point(225, 108);
            this.NombreListBox.Name = "NombreListBox";
            this.NombreListBox.Size = new System.Drawing.Size(230, 212);
            this.NombreListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Función que muestra al usuario el nombre cuando sea multiplo de 3, el apellido cu" +
    "ando sea multiplo de 5 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "y nombre y apellido cuando sea multiplo de 3 y 5";
            // 
            // IIIFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreListBox);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IIIFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "III Formulario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iIFormularioToolStripMenuItem;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.ListBox NombreListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}