using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        WebService1SoapClient obj;
        public Form1()
        {
            InitializeComponent();
            obj = new WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res=0.0;
            if (comboBox1.Text == "Celsius")
            {
                res = obj.toCelc(Convert.ToDouble(textBox1.Text));
            }
            else
            {
                res = obj.toFaran(Convert.ToDouble(textBox1.Text));
            }
            label5.Text = res.ToString();
        }
    }
}
