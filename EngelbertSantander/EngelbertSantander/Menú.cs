using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngelbertSantander
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void iFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iIFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFormulario IF = new IFormulario();
            this.Hide(); 
            IF.ShowDialog();
            this.Show();
        }

        private void iIIFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IIFormulario IIF = new IIFormulario();
            this.Hide();
            IIF.ShowDialog();
            this.Show();
        }

        private void iIIFormularioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IIIFormulario IIIF = new IIIFormulario();
            this.Hide();
            IIIF.ShowDialog();
            this.Show();
        }
    }
}
