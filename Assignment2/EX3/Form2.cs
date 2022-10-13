using EX3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.lyon;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.barca;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.full;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.ars;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.tot;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.mu;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.atle;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.real;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.inter;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
