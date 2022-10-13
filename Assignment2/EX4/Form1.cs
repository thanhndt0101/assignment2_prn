using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using WinForm_ADO;

namespace EX4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }
        DataProvider d = new DataProvider();
        private void loadData()
        {
            try
            {
                string strSelect1 = "select WordID,Word,Meaning,EditDate,WordType.TypeName from Dictionary inner join WordType on Dictionary.ID = WordType.ID";
                DataTable dt = d.executeQuery(strSelect1);
                dataGridView1.DataSource = dt;
                //cboType.DataSource = dt;
                //cboType.DisplayMember = "TypeName";
                //cboType.ValueMember = "ID";
                string strSelect2 = "select * from WordType";
                DataTable dt2 = d.executeQuery(strSelect2);
                cboType.DataSource = dt2;
                cboType.DisplayMember = "TypeName";
                cboType.ValueMember = "ID";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWord.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtMeaning.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            cboType.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
        }
        DateTime dateTime = DateTime.Now;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "INSERT INTO [Dictionary]" +
                    "([Word],[EditDate]" +
                    ",[Meaning],[ID]) " +
                    "VALUES " +
                    "('" + txtWord.Text + "'" +
                    ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ",N'" + txtMeaning.Text + "'" +
                    ",'" + cboType.SelectedValue + "')";
                if (d.executeNonQuery(strInsert))
                {
                    MessageBox.Show("Add success");
                    loadData();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Add error " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["WordID"].Value);
                String sql = "UPDATE [Dictionary]  " +
                    "SET [Word] = '" + txtWord.Text + "'" +
                    ",[EditDate] = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' " +
                    ",[Meaning] = N'" + txtMeaning.Text + "'" +
                    ",[ID] = '" + cboType.SelectedValue + "' " +
                    "WHERE WordID='" + cellValue + "'";
                //
                if (d.executeNonQuery(sql))
                {
                    MessageBox.Show("Update Success");
                    loadData();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Update error " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["WordID"].Value);
                String sql = "DELETE FROM Dictionary WHERE WordID='" + cellValue + "'";
                if (d.executeNonQuery(sql))
                {
                    MessageBox.Show("del Success");
                    loadData();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Del error " + ex.Message);
            }
        }
    }
}