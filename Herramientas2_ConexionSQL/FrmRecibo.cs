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
    public partial class FrmRecibo : Form
    {
        public FrmRecibo()
        {
            InitializeComponent();
        }

        private void reciboBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reciboBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herramientas_DOSDataSet);

        }

        private void FrmRecibo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'herramientas_DOSDataSet.recibo' Puede moverla o quitarla según sea necesario.
            this.reciboTableAdapter.Fill(this.herramientas_DOSDataSet.recibo);

        }
    }
}
