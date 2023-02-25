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
    }
}
