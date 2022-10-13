using EX_4.Models;
using System.Data;

namespace EX_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        MyDB2Context context = new MyDB2Context();
        void LoadData()
        {
            var data = context.Dictionaries.
                Select(item => new
                {
                   WordID = item.WordId,
                   Word = item.Word,
                   Meaning = item.Meaning,
                   EditDate = item.EditDate,
                   TypeName = item.IdNavigation.TypeName

                }).ToList();
            dataGridView1.DataSource = data;
            cboType.DataSource = context.WordTypes.ToList();
            cboType.DisplayMember = "Typename";
            cboType.ValueMember = "ID";

            txtWord.DataBindings.Clear();
            txtWord.DataBindings.Add("Text", data, "Word");
            txtMeaning.DataBindings.Clear();
            txtMeaning.DataBindings.Add("Text", data, "Meaning");
            cboType.DataBindings.Clear();
            cboType.DataBindings.Add("Text", data, "TypeName");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                //tao doi tuong se add
                Dictionary d = new Dictionary
                {
                    Word = txtWord.Text,
                    Meaning = txtMeaning.Text,
                    EditDate = date,
                    Id = (int)cboType.SelectedValue

                };

                //add vao db 
                context.Dictionaries.Add(d);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add success");
                    LoadData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Add fail" + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["WordID"].Value);

                //tao doi tuong se update
                Dictionary d = context.Dictionaries.FirstOrDefault(
                    item => item.WordId == Int32.Parse(cellValue));
                if (d != null)
                {
                    DateTime date = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                    d.Word = txtWord.Text;
                    d.Meaning = txtMeaning.Text;
                    d.EditDate = date;
                    d.Id = (int)cboType.SelectedValue;
                    //update vao db 

                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update success");
                        LoadData();
                    }

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

                //tao doi tuong se del
                Dictionary d = context.Dictionaries.FirstOrDefault(
                    item => item.WordId == Int32.Parse(cellValue));
                if (d != null)
                {
                    //del vao db 
                    context.Dictionaries.Remove(d);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Del success");
                        LoadData();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Del error " + ex.Message);
            }
        }
    }
}