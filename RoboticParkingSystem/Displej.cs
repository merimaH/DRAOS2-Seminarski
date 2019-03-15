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
    public partial class Displej : Form
    {
        PictureBox auto = new PictureBox();
        TextBox kraj = new TextBox();
        Button lijevodugme = new Button();
        Button desnodugme = new Button();
        Button poruka = new Button();



        public Displej()
        {
            InitializeComponent();
            kraj = this.textBox1;
            kraj.Visible = false;
            poruka = this.napustiautomobil;
            poruka.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Displej_Load(object sender, EventArgs e)
        {
            //Pen BlackPen = new Pen(Color.Black, 3);
            //e.Graphics.DrawRectangle(BlackPen, 0, 0, 200, 200);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lijevo_Click(object sender, EventArgs e)
        {
            auto = this.pictureBox1;
            if (auto.Left - 10 > -5)
            {
                auto.Left -= 10;
            }
            else
            {
               
                //poruka
            }
            lijevodugme = this.lijevo;
            desnodugme = this.desno;
            //provjera jel u zelenom
            if (auto.Location.X < 38)
            {
                //vidljiv
                lijevodugme.BackColor = Color.Red;
                desnodugme.BackColor = Color.LawnGreen;

            }
            //else
            //{
            //nevidljiv
            //}

            if (auto.Location.X > 38 && auto.Location.X < 68 )
            {
                kraj.Visible = true;
                poruka.Visible = true;
            }
            else
            {
                kraj.Visible = false;
                poruka.Visible = false;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
