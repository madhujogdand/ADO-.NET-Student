using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADO.NET_Student
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rd;
        public Form1()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnectionstudent"].ConnectionString;
            con = new SqlConnection(constr);

        }

        private void clearFields()
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtFees.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into student values(@name,@course,@fees)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@course", txtCourse.Text);
                cmd.Parameters.AddWithValue("@fees", txtFees.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record Inserted");
                    clearFields();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtFees.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rollno", txtRollNo.Text);
                con.Open();
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        txtName.Text = rd["Name"].ToString();
                        txtCourse.Text = rd["Course"].ToString();
                        txtFees.Text = rd["Fees"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            { 
              con.Close() ;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update student set name=@name, course=@course, fees=@fees where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@course", txtCourse.Text);
                cmd.Parameters.AddWithValue("@fees", txtFees.Text);
                cmd.Parameters.AddWithValue("@rollno", txtRollNo.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record Updated");
                    clearFields();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from student where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("rollno", txtRollNo.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                    clearFields();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnShowALL_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student";
                cmd = new SqlCommand(qry, con);
                con.Open();
               rd= cmd.ExecuteReader();
                DataTable table=new DataTable();
                table.Load(rd);
                dataGridView1.DataSource = table;   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {
                con.Close();
            }
        }
    }
}
