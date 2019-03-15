using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RoboticParkingSystem
{
    public partial class Form7 : Form
    {
        Color svijetloZelena = Color.FromArgb(16, 172, 132);
        //this.unos.Visible=false;
        Color tamnoZelena = Color.FromArgb(11, 111, 86);
        private System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable("Alarmi");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                string sqlNaredba = "select TekstAlarma as 'Tekst alarma',VrijemeAlarma as 'Vrijeme alarma', Prioritet,Obradjen from Alarmi order by Prioritet ASC";

                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba, cn))
                {

                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                }
            }
            // podesavanje sirine pojedinih kolona
            dataGridView2.Columns[0].Width = 220;
            dataGridView2.Columns[1].Width = 210;
            dataGridView2.Columns[2].Width = 93;
            dataGridView2.Columns[3].Width = 84;

            // podesavanje boje ovisno od prioriteta alarma
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToInt32(row.Cells[2].Value) == 1)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 166, 166);
                else if (Convert.ToInt32(row.Cells[2].Value) == 2)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 206, 157);
                else
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 125);
            }

            // TODO: This line of code loads data into the 'database2DataSet2.Klijenti' table. You can move, or remove it, as needed.
            //this.klijentiTableAdapter.Fill(this.database2DataSet2.Klijenti);
            
            //this.button2.BackColor = SystemColors.Control;
            //this.button2.ForeColor = SystemColors.ControlText;
            //this.button2.Font = new Font("MS Sans Serif", 13);
            //DataGridViewRow row1 = dataGridView1.Rows[0];
            //DataGridViewRow row2 = dataGridView1.Rows[1];
            //row1.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);
            //row2.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);
        }

            private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
            button2.ForeColor = SystemColors.ControlText;
            panel4.Visible = false;
            button3.BackColor = Color.FromArgb(72, 126, 176);
            button4.BackColor= Color.FromArgb(72, 126, 176);

            button3.ForeColor = SystemColors.ControlLightLight;

            button2.Font = new Font("MS Sans Serif", 13);
            button3.Font = new Font("MS Sans Serif", 12);
            panel1.BackColor= Color.FromArgb(72, 126, 176);
            button1.BackColor = Color.FromArgb(72, 126, 176);
            uplata.Visible = false;
            unos.Visible = true;
            label2.Visible = false;
            label1.Visible = true;
            //Form5.DefaultBackColor.= Color.FromArgb(72, 126, 176);
            unos.Controls.Clear();
            Form5 novaforma = new Form5();
            novaforma.TopLevel = false;
            unos.Controls.Add(novaforma);
            novaforma.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = SystemColors.ControlText;

            button2.BackColor = Color.FromArgb(255, 159, 67);
            button4.BackColor = Color.FromArgb(255, 159, 67);
            button2.ForeColor = SystemColors.ControlLightLight;

            button3.Font = new Font("MS Sans Serif", 13);
            button2.Font = new Font("MS Sans Serif", 12);
            panel1.BackColor = Color.FromArgb(255, 159, 67);
            button1.BackColor = Color.FromArgb(255, 159, 67);
            uplata.Visible = true;
            unos.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            panel4.Visible = false;
            //Form5.DefaultBackColor.= Color.FromArgb(72, 126, 176);
            uplata.Controls.Clear();
            FormDodajUplatu novaforma1 = new FormDodajUplatu();
            novaforma1.TopLevel = false;
            uplata.Controls.Add(novaforma1);
            novaforma1.Show();
        }

        private void uplata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
