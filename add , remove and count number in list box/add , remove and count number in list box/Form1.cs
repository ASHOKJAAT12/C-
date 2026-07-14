using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add___remove_and_count_number_in_list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( listBox1.SelectedIndex == 0 )
            {
                MessageBox.Show("list empty");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                MessageBox.Show("Last item removed.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Items.Count.ToString();
        }
    }
}
