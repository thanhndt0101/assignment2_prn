using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            txtTotal.Text = "$"+ GetPay().ToString()+".000";    
            
                
        }

        private void chkClean_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        private int GetPay()
        {
            int total = 0;
            if (chkClean.Checked == true)
            {
                total += 100;
            }
            if(chkWhitening.Checked == true)
            {
                total += 1200;
            }
            if(chkXRay.Checked == true)
            {
                total += 200;
            }
            total += (int)numFilling.Value*80;
            return total;
        }

        private void chkXRay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numFilling_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            chkClean.Checked = false;
            chkWhitening.Checked = false;
            chkXRay.Checked = false;
            numFilling.Value = 0;


        }
    }
}