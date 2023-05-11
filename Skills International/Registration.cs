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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ZIYANIQBAL\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");//SQL connection String
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        private void Registration_Load(object sender, EventArgs e)
        {
            try
            {
                ComboBox.Items.Clear();
                con.Open();//Sql connction Open
                string query_search = "Select regNo from Registration order by regNo"; // Primary key
                SqlDa = new SqlDataAdapter(query_search, con);
                DataTable dt = new DataTable();
                SqlDa.Fill(dt);
                foreach (DataRow row1 in dt.Rows)
                {
                    ComboBox.Items.Add(row1["regNo"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            con.Close();//Connection close
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string si = ComboBox.SelectedItem.ToString();
                string fname = TextboxFName.Text;
                string lname = TextboxLName.Text;
                string date = dateTimePicker1.Text;
                string gender;
                if (radioBtnMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = textboxaddress.Text;
                string email = textboxemail.Text;
                int mobileNo = int.Parse(textboxmobile.Text);
                int homeNo = int.Parse(textboxmobile.Text);
                string pName = textboxpname.Text;
                string Nic = textboxNIC.Text;
                int contactNo = int.Parse(textboxCnumber.Text);
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure,Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string query_delete = "delete from Registration where regNo='" + si + "'";//Delete data from SQL
                        SqlCommand cmd = new SqlCommand(query_delete, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Refresh();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error While Saving" + ex);
                }
                finally
                {
                    con.Close();
                }
                TextboxLName.Clear();//Clear data
                TextboxFName.Clear();
                textboxemail.Clear();
                textboxaddress.Clear();
                textboxhome.Clear();
                textboxmobile.Clear();
                textboxNIC.Clear();
                textboxpname.Clear();
                radioBtnMale.Checked = false;
                textboxCnumber.Clear();
                this.dateTimePicker1.Value = DateTime.Now;
                TextboxFName.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure,Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string fname = TextboxFName.Text;
            string lname = TextboxLName.Text;
            string date = dateTimePicker1.Text;
            string gender;
            if(radioBtnMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string address = textboxaddress.Text;
            string email = textboxemail.Text;
            int mobileNo = int.Parse(textboxmobile.Text);
            int homeNo = int.Parse(textboxmobile.Text);
            string pName = textboxpname.Text;
            string Nic = textboxNIC.Text;
            int contactNo = int.Parse(textboxCnumber.Text);
            try
            {
                string query_insert = "insert into Registration values('"+fname+"','"+lname+"','"+date+ "','"+gender+"','"+address+"','"+email+"',"+mobileNo+","+homeNo+",'"+pName+"','"+Nic+"',"+contactNo+")";
                SqlCommand cmd = new SqlCommand(query_insert,con);//Registration
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Succesfully","Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dateTimePicker1.Value = DateTime.Now;
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
                con.Close();
            }
            TextboxLName.Clear();
            TextboxFName.Clear();
            textboxemail.Clear();
            textboxaddress.Clear();
            textboxhome.Clear();
            textboxmobile.Clear();
            textboxNIC.Clear();
            textboxpname.Clear();
            radioBtnMale.Checked = false;
            textboxCnumber.Clear();
            TextboxFName.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string si = ComboBox.SelectedItem.ToString();
                con.Open();
                string query_search = "select * from  Registration where  regNo = "+si+" ";
                SqlCommand cmd = new SqlCommand(query_search,con);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    TextboxFName.Text = R.GetValue(1).ToString();//Show data after selecting combo box number
                    TextboxLName.Text = R.GetValue(2).ToString();
                    dateTimePicker1.Text = R.GetValue(3).ToString();
                    string sex = R.GetValue(4).ToString();
                    if (sex == "Male")
                    {
                        radioBtnMale.Checked = true;
                    }
                    else
                    {
                        radioBtnFemale.Checked = true;
                    }
                    textboxaddress.Text = R.GetValue(5).ToString();
                    textboxemail.Text = R.GetValue(6).ToString();
                    textboxmobile.Text = R.GetValue(7).ToString();
                    textboxhome.Text = R.GetValue(8).ToString();
                    textboxpname.Text = R.GetValue(9).ToString();
                    textboxNIC.Text = R.GetValue(10).ToString();
                    textboxCnumber.Text = R.GetValue(11).ToString();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            {
                string si = ComboBox.SelectedItem.ToString();
                string fname = TextboxFName.Text;
                string lname = TextboxLName.Text;
                string date = dateTimePicker1.Text;
                string gender;
                if (radioBtnMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = textboxaddress.Text;
                string email = textboxemail.Text;
                int mobileNo = int.Parse(textboxmobile.Text);
                int homeNo = int.Parse(textboxmobile.Text);
                string pName = textboxpname.Text;
                string Nic = textboxNIC.Text;
                int contactNo = int.Parse(textboxCnumber.Text);
                try
                {
                    string query_update = "Update Registration set firstName='" + fname + "',lastName='" + lname + "',dateOfBirth='" + date + "',gender='" + gender + "',address='" + address + "',email='" + email + "',mobilePhone=" + mobileNo + ",homePhone=" + homeNo + ",parentName='" + pName + "',nic='" + Nic + "',contactNo=" + contactNo + " WHERE regNo='"+si+"'";
                    SqlCommand cmd = new SqlCommand(query_update,con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Succesfully","Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error While Saving" + ex);
                }
                finally
                {
                    con.Close();
                }
                
                textboxmobile.Clear();
                textboxhome.Clear();
                textboxpname.Clear();
                TextboxFName.Clear();
                TextboxLName.Clear();
                textboxaddress.Clear();
                textboxemail.Clear();
                textboxNIC.Clear();
                textboxCnumber.Clear();
                radioBtnMale.Checked = false;
                this.dateTimePicker1.Value = DateTime.Now;
                TextboxFName.Focus();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textboxmobile.Clear();
            textboxhome.Clear();
            textboxpname.Clear();
            textboxNIC.Clear();
            textboxCnumber.Clear();
            radioBtnMale.Checked = false;
            TextboxFName.Focus();
            ComboBox.ResetText();
            TextboxFName.Clear();
            TextboxLName.Clear();
            this.dateTimePicker1.Value = DateTime.Now;
            textboxaddress.Clear();
            textboxemail.Clear();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login obj = new Login();//Creating oject and connecting
            obj.Show();
        }

        private void txtBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void txtBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
