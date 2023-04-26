using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype1_dashboardIDea
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblAddedTemp.Text = "Added Temp: 0";
            int stuckTemp = 20;
            lblTotalTemp.Text = "Fake total temp: " + stuckTemp;

            lblFanStatus.Text = "Fan Status: Off";
            lblFanStatus.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAddedTemp.Text = "Added Temp: " + txtBoxAddedTemp.Text;
            int stuckTemp = 20;
            int newTemp = Convert.ToInt32(txtBoxAddedTemp.Text);
            int totalTemp = stuckTemp + newTemp;

            lblTotalTemp.Text = "Fake total temp: " + totalTemp;

            if (totalTemp > 100)
            {
                lblFanStatus.Text = "Fan Status: On";
                lblFanStatus.ForeColor = Color.Green;
            }
            else
            {
                lblFanStatus.Text = "Fan Status: Off";
                lblFanStatus.ForeColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_topics_Click(object sender, EventArgs e)
        {
            commandList commandList = new commandList();
            commandList.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblPositionX.Text = "Position X: 0";
            lblPositionY.Text = "Position Y: 0";
            lblPositionZ.Text = "Position Z: 0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblPositionX.Text = "Position X: " + txtBoxPosX.Text;
            lblPositionY.Text = "Position Y: " + txtBoxPosY.Text;
            lblPositionZ.Text = "Position Z: " + txtBoxPosZ.Text;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
