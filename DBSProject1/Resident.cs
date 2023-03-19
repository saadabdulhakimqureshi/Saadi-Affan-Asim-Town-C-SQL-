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
    public partial class Resident : Form
    {
        string path = @"Data Source=.;Initial Catalog=HS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public Resident()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            displayPlots();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Resident_Load(object sender, EventArgs e)
        {

        }


 

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)//When Gender is not specified.
            {
                MessageBox.Show("Please specify Gender!");
            }
            else if (radioButtonResident.Checked == false && radioButtonTenant.Checked == false)
            {
                MessageBox.Show("Please specify whether you are applying to be a tenant or resident!");
            }
            else if(textFName.Text == "")
            {
                MessageBox.Show("Specify Your Name!");
            }
            else if (textLName.Text == "")
            {
                MessageBox.Show("Specify Your Name!");
            }
            else if ( textPhoneNumber.Text == "")
            {
                MessageBox.Show("Specify Your Phone Number!");
            }
            else
            {
                try
                {
                    string TitleOfCourtesy;
                    int tenant;
                    if (radioButtonFemale.Checked == true)
                        TitleOfCourtesy = "Ms";
                    else
                        TitleOfCourtesy = "Mr";
                    if (radioButtonResident.Checked == true)
                        tenant = 0;
                    else
                        tenant = 1;
                 
                    dt = new DataTable();
                    con.Open();
                    adpt = new SqlDataAdapter(("Select * From Resident Where PhoneNumber = '"+ textPhoneNumber.Text + "'"), con);
                    adpt.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("PhoneNumber already registered!");
                    }
                    else
                    {

                        con.Open();
                        cmd = new SqlCommand("Exec NewResidentApplication '" + textFName.Text + "', '" + textLName.Text + "','" + TitleOfCourtesy + "', '" + textPhoneNumber.Text + "','" + int.Parse(textNumber.Text) + "', '" + int.Parse(textBlock.Text) + "' , '" + tenant + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Welcome to Saadi Affan Town " + TitleOfCourtesy + ". " + textFName.Text + " " + textLName.Text + "  \nYour application has been saved and will be processed shortly.\nNote: If you have already sent an application with this information this application will be discarded.");
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void displayPlots()//Method to display data.
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter(("Select * From ResidentialPlotAvailable"), con);
            adpt.Fill(dt);
            dataPlot.DataSource = dt;
            con.Close();
        }
        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textPhoneNumber.Text = textPhoneNumber.Text.Remove(textPhoneNumber.Text.Length - 1);
            }
        }

        private void dataPlot_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataPlot_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataPlot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textNumber.Text = dataPlot.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBlock.Text = dataPlot.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}