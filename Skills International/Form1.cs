using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;// SQL Libray

namespace Skills_International
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=ZIYANIQBAL\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string password = textboxpassword.Text;
            string username = textboxusername.Text;

            try
            {
                String querry = "select * from Login where username ='"+textboxusername.Text+"' and password ='"+textboxpassword.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connection);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = textboxusername.Text;
                    password = textboxpassword.Text;

                    Registration obj = new Registration();//Creating ojec and connecting
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials, please check Username and Password and try again","Invalid login Details",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textboxusername.Clear();
                    textboxpassword.Clear();
                    textboxusername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            DialogResult Dbox = MessageBox.Show("Are you sure,Do you really want to Exit...?","Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Dbox == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textboxusername.Clear();
            textboxpassword.Clear();

            textboxusername.Focus();
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
