using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double marks = Convert.ToDouble(textBox1.Text);
            double total = Convert.ToDouble(textBox2.Text);

            double percentage = (marks / total) * 100;

            lblOutput.Text = "Percentage = " + percentage + "%";

            lblOutput.Visible = true;
        }

     
    }
}
