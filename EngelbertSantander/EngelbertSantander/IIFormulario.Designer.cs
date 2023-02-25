namespace EngelbertSantander
{
    partial class IIFormulario
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
            this.iIIFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.iFormularioToolStripMenuItem,
            this.iIIFormularioToolStripMenuItem});
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
            // 
            // iFormularioToolStripMenuItem
            // 
            this.iFormularioToolStripMenuItem.Name = "iFormularioToolStripMenuItem";
            this.iFormularioToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.iFormularioToolStripMenuItem.Text = "I Formulario";
            // 
            // iIIFormularioToolStripMenuItem
            // 
            this.iIIFormularioToolStripMenuItem.Name = "iIIFormularioToolStripMenuItem";
            this.iIIFormularioToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.iIIFormularioToolStripMenuItem.Text = "III Formulario";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(196, 269);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(187, 36);
            this.CalcularButton.TabIndex = 1;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(274, 114);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(306, 22);
            this.ProductoTextBox.TabIndex = 2;
            this.ProductoTextBox.Text = "II Formulario";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(274, 166);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(306, 22);
            this.PrecioTextBox.TabIndex = 3;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(274, 217);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(306, 22);
            this.CantidadTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(393, 269);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(187, 36);
            this.LimpiarButton.TabIndex = 8;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // IIFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.ProductoTextBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IIFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "II Formulario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iIIFormularioToolStripMenuItem;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LimpiarButton;
    }
}