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
    public partial class Owner : Form
    {
        string path = @"Data Source=.;Initial Catalog=HS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public Owner()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            displayPlots();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataPlot_CellDoubleClick(object sender, MouseEventArgs e)
        {

        }
        public void displayPlots()//Method to display data.
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter(("Select * From PlotAvailable"), con);
            adpt.Fill(dt);
            dataPlot.DataSource = dt;
            con.Close();
        }

        private void dataPlot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataPlot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textNumber.Text = dataPlot.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBlock.Text = dataPlot.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)//When Gender is not specified.
            {
                MessageBox.Show("Please specify Gender!");
            }
            else if (textFName.Text == "")
            {
                MessageBox.Show("Specify Your Name!");
            }
            else if (textLName.Text == "")
            {
                MessageBox.Show("Specify Your Name!");
            }
            else if (textPhoneNumber.Text == "")
            {
                MessageBox.Show("Specify Your Phone Number!");
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
                    adpt = new SqlDataAdapter(("Select * From PlotOwner Where Phone_Number = '" + textPhoneNumber.Text + "'"), con);
                    adpt.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("PhoneNumber already registered!");
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec NewOwnerApplication '" + textFName.Text + "', '" + textLName.Text + "','" + TitleOfCourtesy + "', '" + textPhoneNumber.Text + "','" + int.Parse(textNumber.Text) + "', '" + int.Parse(textBlock.Text) + "' ", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Welcome to Saadi Affan Town " + TitleOfCourtesy + ". " + textFName.Text + " " + textLName.Text + "  \nYour application has been saved and will be processed shortly.\nNote: If you have already sent an application with this information already this application will be discarded.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect format for entry.");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }
    }
}
