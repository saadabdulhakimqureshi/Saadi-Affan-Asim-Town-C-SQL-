using System;
using System.Windows.Forms;

namespace DBSProject1
{
    public partial class Form1 : Form
    {
        Resident rssignup = new Resident();
        ResidentYes rslogin = new ResidentYes();
        Owner onrsignup = new Owner();
        OwnerYes onrlogin = new OwnerYes();
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }





        private void Areyoulbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Show();
            label1.Hide();
            label3.Show();
            label4.Hide();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            //rs.Show();
        }

        private void Ownbtn_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            groupBox3.Hide();
            groupBox4.Hide();
            label1.Show();
            label3.Hide();
            label4.Hide();
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            //onr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            label1.Hide();
            label3.Hide();
            label4.Hide();

            prcdbtn.Hide();
        }

        private void Empbtn_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
            groupBox4.Hide();
            label1.Hide();
            label3.Hide();
            label4.Show();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
            {
                rssignup.Show();
                
            }
            else if(groupBox4.Visible)
            {
                rslogin.Show();

            }
            else if (radioButton2.Checked == true)
            {
                onrsignup.Show();
            }
            else if (radioButton1.Checked == true)
            {
             
                onrlogin.Show();
            }
            if (radioButton4.Checked == false)
            {
                prcdbtn.Hide();
            }

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
            {
                prcdbtn.Show();
            }
            else
            {
                prcdbtn.Hide();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
