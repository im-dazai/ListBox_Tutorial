using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            lstbx_1.Items.Add(textBox1.Text);
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (object obj in lstbx_1.Items)
            {
                check = 0;
                if (lstbx_2.Items.Contains(obj))
                {
                    check = 1;
                }
                else
                    lstbx_2.Items.Add(obj);


            }
            if (check == 1)
                MessageBox.Show("Duplicate Items");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (object obj in lstbx_2.Items)
            {
                if (lstbx_1.Items.Contains(obj))
                {
                    check = 1;
                }
                else
                lstbx_1.Items.Add(obj);
                

            }
            if (check == 1)
                MessageBox.Show("Duplicate Items");
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            lstbx_2.Items.Add(textBox2.Text);
        }


        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            lstbx_2.Items.Add(lstbx_1.SelectedItem);
        }


        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            lstbx_1.Items.Add(lstbx_2.SelectedItem);
        }

        
    }
}
