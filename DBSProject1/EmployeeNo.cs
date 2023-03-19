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
    public partial class EmployeeNo : Form
    {
        string path = @"Data Source=.;Initial Catalog=HS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public EmployeeNo()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            displayDepartment();

        }

        private void EmployeeNo_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)//When Gender is not specified.
            {
                MessageBox.Show("Please specify Gender!");
            }
            else
            {
                try
                {
                    string TitleOfCourtesy;
                    if (radioButtonFemale.Checked == true)
                        TitleOfCourtesy = "Ms";
                    else
                        TitleOfCourtesy = "Mr";
                    dt = new DataTable();
                    con.Open();
                    adpt = new SqlDataAdapter(("Select * From Employee Where Phone_Number = '" + textPhoneNumber.Text + "'"), con);
                    adpt.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("PhoneNumber already registered!");
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec NewEmployeeApplication '" + textFName.Text + "', '" + textLName.Text + "','" + TitleOfCourtesy + "', '" + textPhoneNumber.Text + "', '" + textDepartment.Text + "', '" + textPosition.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Welcome to Saadi Affan Town " + TitleOfCourtesy + ". " + textFName.Text + " " + textLName.Text + "  \nYour application has been saved and will be processed shortly.\nNote: If you have already sent an application with this information this application will be discarded.");
                        clear();
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
        }
        public void clear()//Method to clear all text boxes.
        {
            textFName.Text = "";
            textLName.Text = "";
            textPhoneNumber.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
        }


        public void displayDepartment()//Method to display data.
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter(("Select * From DepartmentPositions"), con);
            adpt.Fill(dt);
            dataDepartment.DataSource = dt;
            con.Close();
        }
        //public void displayPosition()//Method to display data.
        //{
        //    dt2 = new DataTable();
        //    con.Open();
        //    adpt2 = new SqlDataAdapter(("Select Description as Position From Position"), con);
        //    adpt2.Fill(dt);
        //    dataPosition.DataSource = dt2;
        //    con.Close();
        //}
        private void comboPositions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textPhoneNumber.Text = textPhoneNumber.Text.Remove(textPhoneNumber.Text.Length - 1);
            }
        }

        private void dataDepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textDepartment.Text = dataDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
            textPosition.Text = dataDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
