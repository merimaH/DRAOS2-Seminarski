using System.Drawing;
using System.Windows.Forms;

namespace RoboticParkingSystem
{
    partial class mis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.zid = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.signalizacija = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lijevopanel = new System.Windows.Forms.Panel();
            this.desnopanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.napredpanel = new System.Windows.Forms.Panel();
            this.uuu = new System.Windows.Forms.TextBox();
            this.nazadpanel = new System.Windows.Forms.Panel();
            this.lijevo = new System.Windows.Forms.TextBox();
            this.desno = new System.Windows.Forms.TextBox();
            this.nazad = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.moveObj1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.nazadpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveObj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(72)))));
            this.button1.Location = new System.Drawing.Point(-73, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 113);
            this.button1.TabIndex = 1;
            this.button1.Text = "Možete napustiti automobil";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(72)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(4, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(204, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Uspješno ste parkirali!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.zid);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(20, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 264);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(70, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Nazad";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zid
            // 
            this.zid.BackColor = System.Drawing.Color.Red;
            this.zid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.zid.Location = new System.Drawing.Point(5, 170);
            this.zid.Name = "zid";
            this.zid.Size = new System.Drawing.Size(204, 32);
            this.zid.TabIndex = 0;
            this.zid.Text = "Udarili ste u zid!";
            this.zid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(13, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 73);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Potrebno je pazljivo pozicionirati automobil na oznacenu lokaciju";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status parkiranja\r\nautomobila:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(240, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 530);
            this.panel4.TabIndex = 4;
            // 
            // signalizacija
            // 
            this.signalizacija.BackColor = System.Drawing.Color.LightGray;
            this.signalizacija.Location = new System.Drawing.Point(0, -1);
            this.signalizacija.Name = "signalizacija";
            this.signalizacija.Size = new System.Drawing.Size(251, 530);
            this.signalizacija.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1880;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lijevopanel
            // 
            this.lijevopanel.BackColor = System.Drawing.Color.Transparent;
            this.lijevopanel.Location = new System.Drawing.Point(164, 122);
            this.lijevopanel.Name = "lijevopanel";
            this.lijevopanel.Size = new System.Drawing.Size(53, 271);
            this.lijevopanel.TabIndex = 10;
            this.lijevopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lijevopanel_Paint);
            // 
            // desnopanel
            // 
            this.desnopanel.BackColor = System.Drawing.Color.Transparent;
            this.desnopanel.Location = new System.Drawing.Point(367, 122);
            this.desnopanel.Name = "desnopanel";
            this.desnopanel.Size = new System.Drawing.Size(53, 271);
            this.desnopanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(217, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 271);
            this.panel1.TabIndex = 3;
            // 
            // napredpanel
            // 
            this.napredpanel.BackColor = System.Drawing.Color.Transparent;
            this.napredpanel.Location = new System.Drawing.Point(218, 79);
            this.napredpanel.Name = "napredpanel";
            this.napredpanel.Size = new System.Drawing.Size(149, 45);
            this.napredpanel.TabIndex = 8;
            // 
            // uuu
            // 
            this.uuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.uuu.ForeColor = System.Drawing.SystemColors.Window;
            this.uuu.Location = new System.Drawing.Point(247, 20);
            this.uuu.Name = "uuu";
            this.uuu.Size = new System.Drawing.Size(99, 30);
            this.uuu.TabIndex = 0;
            this.uuu.Text = "Naprijed";
            this.uuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nazadpanel
            // 
            this.nazadpanel.BackColor = System.Drawing.Color.Transparent;
            this.nazadpanel.Controls.Add(this.textBox3);
            this.nazadpanel.Location = new System.Drawing.Point(218, 392);
            this.nazadpanel.Name = "nazadpanel";
            this.nazadpanel.Size = new System.Drawing.Size(150, 45);
            this.nazadpanel.TabIndex = 11;
            // 
            // lijevo
            // 
            this.lijevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.lijevo.ForeColor = System.Drawing.SystemColors.Window;
            this.lijevo.Location = new System.Drawing.Point(22, 249);
            this.lijevo.Name = "lijevo";
            this.lijevo.Size = new System.Drawing.Size(99, 30);
            this.lijevo.TabIndex = 5;
            this.lijevo.Text = "Lijevo";
            this.lijevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desno
            // 
            this.desno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.desno.ForeColor = System.Drawing.SystemColors.Window;
            this.desno.Location = new System.Drawing.Point(462, 249);
            this.desno.Name = "desno";
            this.desno.Size = new System.Drawing.Size(99, 30);
            this.desno.TabIndex = 4;
            this.desno.Text = "Desno";
            this.desno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.desno.TextChanged += new System.EventHandler(this.desno_TextChanged);
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.nazad.ForeColor = System.Drawing.SystemColors.Window;
            this.nazad.Location = new System.Drawing.Point(247, 454);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(99, 30);
            this.nazad.TabIndex = 7;
            this.nazad.Text = "Nazad";
            this.nazad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nazad.TextChanged += new System.EventHandler(this.nazad_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.moveObj1);
            this.panel3.Controls.Add(this.nazad);
            this.panel3.Controls.Add(this.desno);
            this.panel3.Controls.Add(this.lijevo);
            this.panel3.Controls.Add(this.nazadpanel);
            this.panel3.Controls.Add(this.uuu);
            this.panel3.Controls.Add(this.napredpanel);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.desnopanel);
            this.panel3.Controls.Add(this.lijevopanel);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(260, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 510);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(144, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 297);
            this.panel5.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::RoboticParkingSystem.Properties.Resources._8aUPov;
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // moveObj1
            // 
            this.moveObj1.BackColor = System.Drawing.Color.Transparent;
            this.moveObj1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveObj1.Image = global::RoboticParkingSystem.Properties.Resources.car_top_view_png_5;
            this.moveObj1.Location = new System.Drawing.Point(168, 218);
            this.moveObj1.Margin = new System.Windows.Forms.Padding(4);
            this.moveObj1.Name = "moveObj1";
            this.moveObj1.Size = new System.Drawing.Size(102, 219);
            this.moveObj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moveObj1.TabIndex = 0;
            this.moveObj1.TabStop = false;
            this.moveObj1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.moveObj1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveObj1_MouseDown);
            this.moveObj1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveObj1_MouseMove);
            this.moveObj1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveObj1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::RoboticParkingSystem.Properties.Resources.ikona;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox3.ForeColor = System.Drawing.Color.Green;
            this.textBox3.Location = new System.Drawing.Point(-74, -67);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(293, 68);
            this.textBox3.TabIndex = 13;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Možete napustiti automobil !";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(72)))));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox4.ForeColor = System.Drawing.Color.Ivory;
            this.textBox4.Location = new System.Drawing.Point(119, 426);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(343, 38);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Možete napustiti automobil !";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signalizacija);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mis";
            this.Text = "mis";
            this.Load += new System.EventHandler(this.mis_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mis_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.nazadpanel.ResumeLayout(false);
            this.nazadpanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveObj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel signalizacija;
        private System.Windows.Forms.TextBox zid;
        private Timer timer1;
        private Panel lijevopanel;
        private Panel desnopanel;
        private Panel panel1;
        private Panel napredpanel;
        private TextBox uuu;
        private Panel nazadpanel;
        private TextBox lijevo;
        private TextBox desno;
        private TextBox nazad;
        private PictureBox moveObj1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel5;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}