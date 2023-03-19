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
    public partial class Transportation : Form
    {
        string path = @"Data Source=.;Initial Catalog=HS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        bool Logged;
        int ID;
        int RID;
        public Transportation()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            Logged = false;
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
        public void display()
        {
            displayEmployee();
            displayRequests();
        }
        public void displayEmployee()
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Exec TransportLogin '" + ID + "'", con);
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
        public void displayRequests()
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Exec TransportRequests ", con);
            adpt.Fill(dt);
            dataRequests.DataSource = dt;
            con.Close();
        }
        private void buttonApproveEmployee_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Exec ResolveRequests '" + RID + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textSignIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRejectEmployee_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataPersonalData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                        adpt = new SqlDataAdapter(("Select * From Employee Where Phone_Number = '" + textPhoneNumber.Text + "' and ID != '" + ID + "'"), con);
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

        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RID = int.Parse(dataRequests.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void Emergency_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click_1(object sender, EventArgs e)
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

        private void buttonUpdate_Click_1(object sender, EventArgs e)
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
                        adpt = new SqlDataAdapter(("Select * From Employee Where Phone_Number = '" + textPhoneNumber.Text + "' and ID != '" + ID + "'"), con);
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

        private void textPhoneNumber_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");

            }
        }

        private void buttonApproveEmployee_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Exec ResolveRequests '" + RID + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }

        private void dataRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RID = int.Parse(dataRequests.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataPersonalData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textFName.Text = dataPersonalData.Rows[e.RowIndex].Cells[1].Value.ToString();
            textLName.Text = dataPersonalData.Rows[e.RowIndex].Cells[2].Value.ToString();
            textPhoneNumber.Text = dataPersonalData.Rows[e.RowIndex].Cells[4].Value.ToString();
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
