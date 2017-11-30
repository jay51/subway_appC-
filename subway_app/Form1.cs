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
    public partial class slideOne : Form
    {
        byte count;
        int y;
        public Label[] lblList;
        public List<Panel> slides = new List<Panel>();
        public slideOne()
        {
            InitializeComponent();
            lblList = new Label[5];
            y = 0;
            count = 0;
        }
        
        private void slideOne_Load(object sender, EventArgs e)
        {
            slides.Add(panel1);
            slides.Add(panel2);
            slides.Add(panel3);
            slides.Add(panel4);
            slides.Add(panel5);

            for(int i = 0; i < lblList.Length; i++)
            {
                lblList[i] = new Label();
                lblList[i].AutoSize = true;
                lblList[i].BackColor = System.Drawing.Color.CadetBlue;
                lblList[i].Location = new System.Drawing.Point(424, 150 + y);
                lblList[i].Size = new System.Drawing.Size(40, 13);
                lblList[i].TabIndex = 3;
                y += 15;
            }

        }
        
        //asign all labels an index
        private void mkLabel(byte i ,Button button)
        {
            var btnName = button;
            if (lblList[i].Text == btnName.Text + count)
            {
                count++;
                lblList[i].Text = btnName.Text + count;
            }
            else
            {
                lblList[i].Text = btnName.Text + count;
                Controls.Add(lblList[i]);
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
        // for the message btn.
        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not added yet , but will be added soon");
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            for (int i =0; i< 5; i++)
            {
                slides[i].Visible = false;
            }
            panel1.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                slides[i].Visible = false;
            }
            panel5.Visible = true;

        }


        private void steak_Click(object sender, EventArgs e)
        {
            //var btnName = (Button)sender;
            mkLabel(0, (Button)sender);

        }

        private void tuna_Click(object sender, EventArgs e)
        {
            //var btnName = (Button)sender;
            mkLabel(1, (Button)sender);

        }

        private void Bmt_Click(object sender, EventArgs e)
        {
            //var btnName = (Button)sender;
            mkLabel(2, (Button)sender);

        }

        private void Blt_Click(object sender, EventArgs e)
        {
            //var btnName = (Button)sender;
            mkLabel(3, (Button)sender);

        }
    }

}
