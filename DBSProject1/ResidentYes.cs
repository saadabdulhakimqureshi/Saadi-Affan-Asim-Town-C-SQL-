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
    public partial class ResidentYes : Form
    {
        string path = @"Data Source=.;Initial Catalog=HS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        int ID;
        bool Logged;
        public ResidentYes()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            Logged = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Logged == true) { 
                MessageBox.Show("A fire brigade is on the way!");
                con.Open();
                cmd = new SqlCommand("Exec ResidentRequest '" + ID + "', 'Fire'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Logged == true) {
                MessageBox.Show("A patrol car will arive at your house shortly!");
                con.Open();
                cmd = new SqlCommand("Exec ResidentRequest '"+ID+"', 'Police'", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else MessageBox.Show("Please Log In First!");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Logged == true) { 
                MessageBox.Show("An ambulance is on the way!");
                con.Open();
                cmd = new SqlCommand("Exec ResidentRequest '" + ID + "', 'Medical'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textSignIn.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textSignIn.Text = textSignIn.Text.Remove(textSignIn.Text.Length - 1);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (textSignIn.Text == "")
            {
                MessageBox.Show("Please enter a valid ID!");
            }
            else
            {
                ID = int.Parse(textSignIn.Text);
                displayResident();  
            }
        }

        private void dataResident_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displayResident()//Method to display data.
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Exec ResidentLogin '"+ ID + "'", con);

            adpt.Fill(dt);
            dataResident.DataSource = dt;
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


        private void dataResident_Click(object sender, EventArgs e)
        {

        }

        private void dataResident_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textFName.Text = dataResident.Rows[e.RowIndex].Cells[1].Value.ToString();
            textLName.Text = dataResident.Rows[e.RowIndex].Cells[2].Value.ToString();
            textPhoneNumber.Text = dataResident.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                try
                {
                    if (textFName.Text != "")
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec UpdateFName '"+ ID + "','"+textFName.Text+"'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (textLName.Text != "")
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec UpdateLName '" + ID + "','" + textLName.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (textPhoneNumber.Text != "")
                    {
                        dt = new DataTable();
                        con.Open();
                        adpt = new SqlDataAdapter(("Select * From Resident Where PhoneNumber = '" + textPhoneNumber.Text + "' and ID != '"+ID+"'"), con);
                        adpt.Fill(dt);
                        con.Close();
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("PhoneNumber already registered!");
                        }
                        else
                        {
                            con.Open();
                            cmd = new SqlCommand("Exec UpdatePhoneNumber '" + ID + "','" + textPhoneNumber.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Your information has been updated!");
                            displayResident();
                        }
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
            else
            {
                MessageBox.Show("Please Log In First!");
            }

         }
        

        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textPhoneNumber.Text = textPhoneNumber.Text.Remove(textPhoneNumber.Text.Length - 1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                MessageBox.Show("Your transportation request has been recieved!");
                con.Open();
                cmd = new SqlCommand("Exec ResidentRequest '" + ID + "', 'Transportation'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void ResidentYes_Load(object sender, EventArgs e)
        {

        }
    }
}
