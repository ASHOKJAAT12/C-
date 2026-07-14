using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace display_student_data_from_database_using_combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-GUSLB1E; initial catalog=juice; integrated security=true;");
            con.Open();
            string str = "select rollno from student1;";
            SqlCommand cmd = new SqlCommand(str,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(0));
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-GUSLB1E; initial catalog=juice; integrated security=true;");
            con.Open();
            string str = "select * from student1 where rollno=" + comboBox1.Text + "";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while ( dr.Read() )
            {
                tname.Text = dr.GetString(0);
                tclass.Text = dr.GetString(1);
                trollno.Text = dr.GetValue(2).ToString();
                tsubject.Text = dr.GetString(3);
            }
            con.Close();
        }
    }
}
