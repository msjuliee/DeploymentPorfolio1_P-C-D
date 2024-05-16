using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeploymentPorfolio1Pass
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter your name.");
            }
            else
            {
                MessageBox.Show(" Hello " + name + "! Welcome to SWE40006 - Software Deployment and Evolution!");
            }
        }
    }
}
