using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class SQL_Crud_app : Form
    {
        public SQL_Crud_app()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.95.207;Initial Catalog=MyTestDB;Persist Security Info=True;User ID=sa;Password=password");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTab values (@ID,@FirstName,@LastName,@Age,@Country,@City)",con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Country", textBox5.Text);
            cmd.Parameters.AddWithValue("@City", textBox6.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.95.207;Initial Catalog=MyTestDB;Persist Security Info=True;User ID=sa;Password=password");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserTab set FirstName=@FirstName, LastName=@LastName, Age=@Age, Country=@Country, City=@City where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Country", textBox5.Text);
            cmd.Parameters.AddWithValue("@City", textBox6.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.95.207;Initial Catalog=MyTestDB;Persist Security Info=True;User ID=sa;Password=password");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserTab where ID=@ID",con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.95.207;Initial Catalog=MyTestDB;Persist Security Info=True;User ID=sa;Password=password");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTab where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
