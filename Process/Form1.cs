using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public string AL, AH, BL, BH, CL, CH, DL, DH;

     

        private void Form1_Load(object sender, EventArgs e)
        {
                  

        
        }

       
        private void label8_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            AL = textBox1.Text;
            if (AL.Length == 2)
            {
                
                textBox1.Text ="wartość poprawna = " + AL.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
 

        private void button2_Click(object sender, EventArgs e)
        {
            AH = textBox2.Text.ToUpper();
            if (AH.Length == 2)
            {
                
                textBox2.Text = "wartość poprawna = " + AH.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            BL = textBox3.Text;
            if (BL.Length == 2)
            {
                
                textBox3.Text = "wartość poprawna = " + BL.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            BH = textBox4.Text;
            if (BH.Length == 2)
            {
               
                textBox4.Text = "wartość poprawna = " + BH.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CL = textBox5.Text;
            if (CL.Length == 2)
            {
                
                textBox5.Text = "wartość poprawna = " + CL.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            CH = textBox6.Text;
            if (CH.Length == 2)
            {
               
                textBox6.Text = "wartość poprawna = " + CH.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DL= textBox7.Text;
            if (DL.Length == 2)
            {
                
                textBox7.Text = "wartość poprawna = " + DL.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DH = textBox8.Text;
            if (DH.Length == 2)
            {
             
                textBox8.Text = "wartość poprawna = " + DH.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
         
       







    }
}
