using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form3 : Form
    {
        int namduong;
        string strCan;
        string strChi;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            namduong = Convert.ToInt32(txtNamduong.Text);
            if (namduong < 0)
            {
                MessageBox.Show("Nhap sai!");
            }
            else
            {
                switch (namduong % 10)
                {
                    case 0:
                        strCan = "Canh";
                        break;
                    case 1:
                        strCan = "Tân";
                        break;
                    case 2:
                        strCan = "Nhâm";
                        break;
                    case 3:
                        strCan = "Quý";
                        break;
                    case 4:
                        strCan = "Giáp";
                        break;
                    case 5:
                        strCan = "Ất";
                        break;
                    case 6:
                        strCan = "Bính";
                        break;
                    case 7:
                        strCan = "Đinh";
                        break;
                    case 8:
                        strCan = "Mậu";
                        break;
                    case 9:
                        strCan = "Kỷ";
                        break;
                }
                switch (namduong % 12)
                {
                    case 0:
                        strChi = "Thân";
                        break;
                    case 1:
                        strChi = "Dậu";
                        break;
                    case 2:
                        strChi = "Tuất";
                        break;
                    case 3:
                        strChi = "Hợi";
                        break;
                    case 4:
                        strChi = "Tí";
                        break;
                    case 5:
                        strChi = "Sửu";
                        break;
                    case 6:
                        strChi = "Dần";
                        break;
                    case 7:
                        strChi = "Mão";
                        break;
                    case 8:
                        strChi = "Thìn";
                        break;
                    case 9:
                        strChi = "Tỵ";
                        break;
                    case 10:
                        strChi = "Ngọ";
                        break;
                    case 11:
                        strChi = "Mùi";
                        break;
                }
                lblNamam.Text =  strCan + " " + strChi;
            }
        }

        private void lblNamam_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
