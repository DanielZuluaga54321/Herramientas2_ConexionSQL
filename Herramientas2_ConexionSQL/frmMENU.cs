using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramientas2_ConexionSQL
{
    public partial class frmMENU : Form
    {
        public frmMENU()
        {
            InitializeComponent();
        }

        private void frmMENU_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes objClientes = new FrmClientes();
            objClientes.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProducto1 objProductos = new FrmProducto1();
            objProductos.ShowDialog();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            FrmRecibo objRecibo = new FrmRecibo();
            objRecibo.ShowDialog();

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FrmVenta objVenta = new FrmVenta();
            objVenta.ShowDialog();

        }
    }
}
