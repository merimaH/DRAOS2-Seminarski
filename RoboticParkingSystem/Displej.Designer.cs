namespace RoboticParkingSystem
{
    partial class Displej
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.napred = new System.Windows.Forms.Button();
            this.desno = new System.Windows.Forms.Button();
            this.lijevo = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.napustiautomobil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(225, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 400);
            this.panel1.TabIndex = 0;
            // 
            // napred
            // 
            this.napred.BackColor = System.Drawing.Color.Lime;
            this.napred.Location = new System.Drawing.Point(352, 12);
            this.napred.Name = "napred";
            this.napred.Size = new System.Drawing.Size(94, 41);
            this.napred.TabIndex = 1;
            this.napred.Text = "Napred";
            this.napred.UseVisualStyleBackColor = false;
            this.napred.Click += new System.EventHandler(this.button1_Click);
            // 
            // desno
            // 
            this.desno.BackColor = System.Drawing.Color.Red;
            this.desno.Location = new System.Drawing.Point(635, 252);
            this.desno.Name = "desno";
            this.desno.Size = new System.Drawing.Size(95, 39);
            this.desno.TabIndex = 2;
            this.desno.Text = "Desno";
            this.desno.UseVisualStyleBackColor = false;
            // 
            // lijevo
            // 
            this.lijevo.BackColor = System.Drawing.Color.Lime;
            this.lijevo.Location = new System.Drawing.Point(81, 252);
            this.lijevo.Name = "lijevo";
            this.lijevo.Size = new System.Drawing.Size(83, 39);
            this.lijevo.TabIndex = 3;
            this.lijevo.Text = "Lijevo";
            this.lijevo.UseVisualStyleBackColor = false;
            this.lijevo.Click += new System.EventHandler(this.lijevo_Click);
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.Red;
            this.nazad.Location = new System.Drawing.Point(371, 465);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(91, 42);
            this.nazad.TabIndex = 4;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(52, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 322);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RoboticParkingSystem.Properties.Resources.auto11;
            this.pictureBox1.Location = new System.Drawing.Point(138, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(56, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 220);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(26, 482);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Uspjesno ste parkirali!!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // napustiautomobil
            // 
            this.napustiautomobil.BackColor = System.Drawing.Color.Cyan;
            this.napustiautomobil.Location = new System.Drawing.Point(605, 465);
            this.napustiautomobil.Name = "napustiautomobil";
            this.napustiautomobil.Size = new System.Drawing.Size(162, 82);
            this.napustiautomobil.TabIndex = 6;
            this.napustiautomobil.Text = "Napustite automobil!";
            this.napustiautomobil.UseVisualStyleBackColor = false;
            // 
            // Displej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.napustiautomobil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.lijevo);
            this.Controls.Add(this.desno);
            this.Controls.Add(this.napred);
            this.Controls.Add(this.panel1);
            this.Name = "Displej";
            this.Text = "Displej";
            this.Load += new System.EventHandler(this.Displej_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button napred;
        private System.Windows.Forms.Button desno;
        private System.Windows.Forms.Button lijevo;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button napustiautomobil;
    }
}