using System.Windows.Forms;

namespace EX2
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

        private void button9_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            txtSecurityCode.Text = txtSecurityCode.Text + num.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }
        DateTime dateTime = DateTime.Now;
        private void button11_Click(object sender, EventArgs e)
        {
            if (txtSecurityCode.Text.Equals("1645")|| txtSecurityCode.Text.Equals("1689"))
            {
                lbxAccessLog.Items.Add(dateTime.ToString("dd/MM/yyyy hh:mm:ss tt")+"\t"+ "Technicians");
            }
            
            if (txtSecurityCode.Text.Equals("8345"))
            {
                lbxAccessLog.Items.Add(dateTime.ToString("dd/MM/yyyy hh:mm:ss tt") + "\t" + "Custodians");
            }
            if (txtSecurityCode.Text.Equals("9998")|| txtSecurityCode.Text.Equals("1006")|| txtSecurityCode.Text.Equals("1007")|| txtSecurityCode.Text.Equals("1008"))
            {
                lbxAccessLog.Items.Add(dateTime.ToString("dd/MM/yyyy hh:mm:ss tt") + "\t" + "Scientist");
            }
            
            
            
            if (!txtSecurityCode.Text.Equals("1645") && !txtSecurityCode.Text.Equals("1689")
                && !txtSecurityCode.Text.Equals("8345")&& !txtSecurityCode.Text.Equals("9998")&&
                !txtSecurityCode.Text.Equals("1006")&& !txtSecurityCode.Text.Equals("1007")&&
                !txtSecurityCode.Text.Equals("1008"))
            {
                lbxAccessLog.Items.Add(dateTime.ToString("dd/MM/yyyy hh:mm:ss tt") + "\t" + "Restricted Access");
            }
            txtSecurityCode.Text = "";


        }

        private void lbxAccessLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}