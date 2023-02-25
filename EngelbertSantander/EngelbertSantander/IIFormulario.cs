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
    public partial class IIFormulario : Form
    {
        public IIFormulario()
        {
            InitializeComponent();
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(PrecioTextBox.Text);
            double cantidad = Convert.ToDouble(CantidadTextBox.Text);

            MessageBox.Show("El descuento es de: " + await DescuentoTotal(precio, cantidad));
            MessageBox.Show("El total a pagar es de: " + await PagoTotal(precio, cantidad));

        }
        private async Task<double> DescuentoTotal(double precio, double x)
        {
            var DescuentoFinal = await Task.Run(() =>
            {
                return (precio * x) * 0.15;
            });
                return DescuentoFinal;
        }
        private async Task<double> PagoTotal(double precio, double y)
        {
            double SubTotal = (precio * y), Descuento = ((precio * y) * 0.15);
            var FinalTotal = await Task.Run(() =>
            {
                return SubTotal - Descuento;
            });
            return FinalTotal;
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            ProductoTextBox.Clear();
            PrecioTextBox.Clear();  
            CantidadTextBox.Clear();    
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

        private void iIIFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IIIFormulario IIIF = new IIIFormulario();
            this.Hide();
            IIIF.ShowDialog();
            this.Show();
        }
    }
}
