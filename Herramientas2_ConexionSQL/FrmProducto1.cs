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
    public partial class FrmProducto1 : Form
    {
        public FrmProducto1()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herramientas_DOSDataSet);

        }

        private void FrmProducto1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'herramientas_DOSDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.herramientas_DOSDataSet.producto);

        }
    }
}
