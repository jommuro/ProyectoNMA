using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class V_Servicios : Form
    {
        public V_Servicios()
        {
            InitializeComponent();
        }

        private void sERVICIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void sERVICIOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void V_Servicios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SERVICIO' table. You can move, or remove it, as needed.
            this.sERVICIOTableAdapter.Fill(this.dataSet1.SERVICIO);

        }
    }
}
