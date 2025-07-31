

using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        ArrayList l1 = new ArrayList();
        DataTable table = new DataTable("Table");
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Employee Name", typeof(string));
            table.Columns.Add("Employee Code", typeof(int));
            table.Columns.Add("Date Of Birth", typeof(DateTime));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Status", typeof(string));

            dataTable.DataSource = table;

            // Default city selection
            if (comboBoxCity.Items.Count > 0)
                comboBoxCity.SelectedIndex = 0;

            // Ensure only one checkbox can be selected
            checkBoxMale.CheckedChanged += GenderCheckBox_CheckedChanged;
            checkBoxFemale.CheckedChanged += GenderCheckBox_CheckedChanged;
        }

        private void GenderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBoxMale && checkBoxMale.Checked)
                checkBoxFemale.Checked = false;
            else if (sender == checkBoxFemale && checkBoxFemale.Checked)
                checkBoxMale.Checked = false;
        }

        private bool IsEmployeeNameUnique(string name)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row["Employee Name"].ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
                    return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

              }

              private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
              {

              }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            textBoxName.Text = "";
            textBoxCode.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBoxCity.SelectedIndex = 0;
            radioButtonActive.Checked = false;
            radioButtonInActive.Checked = false;
            checkBoxMale.Checked = false;
            checkBoxFemale.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
                {
                    MessageBox.Show("Employee Name must be a valid string.");
                    return;
                }

                if (!IsEmployeeNameUnique(name))
                {
                    MessageBox.Show("Employee Name must be unique.");
                    return;
                }

                if (!int.TryParse(textBoxCode.Text, out int code))
                {
                    MessageBox.Show("Employee Code must be a valid integer.");
                    return;
                }

                if (comboBoxCity.SelectedItem == null)
                {
                    MessageBox.Show("Please select a City.");
                    return;
                }

                string gender = checkBoxMale.Checked ? "Male" : checkBoxFemale.Checked ? "Female" : "";
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Please select a Gender.");
                    return;
                }

                string status = radioButtonActive.Checked ? "Active" : radioButtonInActive.Checked ? "InActive" : "";
                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Please select Status.");
                    return;
                }

                table.Rows.Add(name, code, dateTimePicker1.Value,
                    comboBoxCity.SelectedItem.ToString(), gender, status);

                ArrayList row = new ArrayList { name, code, dateTimePicker1.Value, comboBoxCity.SelectedItem.ToString(), gender, status };
                l1.Add(row);

                ClearForm();
                MessageBox.Show("Record Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataTable.CurrentCell == null)
                {
                    MessageBox.Show("Please select a record to update.");
                    return;
                }

                int i = dataTable.CurrentCell.RowIndex;

                string name = textBoxName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
                {
                    MessageBox.Show("Employee Name must be a valid string.");
                    return;
                }

                if (!int.TryParse(textBoxCode.Text, out int code))
                {
                    MessageBox.Show("Employee Code must be a valid integer.");
                    return;
                }

                if (comboBoxCity.SelectedItem == null)
                {
                    MessageBox.Show("Please select a City.");
                    return;
                }

                string gender = checkBoxMale.Checked ? "Male" : checkBoxFemale.Checked ? "Female" : "";
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Please select a Gender.");
                    return;
                }

                string status = radioButtonActive.Checked ? "Active" : radioButtonInActive.Checked ? "InActive" : "";
                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Please select Status.");
                    return;
                }

                DataGridViewRow newdata = dataTable.Rows[i];

                newdata.Cells[0].Value = name;
                newdata.Cells[1].Value = code;
                newdata.Cells[2].Value = dateTimePicker1.Value;
                newdata.Cells[3].Value = comboBoxCity.SelectedItem.ToString();
                newdata.Cells[4].Value = gender;
                newdata.Cells[5].Value = status;

                ArrayList updatedRow = (ArrayList)l1[i];
                updatedRow[0] = name;
                updatedRow[1] = code;
                updatedRow[2] = dateTimePicker1.Value;
                updatedRow[3] = comboBoxCity.SelectedItem.ToString();
                updatedRow[4] = gender;
                updatedRow[5] = status;

                ClearForm();
                MessageBox.Show("Record Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message);
            }
        }

        //  Delete Button 
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataTable.CurrentCell == null)
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                int i = dataTable.CurrentCell.RowIndex;
                table.Rows.RemoveAt(i);
                l1.RemoveAt(i);

                ClearForm();
                MessageBox.Show("Record Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Failed: " + ex.Message);
            }
        }
        //Add data in a table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                if (index >= 0)
                {
                    DataGridViewRow row = dataTable.Rows[index];
                    textBoxName.Text = row.Cells[0].Value.ToString();
                    textBoxCode.Text = row.Cells[1].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[2].Value);
                    comboBoxCity.SelectedItem = row.Cells[3].Value.ToString();
                    string gender = row.Cells[4].Value.ToString();
                    checkBoxMale.Checked = gender == "Male";
                    checkBoxFemale.Checked = gender == "Female";
                    string status = row.Cells[5].Value.ToString();
                    radioButtonActive.Checked = status == "Active";
                    radioButtonInActive.Checked = status == "InActive";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }


        //Show Button

        private void button6_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < l1.Count; i++)
            {
                ArrayList row = (ArrayList)l1[i];
                result += $"Row {i + 1}: {string.Join(", ", row.Cast<object>())}\n";
            }
            MessageBox.Show(result);
        }
    }
}
