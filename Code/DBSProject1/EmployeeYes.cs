using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSProject1
{
    public partial class EmployeeYes : Form
    {
        Executive exec = new Executive();
        Transportation trnsport = new Transportation();
        Emergency emrgency = new Emergency();
        public EmployeeYes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeYes_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                exec.Show();

            }
            catch (Exception ex)
            {
                Executive exec = new Executive();
                exec.Show();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                trnsport.Show();

            }
            catch (Exception ex)
            {
                Transportation trnsport = new Transportation();
                trnsport.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                emrgency.Show();

            }
            catch (Exception ex)
            {
                Emergency emrgency = new Emergency();
                emrgency.Show();

            }

        }
    }
}
