using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
    static double allSumCafe;
        public Form1()
        {
            InitializeComponent();
            benzinCB.Items.Add("92");
            benzinCB.Items.Add("95");
            benzinCB.Items.Add("Premium");
            
        }

        private void benzinCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (benzinCB.SelectedItem == "92")
            {
                QiymetTb.Text = " 1L = 1M ";
            }
            else if(benzinCB.SelectedItem == "95")
            {
                QiymetTb.Text = " 1L = 1.5M ";
            }
            else if(benzinCB.SelectedItem == "Premium")
            {
                QiymetTb.Text = " 1L = 2M ";                
            }
        }

        private void MiqdarRb_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
           
        }

        private void QiymetRb_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                label6.Text = "";           
            }
            if (benzinCB.SelectedItem == "92")
            {
                double sum = double.Parse(textBox1.Text);
                label6.Text = $"{sum}";
            }
            else if (benzinCB.SelectedItem == "95")
            {
                double sum = double.Parse(textBox1.Text);
                label6.Text = $"{sum*1.5}";
            }
            else if (benzinCB.SelectedItem == "Premium")
            {
                double sum = double.Parse(textBox1.Text);
                label6.Text = $"{sum*2}";
            }
            else
            {
                label6.Text = "Benzin secilmeyib";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label6.Text = "";
            }
            if (benzinCB.SelectedItem == "92")
            {
                double sum = double.Parse(textBox2.Text);
                label6.Text = $"{sum}";
            }
            else if (benzinCB.SelectedItem == "95")
            {
                double sum = double.Parse(textBox2.Text);
                label6.Text = $"{sum}";
            }
            else if (benzinCB.SelectedItem == "Premium")
            {
                double sum = double.Parse(textBox2.Text);
                label6.Text = $"{sum}";
            }
            else
            {
                label6.Text = "Benzin secilmeyib";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            if (textBox4.Text != null)
            {

                allSumCafe += double.Parse(textBox4.Text);
                label8.Text = $"{allSumCafe}";
            }
                
            //}
            //else
            //{

            //}
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                allSumCafe += double.Parse(textBox6.Text);
                label8.Text = $"{allSumCafe}";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                allSumCafe += double.Parse(textBox8.Text);
                label8.Text = $"{allSumCafe}";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                allSumCafe += double.Parse(textBox10.Text);
                label8.Text = $"{allSumCafe}";
            }
        }

        private void HesablaBtn_Click(object sender, EventArgs e)
        {
            if (label6.Text != null && label8.Text != null)
            {
                double a = double.Parse(label6.Text);
                double b = double.Parse(label8.Text);
                label1.Text = $"{a + b}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
