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
    public partial class IIIFormulario : Form
    {
        public IIIFormulario()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            NombreListBox.Items.Clear();
            FuncionNombre();
        }

        public void FuncionNombre()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i %3 == 0)
                {
                    NombreListBox.Items.Add("Engelbert");
                }
                if (i %5 == 0)
                {
                    NombreListBox.Items.Add("Santader");
                }
                if (i %3 == 0 && i %5 == 0)
                {
                    NombreListBox.Items.Add("Engelbert Santader");
                }
            }
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menú menu = new Menú();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }

        private void iFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFormulario IF = new IFormulario();
            this.Hide();
            IF.ShowDialog();
            this.Show();
        }

        private void iIFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IIFormulario IIF = new IIFormulario();
            this.Hide();
            IIF.ShowDialog();
            this.Show();
        }
    }
}
