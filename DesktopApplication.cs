//Implement Crud Operation using windows form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("Table");
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", Type.GetType("System.Int32"));
            table.Columns.Add("Username", Type.GetType("System.String"));
            table.Columns.Add("Password", Type.GetType("System.String"));
            dataGridView1.DataSource = table;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row= dataGridView1.Rows[index];
            textBox3.Text=row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox1.Text = row.Cells[2].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox3.Text, textBox1.Text, textBox2.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox1.Text = String.Empty;

        }

        private void edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata= dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox3.Text;
            newdata.Cells[1].Value = textBox1.Text;
            newdata.Cells[2].Value = textBox2.Text;
        }

        private void deltebutton_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
