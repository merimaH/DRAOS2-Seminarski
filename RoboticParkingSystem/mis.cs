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
    public partial class mis : Form {

        PictureBox auto = new PictureBox();
        TextBox zid1 = new TextBox();
       


        TextBox kraj = new TextBox();
        Button lijevodugme = new Button();
        Button desnodugme = new Button();
        Button poruka = new Button();

        TextBox upute = new TextBox();
        TextBox desno1 = new TextBox();
        TextBox lijevo1 = new TextBox();
        TextBox napred3 = new TextBox();
        TextBox nazad1 = new TextBox();

        Panel napred2 = new Panel();
        Panel desno2 = new Panel();
        Panel lijevo2 = new Panel();
        Panel nazad2 = new Panel();
        
        

        Panel zeleno = new Panel();
        bool blinkLeft = false;
        bool blinkRight = false;
        bool blinkUp = false;
        bool blinkDown = false;

        private async void BlinkLeft()
        {
            while (true)
            {
                await Task.Delay(500);
                if (blinkLeft)
                    lijevopanel.BackColor = lijevopanel.BackColor == Color.Red ? Color.Transparent : Color.Red;
                else
                {
                    lijevopanel.BackColor = Color.Transparent;
                }
                if (blinkRight)
                    desnopanel.BackColor = desnopanel.BackColor == Color.Red ? Color.Transparent : Color.Red;
                else
                {
                    desnopanel.BackColor = Color.Transparent;
                }
                if (blinkUp)
                    napredpanel.BackColor = napredpanel.BackColor == Color.Red ? Color.Transparent : Color.Red;
                else
                {
                    napredpanel.BackColor = Color.Transparent;
                }
                if (blinkDown)
                    nazadpanel.BackColor = nazadpanel.BackColor == Color.Red ? Color.Transparent : Color.Red;
                else
                {
                    nazadpanel.BackColor = Color.Transparent;
                }
                await Task.Delay(500);
                
            }
        }
        public mis()
        {
            InitializeComponent();
            BlinkLeft();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.UpdateStyles();
            this.moveObj1.BackColor = Color.Transparent;

            kraj = this.textBox1;
            kraj.Visible = false;
            poruka = this.button1;
            poruka.Visible = false;
            upute = this.textBox2;
            upute.Visible = true;
            desno1 = this.desno;
            desno1.Visible = true;

            lijevo1 = this.lijevo;
            lijevo1.Visible = false;

            napred3 = this.uuu;
            napred3.Visible = true;

            nazad1 = this.nazad;
            nazad1.Visible = false;

            napred2 = this.napredpanel;
            napred2.Visible = true;

            desno2 = this.desnopanel;
            desno2.Visible = true;

            lijevo2 = this.lijevopanel;
            lijevo2.Visible = true;
            blinkLeft = true;

            nazad2 = this.nazadpanel;
            nazad2.Visible = true;
            blinkDown = true;

            zeleno = this.signalizacija;
            zid1 = this.zid;
            zid1.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;

            


            
        }
      



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int x = 0;
        int y = 0;
        bool drag = false;
        private void moveObj1_MouseDown(object sender, MouseEventArgs e)
        {
            //Uzimanje poziciije kursora
            x = e.X;
            y = e.Y;
            drag = true;
        }

        private void moveObj1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                auto = this.moveObj1;

                if(auto.Location.X<220)
                {
                    blinkLeft = true;
                        
                    desno1.Visible = true;
                    //lijevo2.Visible = true;
                    
                }
                else
                {
                    desno1.Visible = false;
                    //lijevo2.Visible = false;
                    blinkLeft = false;
                }

                if (auto.Location.X > 267)
                {
                    lijevo1.Visible = true;
                   
                    //desno2.Visible = true;
                    blinkRight = true;
                }
                else
                {
                    lijevo1.Visible = false;
                   
                    //desno2.Visible = false;
                    blinkRight = false;
                }


                if (auto.Location.Y < 120)
                {
                    nazad1.Visible = true;
                    //napred2.Visible = true;
                    blinkUp = true;
                }
                else
                {
                    nazad1.Visible = false;
                    //napred2.Visible = false;
                    blinkUp = false;
                }

                if (auto.Location.Y > 175)
                {
                    napred3.Visible = true;
                    //nazad2.Visible = true;
                    blinkDown = true;
                   
                }
                else
                {
                    napred3.Visible = false;
                    //nazad2.Visible = false;
                    blinkDown = false;
                    
                }

                if (auto.Location.X > 220 && auto.Location.X < 267 && auto.Location.Y > 120 && auto.Location.Y < 175)
                {
                    kraj.Visible = true;
                    //poruka.Visible = true;
                    upute.Visible = false;
                    zeleno.BackColor = Color.FromArgb(120, 179, 72);
                    timer1.Enabled = true;
                    timer1.Start();
                    panel5.Visible = true;
                    desno.Visible = false;
                    uuu.Visible = false;
                    lijevo.Visible = false;
                    nazad.Visible = false;
                    poruka.Visible = true;

                    pictureBox2.Visible = true;
                    
                }
                else
                {
                    kraj.Visible = false;
                    poruka.Visible = false;
                    upute.Visible = true;
                    zeleno.BackColor = Color.SlateGray;
                }
                //Nova pozovija kursora
                if (auto.Location.X > 0 && auto.Location.X < 480 && auto.Location.Y > 0 && auto.Location.Y < 300)
                {
                    //upute.Visible = true;
                    zid1.Visible = false;
                    moveObj1.Top += e.Y - y;
                    moveObj1.Left += e.X - x;
                }
                else
                {
                    moveObj1.Top = 50;
                    moveObj1.Left = 50;
                    upute.Visible = false;
                    zid1.Visible = true;
                   

                }

            }
        }

        private void moveObj1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void mis_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.MediumVioletRed, 10);
            l.DrawLine(p, 250, 250, 100, 100);
            l.Dispose();
        }

        private void napred_TextChanged(object sender, EventArgs e)
        {

        }

        private void lijevopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mis_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            panel5.Visible = false;
            textBox2.Select(0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap(RoboticParkingSystem.Properties.Resources.gif);
            desno.Visible = false;
            uuu.Visible = false;
            lijevo.Visible = false;
            nazad.Visible = false;
            this.textBox4.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void nazad_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void desno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
