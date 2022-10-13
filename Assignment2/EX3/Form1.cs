namespace EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if(progressBar1.Value >= 100){
                timer1.Enabled = false;
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
                
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}