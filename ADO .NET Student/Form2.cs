using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace ADO.NET_Student
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form2()
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

        private DataSet GetAllStudents()
        {
            string qry = "select * from student";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "stud");
            return ds;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

           
            ds=GetAllStudents();
            DataRow row = ds.Tables["stud"].NewRow();
            row["name"]=txtName.Text;
            row["course"]=txtCourse.Text;
            row["fees"]=txtFees.Text;
            ds.Tables["stud"].Rows.Add(row);
            int result = da.Update(ds.Tables["stud"]);
            if (result >= 1)
            {
                MessageBox.Show("Record inserted");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

            ds = GetAllStudents();
            DataRow row = ds.Tables["stud"].Rows.Find(txtRollNo.Text);
            if (row != null)
            {
                txtName.Text = row["name"].ToString();
                txtCourse.Text = row["course"].ToString();
                txtFees.Text = row["fees"].ToString();
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtFees.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                ds = GetAllStudents();
                DataRow row = ds.Tables["stud"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                   row["name"] = txtName.Text;
                   row["course"] = txtCourse.Text;
                   row["fees"]= txtFees.Text;

                    int result = da.Update(ds.Tables["stud"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record Updated");
                        clearFields();
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                ds = GetAllStudents();
                DataRow row = ds.Tables["stud"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    row.Delete();

                    int result = da.Update(ds.Tables["stud"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record Deleted");
                        clearFields();
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
        }

        private void btnShowALL_Click(object sender, EventArgs e)
        {
            ds = GetAllStudents();
            dataGridView1.DataSource = ds.Tables["stud"];
        }
    }
}
