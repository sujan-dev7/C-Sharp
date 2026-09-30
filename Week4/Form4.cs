using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
        if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                lblOutput.Text = "Login successful!";
                lblOutput.Visible = true;
            }
            else
            {
                lblOutput.Text = "Invalid username or password.";
                lblOutput.Visible = true;
            }
        }
    }
}
