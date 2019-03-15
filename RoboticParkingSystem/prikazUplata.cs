using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboticParkingSystem
{
    public partial class prikazUplata : Form
    {
        public prikazUplata()
        {
            InitializeComponent();
        }

        private void uplateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uplateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet1);

        }

        private void prikazUplata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet1.Uplate' table. You can move, or remove it, as needed.
            this.uplateTableAdapter.Fill(this.database2DataSet1.Uplate);

        }
    }
}
