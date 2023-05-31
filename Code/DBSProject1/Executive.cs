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

namespace DBSProject1
{
    public partial class Executive : Form
    {
        string path = @"Data Source=.;Initial Catalog=HS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        int ID;
        bool Logged;
        string OwnerFName;
        string OwnerLName;
        string OwnerPhoneNumber;
        string OwnerGender;
        int OwnerPlotId;
        string EmployeeFName;
        string EmployeeLName;
        string EmployeePhoneNumber;
        string EmployeeGender;
        int EmployeePosition;
        int EmployeeDepartment;
        public Executive()
        {
            OwnerFName = "";
            OwnerLName = "";
            OwnerPhoneNumber = "";
            OwnerGender = "";
            InitializeComponent();
            con = new SqlConnection(path);
            Logged = false;
        }

        private void Executive_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Logged = false;
            if (textSignIn.Text == "")
            {
                MessageBox.Show("Please enter a valid ID!");
            }
            else
            {
                ID = int.Parse(textSignIn.Text);
                display();
            }
        }
        public void displayEmployee()
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Exec ExecLogin '" + ID + "' ", con);
            adpt.Fill(dt);
            dataPersonalData.DataSource = dt;
            if (dt.Rows.Count == 1)
            {
                Logged = true;
            }
            else
            {
                MessageBox.Show("Invalid Id!");
                Logged = false;
            }

