using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bubble_Sort
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
         
        }
        int i = 0;
        int[] val;
        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter size of Array ");
            }
            else
            {
                int n = Convert.ToInt32(textBox2.Text);
                val = new int[n];
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            try{
                if (i < n)
                {
                    val[i] = Convert.ToInt32(textBox1.Text);
                    i++;
                }
                else
                {
                    textBox1.Enabled = false;
                    MessageBox.Show("Out of Array size");
                }
            }
            catch(Exception ex)
            {}
            textBox1.Text = "";

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            int buf = 0;
            for (int i = 1; i <= val.Length - 1; i++)
            {
                if (val[i] < val[i - 1])
                {
                    buf = val[i - 1];
                    val[i - 1] = val[i];
                    val[i] = buf;
                }
            }
            for (int i = 0; i < n; i++)
            {
                label1.Text += val[i];
                label1.Text += "  ";

            }
//////////////////////////////////////////////////////////////////////////////////////////
            //simple example
            /*int[] a = {4,8,2,66,0,3,10,6};
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (a[i] < a[i - 1])
                {
                    buf = a[i - 1];
                    a[i - 1] = a[i];
                    a[i] = buf;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                label1.Text += a[i];
                label1.Text += "  ";

            }
             */
           
           
               

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

       

      
    }
}
