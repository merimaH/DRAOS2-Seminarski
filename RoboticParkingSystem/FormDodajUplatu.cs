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
        public static string ime1 = "";
        public static string prezime1 = "";
        public static string vozacka1 = "";
        public static string tablice1 = "";
        public static string adresa1 = "";
        public static DateTime datum1=new DateTime(2004, 1, 1);
        public static string mjeseci1 = "";
        public static int id1 = 0;
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
                mjeseci1 = brojMjeseci.ToString();
                if (checkBox1.Checked == true)
                {
                    brojMjeseci = Convert.ToInt32(numericUpDown1.Value);
                    mjeseci1 = brojMjeseci.ToString();
                }
                //ime1=Klijenti_lista.data.SequenceEqual<id>.ToString();
                ime1 = dataGridView1.Rows[id-1].Cells[1].Value.ToString();
                prezime1 = dataGridView1.Rows[id-1].Cells[2].Value.ToString();
                adresa1 = dataGridView1.Rows[id - 1].Cells[3].Value.ToString();
                tablice1 = dataGridView1.Rows[id - 1].Cells[4].Value.ToString();
                vozacka1 = dataGridView1.Rows[id - 1].Cells[5].Value.ToString();
                id1= int.Parse(dataGridView1.Rows[id - 1].Cells[0].Value.ToString());
                //ime1 = dataGridView1.Rows[id - 1].Cells[1].Value.ToString();
                datum1 = dateTimePicker1.Value;
                string sqlFormattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
                //datum1 = DateTime.Parse(sqlFormattedDate);
                //string sqlNaredba = string.Format("INSERT INTO Uplate VALUES ({0}, '{1}',{2});",  brojMjeseci, sqlFormattedDate, id);
                //using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
                //{
                    //if (cn.State == ConnectionState.Closed)
                    //{
                      //  cn.Open();
                   // }
                    //SqlCommand sqlCommand = new SqlCommand(sqlNaredba, cn);
                    //sqlCommand.BeginExecuteNonQuery();
                    //sqlCommand.ExecuteNonQuery();

                    //SqlDataAdapter da = new SqlDataAdapter(sqlNaredba, cn);
                    
                //}
            }
            //new prikazUplata().Show();
            new Form9().Show();
            this.Hide();
            //Form7.Close();
            var first = Application.OpenForms.OfType<Form7>().FirstOrDefault();
            if (first != null)
                first.Hide();
            //textBox1.Text = id.ToString();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
