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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            label7.Text = FormDodajUplatu.ime1;
            label8.Text = FormDodajUplatu.prezime1;
            label11.Text = FormDodajUplatu.adresa1;
            label10.Text = FormDodajUplatu.tablice1;
            label9.Text = FormDodajUplatu.vozacka1;
            dateTimePicker1.Value = FormDodajUplatu.datum1;
            label16.Text = FormDodajUplatu.mjeseci1;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlFormattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //datum1 = DateTime.Parse(sqlFormattedDate);
            string sqlNaredba = string.Format("INSERT INTO Uplate VALUES ({0}, '{1}',{2});", FormDodajUplatu.mjeseci1, sqlFormattedDate, FormDodajUplatu.id1);
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
            DialogResult result = MessageBox.Show("Uplata uspješno izvršena!", "Akcija uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new Form7().Show();
            this.Hide();
        }
    }
}
