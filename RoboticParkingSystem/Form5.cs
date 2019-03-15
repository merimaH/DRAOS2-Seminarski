using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace RoboticParkingSystem
{
    public partial class Form5 : Form
    {
        public static string ime1 = "";
        public static string prezime1 = "";
        public static string vozacka1 = "";
        public static string tablice1 = "";
        public static string adresa1 = "";
        public Form5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            DialogResult result =  System.Windows.Forms.MessageBox.Show("Postavite kažiprst na senzor!");
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(RoboticParkingSystem.Properties.Resources.fp1);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String ime = textBox1.Text;
            String prezime = textBox2.Text;
            String adresa = textBox4.Text;
            String vozacka = maskedTextBox1.Text;
            String registracija = textBox3.Text;
            bool flag_validno = true;
            // validacija podataka i postavljanje da su pogresni
            // doda se errorprovider kontrola, samo se prevuce tamo 

            // treba postaviti da je inicijalno null
            if (pictureBox1.Image == null)
            {
                errorProvider1.SetError(button1, "Potreban je otisak prsta");
                button1.Select();
                flag_validno = false;
            }
            else
                errorProvider1.SetError(button1, "");

            //validacija da se mora unijet adresa
            if (adresa.Length == 0)
            {
                errorProvider1.SetError(textBox4, "Morate unijeti adresu.");
                textBox4.Select();
                flag_validno = false;
            }

            else
                errorProvider1.SetError(textBox4, "");

            //validacija da registracija mora biti 9 znakova
            if (registracija.Length != 9 || (Regex.Matches(registracija, @"[AEJKMOT][1-9]{2}-[AEJKMOT]-[1-9]{3}").Count != 1 &&
                    Regex.Matches(registracija, @"TA-[1-9]{6}").Count != 1))
            {
                errorProvider1.SetError(textBox3, "Pogrešna registarska oznaka");
                textBox3.Select();
                flag_validno = false;
            }
            else
                errorProvider1.SetError(textBox3, "");

            if (vozacka.Length == 0)
            {
                errorProvider1.SetError(maskedTextBox1, "Neispravan serijski broj.");
                maskedTextBox1.Select();
                flag_validno = false;
            }
            else
                errorProvider1.SetError(maskedTextBox1, "");

            //validacija prezimena 
            if (Regex.Matches(prezime, @"[a-zA-Z]").Count != prezime.Length || prezime.Length == 0)
            {
                errorProvider1.SetError(textBox2, "Neispravno prezime.");
                textBox2.Select();
                flag_validno = false;
            }
            else
                errorProvider1.SetError(textBox2, "");

            //validacija imena 
            if (Regex.Matches(ime, @"[a-zA-Z]").Count != ime.Length || ime.Length == 0)
            {
                errorProvider1.SetError(textBox1, "Neispravno ime.");
                textBox1.Select();
                flag_validno = false;
            }
            else
                errorProvider1.SetError(textBox1, "");
            if (flag_validno)
            {
                ime1 = ime;
                prezime1 = prezime;
                adresa1 = adresa;
                vozacka1 = vozacka;
                tablice1 = registracija;
                Image img = pictureBox1.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                string sqlCommand = "INSERT INTO Klijenti VALUES('"+ime+"','"+prezime+"', '"+adresa+"', '"+registracija+ "', '"+vozacka+ "', '"+arr + "');";
                Program.izvrsiSql(sqlCommand);


                Klijenti_lista.data.Add(new Client(ime, prezime, adresa, pictureBox1.Image, registracija, vozacka));
                //DialogResult result = MessageBox.Show("Korisnik uspješno dodan!", "Akcija uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form8().Show();
                this.Hide();
                //Form7.Close();
                var first = Application.OpenForms.OfType<Form7>().FirstOrDefault();
                if (first != null)
                    first.Hide();


                //Form7.ScrollStateHScrollVisible = false;
            }

            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox1.SelectAll();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
