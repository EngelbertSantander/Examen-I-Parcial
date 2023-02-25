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
    public partial class IFormulario : Form
    {
        public IFormulario()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string FechaInicial = "01/01/2023";
            DateTime FechaActual = new DateTime();
            FechaActual = DateTime.Parse(FechaInicial.ToString());

            for (int i = 0; i < 12; i++)
            {
                listBox1.Items.Add (FechaActual.AddMonths(i) + " = " + (200000 * 0.015) * (i+1));
            }
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menú menu = new Menú();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }

        private void formularioIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IIFormulario IIF = new IIFormulario();
            this.Hide();
            IIF.ShowDialog();
            this.Show();
        }

        private void iIIFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IIIFormulario IIIF = new IIIFormulario();
            this.Hide();
            IIIF.ShowDialog();
            this.Show();
        }
    }
}
