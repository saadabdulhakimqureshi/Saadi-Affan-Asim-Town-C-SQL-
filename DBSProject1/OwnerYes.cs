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
    public partial class OwnerYes : Form
    {
        string path = @"Data Source=.;Initial Catalog=HS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        int ID;
        bool Logged;
        string FName;
        string LName;
        string PhoneNumber;
        int plot_id;
        int tenant;
        string Gender;

        public OwnerYes()  
        {
            FName = "";
            LName = "";
            PhoneNumber = "";
            Gender = "";
            InitializeComponent();
            con = new SqlConnection(path);
            Logged = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OwnerYes_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (textResidentFName.Text != "" || textResidentLName.Text != "" || textResidentPhoneNumber.Text != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec EvictResident '" + ID + "', '" + textResidentFName.Text + "', '" + textResidentLName.Text + "', '"+textResidentPhoneNumber.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayOwnedProperties();
                    displayAvailableProperties();
                    displayResidents();
                    displayResidentApplications();
                }
                else
                {
                    MessageBox.Show("Enter a valid resident/tenant from the table!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textPhoneNumber.Text = textPhoneNumber.Text.Remove(textPhoneNumber.Text.Length - 1);
            }
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (textPurchasePlotId.Text != "") {
                    con.Open();
                    cmd = new SqlCommand("Exec PurchasePlot '" + ID + "', '" + textPurchasePlotId.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayOwnedProperties();
                    displayAvailableProperties();
                    displayResidents();
                    displayResidentApplications();
                }
                else
                {
                    MessageBox.Show("Enter a valid plot from the table!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (textSellPlotId.Text != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec SellOwnerPlot '"+ID+"', '" + int.Parse(textSellPlotId.Text) + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayOwnedProperties();
                    displayAvailableProperties();
                    displayResidents();
                    displayResidentApplications();
                }
                else
                {
                    MessageBox.Show("Enter a valid plot from the table!");
                }
            }
            else MessageBox.Show("Please Log In First!");
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
                displayOwner();

                displayOwnedProperties();
                displayAvailableProperties();
                displayResidents();
                displayResidentApplications();
                
            }
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
                        cmd = new SqlCommand("Exec UpdateOwnerFName '" + ID + "','" + textFName.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (textPhoneNumber.Text != "")
                    {
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
                            cmd = new SqlCommand("Exec UpdateOwnerPhoneNumber '" + ID + "','" + textPhoneNumber.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    if (textLName.Text != "")
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec UpdateOwnerLName '" + ID + "','" + textLName.Text + "'", con);
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
            displayOwner();
            displayOwnedProperties();
            displayAvailableProperties();
            displayResidents();
            displayResidentApplications();
        }
        public void displayOwner()//Method to display data.
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Exec OwnerLogin '"+ID+"'", con);
            adpt.Fill(dt);
            dataOwner.DataSource = dt;
            if (dt.Rows.Count == 1)
            {
                Logged = true;
            }
            else
            {
                MessageBox.Show("Invalid Id!");
                Logged = false;
                dataOwner.DataSource = null;
            }

            con.Close();
        }
        public void displayOwnedProperties()//Method to display data.
        {
            if (Logged == true)
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Exec OwnerProperties '" + ID + "'", con);
                adpt.Fill(dt);
                dataOwnedPlots.DataSource = dt;
                con.Close();
            }
            else
            {
                dataOwnedPlots.DataSource = null;
            }
        }

        public void displayAvailableProperties()
        {
            if (Logged == true)
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Exec AvailableProperties", con);
                adpt.Fill(dt);

                dataAvailablePlots.DataSource = dt;


                con.Close();
            }
            else
            {
                dataAvailablePlots.DataSource = null;
            }
        }

        public void displayResidents()
        {
            if (Logged == true)
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Exec OwnerResidents '" + ID + "'", con);
                adpt.Fill(dt);
                dataResidents.DataSource = dt;
                con.Close();
            }
            else
            {
                dataResidents.DataSource = null;
            }
        }
        public void displayResidentApplications()
        {
            if (Logged == true)
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Exec OwnerResidentApllications '" + ID + "'", con);
                adpt.Fill(dt);
                dataApplications.DataSource = dt;
                con.Close();
            }
            else
            {
                dataApplications.DataSource = null;
            }
        }
        private void dataOwner_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textFName.Text = dataOwner.Rows[e.RowIndex].Cells[1].Value.ToString();
            textLName.Text = dataOwner.Rows[e.RowIndex].Cells[2].Value.ToString();
            textPhoneNumber.Text = dataOwner.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataOwnedPlots_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textSellPlotId.Text = dataOwnedPlots.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataAvailablePlots_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataAvailablePlots_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textPurchasePlotId.Text = dataAvailablePlots.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void textResidentFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataResidents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textResidentFName.Text = dataResidents.Rows[e.RowIndex].Cells[1].Value.ToString();
            textResidentLName.Text = dataResidents.Rows[e.RowIndex].Cells[2].Value.ToString();
            textResidentPhoneNumber.Text = dataResidents.Rows[e.RowIndex].Cells[5].Value.ToString();
            textRent.Text = dataResidents.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        
        private void buttonApprove_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (FName != "" || LName != "" || PhoneNumber != "" || Gender != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec ApproveResidentApplication '" + FName + "','" + LName + "','" + PhoneNumber + "','" + plot_id + "', '" + Gender + "', '" + tenant + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayOwnedProperties();
                    displayAvailableProperties();
                    displayResidents();
                    displayResidentApplications();
                    FName = "";
                    LName = "";
                    PhoneNumber = "";
                    Gender = "";
                }
                else
                {
                    MessageBox.Show("Select a valid application!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void dataApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {

               FName = dataApplications.Rows[e.RowIndex].Cells[1].Value.ToString();
               LName= dataApplications.Rows[e.RowIndex].Cells[2].Value.ToString();
               PhoneNumber = dataApplications.Rows[e.RowIndex].Cells[3].Value.ToString();
               plot_id = int.Parse(dataApplications.Rows[e.RowIndex].Cells[4].Value.ToString());
               Gender = dataApplications.Rows[e.RowIndex].Cells[5].Value.ToString(); 
               tenant = int.Parse(dataApplications.Rows[e.RowIndex].Cells[6].Value.ToString());
        }

        private void buttonUpdateRent_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (textResidentFName.Text != "" || textResidentLName.Text != "" || textResidentPhoneNumber.Text != "")
                {
                    if (textRent.Text == "")
                    {
                        MessageBox.Show("Enter a valid rent.");
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("Exec RentResident '" + ID + "', '" + textResidentFName.Text + "', '" + textResidentLName.Text + "', '"+textResidentPhoneNumber.Text+"' ,'" + int.Parse(textRent.Text) + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        displayOwnedProperties();
                        displayAvailableProperties();
                        displayResidents();
                        displayResidentApplications();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid resident/tenant and rent from the table!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void dataOwnedPlots_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (FName != "" || LName != "" || PhoneNumber != "" || Gender != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec RejectResidentApplication '" + PhoneNumber + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayOwnedProperties();
                    displayAvailableProperties();
                    displayResidents();
                    displayResidentApplications();
                    FName = "";
                    LName = "";
                    PhoneNumber = "";
                    Gender = "";
                }
                else
                {
                    MessageBox.Show("Select a valid application!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }

        private void textRent_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSignIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
            if (Logged == true)
            {
                if (textSellPlotId.Text != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Exec OpenClosePlot '" + int.Parse(textSellPlotId.Text) + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayOwnedProperties();
                    displayAvailableProperties();
                    displayResidents();
                    displayResidentApplications();
                }
                else
                {
                    MessageBox.Show("Enter a valid plot from the table!");
                }
            }
            else MessageBox.Show("Please Log In First!");
        }
    }
}
