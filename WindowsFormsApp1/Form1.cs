
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal fee1 = 0m;
                decimal fee2 = 0m;
                if (comboBox1.SelectedIndex == 0) //tiktok
                {
                    fee1 = 6.80m; //tiktok
                    fee2 = 2.24m;
                }
                else//shopee
                {
                    fee1 = 8.24m; 
                    fee2 = 2.24m;
                }
                decimal basePrice = Convert.ToDecimal(textBox1.Text);
                double totalFee1 = RoundCustom(Convert.ToDouble((basePrice * fee1) / 100));
                double totalFee2 = RoundCustom(Convert.ToDouble((basePrice * fee2) / 100));
                decimal income = basePrice - (Convert.ToDecimal(totalFee1) + Convert.ToDecimal(totalFee2));
                label1.Text = Convert.ToString(income);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //private decimal chec

        private double RoundCustom(double number)
        {
            //return (number - Math.Floor(number) >= 0.5)
            //    ? Math.Ceiling(number) // Round up if .5 or more
            //    : number;              // Retain the number if less than .5

            return Math.Round(number, MidpointRounding.AwayFromZero);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
