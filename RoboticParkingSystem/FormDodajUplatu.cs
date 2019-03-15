using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RoboticParkingSystem
{
    public partial class FormDodajUplatu : Form
    {
        public FormDodajUplatu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable("Klijenti");
        private void FormDodajUplatu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet1.Klijenti' table. You can move, or remove it, as needed.
            //this.klijentiTableAdapter.Fill(this.database2DataSet1.Klijenti);
            // TODO: This line of code loads data into the 'database2DataSet1.Uplate' table. You can move, or remove it, as needed.
            //this.uplateTableAdapter.Fill(this.database2DataSet1.Uplate);

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                using (SqlDataAdapter da = new SqlDataAdapter("select * from Klijenti", cn))
                {

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.MultiSelect = false; // da se može samo jedan selektovati
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void nadjiImeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.klijentiTableAdapter.NadjiIme(this.database2DataSet1.Klijenti);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Ime like '%{0}%' or Prezime like '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // treba ocitati koji red je selektovan i taj id dodati u novu uplatu

            if(checkBox1.Checked == true)
            {
                label3.Visible = true;
                numericUpDown1.Visible = true;
            }
            else
            {
                label3.Visible = false;
                numericUpDown1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection redovi = dataGridView1.SelectedRows;
            if (redovi.Count == 0)
                errorProvider1.SetError(dataGridView1, "Morate selektovati klijenta");
            else
            {
                DataGridViewRow red = redovi[0];
                int id = int.Parse(red.Cells[0].Value.ToString());
                Program.brojacUplata += 1;
                int brojMjeseci = 1;
                if (checkBox1.Checked == true)
                    brojMjeseci = Convert.ToInt32(numericUpDown1.Value);
                string sqlFormattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string sqlNaredba = string.Format("INSERT INTO Uplate VALUES ({0}, '{1}',{2});",  brojMjeseci, sqlFormattedDate, id);
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    SqlCommand sqlCommand = new SqlCommand(sqlNaredba, cn);
                    //sqlCommand.BeginExecuteNonQuery();
                    sqlCommand.ExecuteNonQuery();

                    //SqlDataAdapter da = new SqlDataAdapter(sqlNaredba, cn);
                    
                }
            }
            new prikazUplata().Show();
            //textBox1.Text = id.ToString();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
