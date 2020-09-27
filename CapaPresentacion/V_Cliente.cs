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
    public partial class V_Cliente : Form
    {
        public V_Cliente()
        {
            InitializeComponent();
        }

        private void V_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CLIENTE_EMPRESA' table. You can move, or remove it, as needed.
            this.cLIENTE_EMPRESATableAdapter.Fill(this.dataSet1.CLIENTE_EMPRESA);

        }

        private void cLIENTE_EMPRESABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTE_EMPRESABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
