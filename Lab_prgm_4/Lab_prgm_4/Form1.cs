using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_prgm_4
{
    public partial class Form1 : Form
    {
        string[] products = { "apple", "banana", "orange" };
        int[] price = { 100, 200, 300 };
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(products);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(selectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Price of 1 kg " + products[listBox1.SelectedIndex] + " is Rs "+ price[listBox1.SelectedIndex]; 
        }
    }
}
