using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RoboticParkingSystem
{
    public partial class Form6 : Form
    {
        Color svijetloZelena = Color.FromArgb(16, 172, 132);
        Color tamnoZelena = Color.FromArgb(11, 111, 86);
        private System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();
        public Form6()
        {
            InitializeComponent();
        }
       
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet2.Klijenti' table. You can move, or remove it, as needed.
            //this.klijentiTableAdapter.Fill(this.database2DataSet2.Klijenti);
            DataTable dt = new DataTable("Klijenti");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //nesto ne valja sa ovom naredbom
                string sqlNaredba = "select Klijenti.Ime,Klijenti.Prezime,Klijenti.Adresa,Klijenti.Registracija,Klijenti.Vozacka,datefromparts(year(Uplate.DatumUplate),month(Uplate.DatumUplate)+Uplate.BrojMjeseci,day(Uplate.DatumUplate)) as 'Uplata vazi do' from Klijenti inner join Uplate on Uplate.ClientID = Klijenti.ClientID ";
                string sqlNaredba2 = "where datefromparts(year(Uplate.DatumUplate),month(Uplate.DatumUplate)+Uplate.BrojMjeseci,day(Uplate.DatumUplate)) >= GETDATE();";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba+sqlNaredba2, cn))
                {

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }

            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
            button1.Font = new Font("MS Sans Serif", 13);
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            DataGridViewRow row1 = dataGridView1.Rows[0];
            DataGridViewRow row2 = dataGridView1.Rows[1];
            row1.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);
            row2.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label2.ForeColor = Color.FromArgb(72, 126, 176);
            label3.ForeColor = Color.FromArgb(32, 56, 79);


            toolTip1.SetToolTip(label2, "Prikaz korisnika sa važećom uplatom.");
            toolTip1.SetToolTip(label3, "Prikaz svih korisnika.");
            toolTip1.SetToolTip(pictureBox2, "Novi korisnici.");
            toolTip1.SetToolTip(pictureBox3, "Novi korisnici.");
            toolTip1.SetToolTip(button7, "Pritanje PDF dokumenta izvještaja uplata.");
            toolTip1.SetToolTip(button6, "Printanje PDF dokumenta izvještaja alarma.");
            toolTip1.SetToolTip(label8, "Prikaz svih alarma.");
            toolTip1.SetToolTip(label5, "Prikaz alarma s prioritetom 1");
            toolTip1.SetToolTip(label6, "Prikaz alarma s prioritetom 2");
            toolTip1.SetToolTip(label7, "Prikaz alarma s prioritetom 3");
            toolTip1.SetToolTip(button8, "Pomoć");
            


            button5.ImageList = imageList1;
            button5.ImageIndex = 0;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.TextAlign = ContentAlignment.MiddleRight;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(16, 172, 132);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Font = new Font("MS Sans Serif", 12);

            button2.BackColor = SystemColors.Control;
            button2.ForeColor = SystemColors.ControlText;
            button2.Font = new Font("MS Sans Serif", 13);

            button3.BackColor = Color.FromArgb(16, 172, 132);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Font = new Font("MS Sans Serif", 12);

            button4.BackColor = Color.FromArgb(16, 172, 132);
            splitter1.BackColor = Color.FromArgb(16, 172, 132);
            pictureBox1.BackColor = Color.FromArgb(16, 172, 132);
            button8.BackColor = Color.FromArgb(16, 172, 132);
            panel3.Visible = true;
            panel4.Visible = false;
            panel1.Visible = false;

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





        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 159, 67);
            button1.ForeColor = SystemColors.ControlLightLight;

            button3.BackColor = SystemColors.Control;
            button3.ForeColor = SystemColors.ControlText;

            button2.BackColor = Color.FromArgb(255, 159, 67);
            button2.ForeColor = SystemColors.ControlLightLight;

            button1.Font = new Font("MS Sans Serif", 12);
            button2.Font = new Font("MS Sans Serif", 12);
            button3.Font = new Font("MS Sans Serif", 13);
            button4.BackColor = Color.FromArgb(255, 159, 67);
            splitter1.BackColor = Color.FromArgb(255, 159, 67);
            pictureBox1.BackColor = Color.FromArgb(255, 159, 67);
            button8.BackColor = Color.FromArgb(255, 159, 67);
            DataTable dt = new DataTable("Uplate");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                
                string sqlNaredba = "select Klijenti.Ime, Klijenti.Prezime, Uplate.DatumUplate as 'Datum uplate', Uplate.BrojMjeseci as 'Broj mjeseci' from Uplate inner join Klijenti on Uplate.ClientID = Klijenti.ClientID order by DatumUplate DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba, cn))
                {

                    da.Fill(dt);
                    dataGridView3.DataSource = dt;

                }
            }
            dataGridView3.Columns[0].Width = 145;
            dataGridView3.Columns[1].Width = 175;
            dataGridView3.Columns[2].Width = 200;
            dataGridView3.Columns[3].Width = 84;

            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(72, 126, 176);
            button2.ForeColor = SystemColors.ControlLightLight;

            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;

            button3.BackColor = Color.FromArgb(72, 126, 176);
            button3.ForeColor = SystemColors.ControlLightLight;

            button1.Font = new Font("MS Sans Serif", 13);
            button2.Font = new Font("MS Sans Serif", 12);
            button3.Font = new Font("MS Sans Serif", 12);

            panel1.Visible = true;
            DataGridViewRow row1 = dataGridView1.Rows[0];
            DataGridViewRow row2 = dataGridView1.Rows[1];
            row1.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);
            row2.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);

            button4.BackColor = Color.FromArgb(72, 126, 176);
            splitter1.BackColor = Color.FromArgb(72, 126, 176);
            pictureBox1.BackColor = Color.FromArgb(72, 126, 176);
            button8.BackColor = Color.FromArgb(72, 126, 176);
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            panel3.Visible = false;
            panel4.Visible = false;

            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(72, 126, 176);
            label2.ForeColor = Color.FromArgb(32, 56, 79);
            DataTable dt = new DataTable("Klijenti");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //nesto ne valja sa ovom naredbom
                string sqlNaredba = "select Klijenti.Ime,Klijenti.Prezime,Klijenti.Adresa,Klijenti.Registracija,Klijenti.Vozacka,datefromparts(year(Uplate.DatumUplate),month(Uplate.DatumUplate)+Uplate.BrojMjeseci,day(Uplate.DatumUplate)) as 'Uplata vazi do' from Klijenti inner join Uplate on Uplate.ClientID = Klijenti.ClientID;";
               
                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba, cn))
                {

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(72, 126, 176);
            label3.ForeColor = Color.FromArgb(32, 56, 79);
            DataTable dt = new DataTable("Klijenti");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //nesto ne valja sa ovom naredbom
                string sqlNaredba = "select Klijenti.Ime,Klijenti.Prezime,Klijenti.Adresa,Klijenti.Registracija,Klijenti.Vozacka,datefromparts(year(Uplate.DatumUplate),month(Uplate.DatumUplate)+Uplate.BrojMjeseci,day(Uplate.DatumUplate)) as 'Uplata vazi do' from Klijenti inner join Uplate on Uplate.ClientID = Klijenti.ClientID ";
                string sqlNaredba2 = "where datefromparts(year(Uplate.DatumUplate),month(Uplate.DatumUplate)+Uplate.BrojMjeseci,day(Uplate.DatumUplate)) >= GETDATE();";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba + sqlNaredba2, cn))
                {

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
        }

        private void label2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            if (panel1.Visible == true)

                this.dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            else if (panel3.Visible == true)
                this.dataGridView2.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            else
                this.dataGridView3.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(bm, 0, 0);
    
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ForeColor = svijetloZelena;
            label6.ForeColor = tamnoZelena;
            label7.ForeColor = tamnoZelena;
            label8.ForeColor = tamnoZelena;
            DataTable dt = new DataTable("Alarmi");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //nesto ne valja sa ovom naredbom
                string sqlNaredba = "select TekstAlarma as 'Tekst alarma',VrijemeAlarma as 'Vrijeme alarma',Obradjen from Alarmi ";
                string sqlNaredba2 = "where Prioritet = 1;";
               
                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba+sqlNaredba2, cn))
                {

                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                }
            }
            dataGridView2.Columns[0].Width = 266;
            dataGridView2.Columns[1].Width = 256;
            dataGridView2.Columns[2].Width = 84;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 166, 166);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Alarmi");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //nesto ne valja sa ovom naredbom
                string sqlNaredba = "select TekstAlarma as 'Tekst alarma',VrijemeAlarma as 'Vrijeme alarma', Prioritet,Obradjen from Alarmi order by Prioritet ASC";



                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba, cn))
                {

                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                }
            }
            label5.ForeColor = tamnoZelena;
            label6.ForeColor = tamnoZelena;
            label7.ForeColor = tamnoZelena;
            label8.ForeColor = svijetloZelena;
            dataGridView2.Columns[0].Width = 220;
            dataGridView2.Columns[1].Width = 210;
            dataGridView2.Columns[2].Width = 93;
            dataGridView2.Columns[3].Width = 84;
           
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToInt32(row.Cells[2].Value) == 1)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 166, 166);
                else if (Convert.ToInt32(row.Cells[2].Value) == 2)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 206, 157);
                else
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 125);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Alarmi");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //nesto ne valja sa ovom naredbom
                string sqlNaredba = "select TekstAlarma as 'Tekst alarma',VrijemeAlarma as 'Vrijeme alarma',Obradjen from Alarmi ";
                string sqlNaredba2 = "where Prioritet = 2;";

                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba+sqlNaredba2, cn))
                {

                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                }
            }
            label5.ForeColor = tamnoZelena;
            label6.ForeColor = svijetloZelena;
            label7.ForeColor = tamnoZelena;
            label8.ForeColor = tamnoZelena;
            dataGridView2.Columns[0].Width = 266;
            dataGridView2.Columns[1].Width = 256;
            dataGridView2.Columns[2].Width = 84;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 206, 157);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Alarmi");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //nesto ne valja sa ovom naredbom
                string sqlNaredba = "select TekstAlarma as 'Tekst alarma',VrijemeAlarma as 'Vrijeme alarma',Obradjen from Alarmi ";
                string sqlNaredba2 = "where Prioritet = 3;";

                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba + sqlNaredba2, cn))
                {

                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                }
            }
            
           
            label5.ForeColor = tamnoZelena;
            label6.ForeColor = tamnoZelena;
            label7.ForeColor = svijetloZelena;
            label8.ForeColor = tamnoZelena;
            dataGridView2.Columns[0].Width = 266;
            dataGridView2.Columns[1].Width = 256;

            dataGridView2.Columns[2].Width = 84;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 125);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }


        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView3.ClearSelection();
        }

        private void dataGridView2_Sorted(object sender, EventArgs e)
        {   if (label8.ForeColor == svijetloZelena)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToInt32(row.Cells[2].Value) == 1)
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 166, 166);
                    else if (Convert.ToInt32(row.Cells[2].Value) == 2)
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 206, 157);
                    else
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 125);
                }
            } 
            else if (label5.ForeColor == svijetloZelena)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 166, 166);
                   
                }
            }
            else if (label6.ForeColor == svijetloZelena)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 206, 157);

                }
            }
            else if (label7.ForeColor == svijetloZelena)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255,255,125);

                }
            }
        }

        private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite promijeniti status alarma?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                dataGridView2.CancelEdit();
                //dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToBoolean(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) ? true : false;
            }
            else
                dataGridView2.EndEdit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