            con.Close();
        }
        public void displayEmployees()
        {
            if (Logged == true)
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Exec ExecutiveEmployeeData ", con);
                adpt.Fill(dt);
                dataEmployeeData.DataSource = dt;
                con.Close();
            }
        }
        public void displayOwnerApplications()
        {
            if (Logged == true)
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Exec OwnerApplications ", con);
                adpt.Fill(dt);
                dataOwnerApplications.DataSource = dt;
                con.Close();
            }
        }
        public void displayEmployeeApplications()
        {
            if (Logged == true)
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Exec ExecutiveEmployeeApplications ", con);
                adpt.Fill(dt);
                dataEmployeeApplications.DataSource = dt;
                con.Close();
            }
        }

        private void textSignIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataPersonalData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataPersonalData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textFName.Text = dataPersonalData.Rows[e.RowIndex].Cells[1].Value.ToString();
            textLName.Text = dataPersonalData.Rows[e.RowIndex].Cells[2].Value.ToString();
            textPhoneNumber.Text = dataPersonalData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                try
                {
                    if (textFName.Text != "")
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec UpdateEmployeeFName '" + ID + "','" + textFName.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (textPhoneNumber.Text != "")
                    {
                        dt = new DataTable();
                        con.Open();
                        adpt = new SqlDataAdapter(("Select * From Employee Where Phone_Number = '" + textPhoneNumber.Text + "' and ID != '"+ID+"'"), con);
                        adpt.Fill(dt);
                        con.Close();
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("PhoneNumber already registered!");
                        }
                        else
                        {
                            con.Open();
                            cmd = new SqlCommand("Exec UpdateEmployeePhoneNumber '" + ID + "','" + textPhoneNumber.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                    }
                    if (textLName.Text != "")
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec UpdateEmployeeLName '" + ID + "','" + textLName.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Your information has been updated!");
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
            else
            {
                MessageBox.Show("Please Log In First!");
            }
            display();
        }
        private void display()
        {
            displayEmployee();
            displayEmployees();
            displayOwnerApplications();
            displayEmployeeApplications();
        }
        private void dataEmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataEmployeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textEmployeeFName.Text = dataEmployeeData.Rows[e.RowIndex].Cells[1].Value.ToString();
            textEmployeeLName.Text = dataEmployeeData.Rows[e.RowIndex].Cells[2].Value.ToString();
            textEmployeePhoneNumber.Text = dataEmployeeData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (textEmployeeFName.Text != "" || textEmployeeLName.Text != "" || textEmployeePhoneNumber.Text != "")
                {

                    con.Open();
                    cmd = new SqlCommand("Exec FireEmployee  '" + textEmployeeFName.Text + "', '" + textEmployeeLName.Text + "', '" + textEmployeePhoneNumber.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                }
                else
                {
                    MessageBox.Show("Enter a valid resident/tenant from the table!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void buttonUpdateSalary_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (textEmployeeFName.Text != "" || textEmployeeLName.Text != "" || textEmployeePhoneNumber.Text != "")
                {
                    if (textEmployeeSalary.Text == "")
                    {
                        MessageBox.Show("Enter a valid salary.");
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec UpdateEmployeeSalary '" + textEmployeeFName.Text + "', '" + textEmployeeLName.Text + "', '" + textEmployeePhoneNumber.Text + "' ,'" + int.Parse(textEmployeeSalary.Text) + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        display();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid resident/tenant and rent from the table!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void buttonRejectOwner_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (OwnerFName != "" || OwnerLName != "" || OwnerPhoneNumber != "" || OwnerGender != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec RejectOwnerApplication '" + OwnerPhoneNumber + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    OwnerFName = "";
                    OwnerLName = "";
                    OwnerPhoneNumber = "";
                    OwnerGender = "";
                }
                else
                {
                    MessageBox.Show("Select a valid application!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void dataOwnerApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OwnerFName = dataOwnerApplications.Rows[e.RowIndex].Cells[1].Value.ToString();
            OwnerLName = dataOwnerApplications.Rows[e.RowIndex].Cells[2].Value.ToString();
            OwnerPhoneNumber = dataOwnerApplications.Rows[e.RowIndex].Cells[4].Value.ToString();
            OwnerGender = dataOwnerApplications.Rows[e.RowIndex].Cells[3].Value.ToString();
            OwnerPlotId = int.Parse(dataOwnerApplications.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void buttonOwner_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (OwnerFName != "" || OwnerLName != "" || OwnerPhoneNumber != "" || OwnerGender != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec ApproveOwnerApplication '" + OwnerFName + "','" + OwnerLName + "','" + OwnerGender + "','" + OwnerPhoneNumber + "', '" + OwnerPlotId + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    OwnerFName = "";
                    OwnerLName = "";
                    OwnerPhoneNumber = "";
                    OwnerGender = "";
                }
                else
                {
                    MessageBox.Show("Select a valid application!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void buttonApproveEmployee_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (EmployeeFName != "" || EmployeeLName != "" || EmployeePhoneNumber != "" || EmployeeGender != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec ApproveEmployeeApplication '" + EmployeeFName + "','" + EmployeeLName + "','" + EmployeeGender + "','" + EmployeePhoneNumber + "', '" + EmployeeDepartment + "', '" + EmployeePosition + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    EmployeeFName = "";
                    EmployeeLName = "";
                    EmployeePhoneNumber = "";
                    EmployeeGender = "";
                }
                else
                {
                    MessageBox.Show("Select a valid application!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void dataEmployeeApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeFName = dataEmployeeApplications.Rows[e.RowIndex].Cells[0].Value.ToString();
            EmployeeLName = dataEmployeeApplications.Rows[e.RowIndex].Cells[1].Value.ToString();
            EmployeeGender = dataEmployeeApplications.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmployeePhoneNumber = dataEmployeeApplications.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmployeeDepartment = int.Parse(dataEmployeeApplications.Rows[e.RowIndex].Cells[4].Value.ToString());
            EmployeePosition = int.Parse(dataEmployeeApplications.Rows[e.RowIndex].Cells[6].Value.ToString());
        }

        private void dataEmployeeApplications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRejectEmployee_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (EmployeeFName != "" || EmployeeLName != "" || EmployeeGender != "" || EmployeePhoneNumber != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec RejectEmployeeApplication '" + EmployeeFName + "','" + EmployeeLName + "','" + EmployeeGender + "','" + EmployeePhoneNumber + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    EmployeeFName = "";
                    EmployeeLName = "";
                    EmployeeGender = "";
                    EmployeePhoneNumber = "";
                }
                else
                {
                    MessageBox.Show("Select a valid application!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
            }
        }

        private void textSignIn_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textSignIn.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");

            }
        }
    }
}
