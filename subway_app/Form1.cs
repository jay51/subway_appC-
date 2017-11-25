using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subway_app
{
    public partial class Form1 : Form
    {
        public Label[] lbllist;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnName = (Button)sender;
            if (btnName == tuna || btnName == steak)
            {
                lblone.Text = btnName.Text;
            }
            //this to show a message box.
            else if (btnName == info)
            {
                MessageBox.Show("this futuare is not avialble yet, comming soon!");
            }
            else
            {
                lbllist = new Label[5];
                lbllist[] = "hello world";
            }
            
        }
        // this is to show the box befor closing the form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to close the applciation", "now", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                //if the user click no then we cancel the closing.
                e.Cancel = true;
            }

        }





    }
}
