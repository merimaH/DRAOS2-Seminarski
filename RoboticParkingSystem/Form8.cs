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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            label7.Text = Form5.ime1;
            label8.Text = Form5.prezime1;
            label9.Text = Form5.vozacka1;
            label10.Text = Form5.tablice1;
            label11.Text = Form5.adresa1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Korisnik uspješno dodan!", "Akcija uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new Form7().Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }
    }
}
