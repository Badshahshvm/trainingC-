using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("Table");
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Employee Name", Type.GetType("System.String"));
            table.Columns.Add("Employee Code", Type.GetType("System.Int32"));
            table.Columns.Add("Date Of Birth", Type.GetType("System.DateTime"));
            table.Columns.Add("City", Type.GetType("System.String"));
            table.Columns.Add("Gender", Type.GetType("System.String"));
            table.Columns.Add("Status", Type.GetType("System.String"));

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[2].Value);
                comboBox1.SelectedItem = row.Cells[3].Value.ToString();
                string gender = row.Cells[4].Value.ToString();
                checkBox1.Checked = gender.Contains("Male");
                checkBox2.Checked = gender.Contains("Female");
                string status = row.Cells[5].Value.ToString();
                if (status == "Active")
                    radioButton1.Checked = true;
                else
                {
                    radioButton2.Checked = true;

                }
            }




        }

        // for Add Button
        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (checkBox1.Checked) gender += "Male";
            if (checkBox2.Checked) gender += "Female";
            gender = gender.Trim();
            string status = radioButton1.Checked ? "Active" : "InActive";
            table.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Value,
                comboBox1.SelectedItem.ToString(),
                gender,
                status);
            MessageBox.Show("Record Added Sucessfully");

        }

        //For New Button
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Now;
            ;
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;



        }

       



        // For Update
        private void button3_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow newdata = dataGridView1.Rows[i];

                // Update Employee Name (string)
                newdata.Cells[0].Value = textBox1.Text;

                // Update Employee Code (int), parse the value safely
                if (int.TryParse(textBox2.Text, out int empCode))
                {
                    newdata.Cells[1].Value = empCode;
                }
                else
                {
                    MessageBox.Show("Please enter a valid Employee Code (integer)");
                    return;
                }

                // Update Date of Birth
                newdata.Cells[2].Value = dateTimePicker1.Value;

                // Update City (from ComboBox)
                if (comboBox1.SelectedItem != null)
                {
                    newdata.Cells[3].Value = comboBox1.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a City");
                    return;
                }

                // Update Gender (from CheckBoxes)
                string gender = "";
                if (checkBox1.Checked) gender += "Male ";
                if (checkBox2.Checked) gender += "Female";
                newdata.Cells[4].Value = gender.Trim();

                // Update Status (from RadioButtons)
                string status = radioButton1.Checked ? "Active" : "InActive";
                newdata.Cells[5].Value = status;

                MessageBox.Show("Record Updated Successfully");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
           MessageBox.Show(index.ToString("Record Deleted Sucessfully"));
        }
    }
}
