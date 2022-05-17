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
       
       


        private void Form1_Load(object sender, EventArgs e)
        {



        }


        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
             
            if (textBox1.Text.Length == 2)
            {

                textBox1.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
           
            if (textBox2.Text.Length == 2)
            {

                textBox2.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
           
            if (textBox3.Text.Length == 2)
            {

                textBox3.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
          
            if (textBox4.Text.Length == 2)
            {

                textBox4.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
            if (textBox5.Text.Length == 2)
            {

                textBox5.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (textBox6.Text.Length == 2)
            {

                textBox6.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
           
            if (textBox7.Text.Length == 2)
            {

                textBox7.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
           
            if (textBox8.Text.Length == 2)
            {

                textBox8.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add(" AL = " + textBox1.Text);
            listView1.Items.Add(" AH = " + textBox2.Text);
            listView1.Items.Add(" BL = " + textBox3.Text);
            listView1.Items.Add(" BH = " + textBox4.Text);
            listView1.Items.Add(" CL = " + textBox5.Text);
            listView1.Items.Add(" CH = " + textBox6.Text);
            listView1.Items.Add(" DL = " + textBox7.Text);
            listView1.Items.Add(" DH = " + textBox8.Text);

        }
       

        public void MOV()
        {
            if (checkedListBox3.SelectedItem.ToString() == "MOV")
            {
                listView2.Items.Clear();
                SelectFromRegister().Text = SelectToRegister().Text;
                listView2.Items.Add(" AL = " + textBox1.Text);
                listView2.Items.Add(" AH = " + textBox2.Text);
                listView2.Items.Add(" BL = " + textBox3.Text);
                listView2.Items.Add(" BH = " + textBox4.Text);
                listView2.Items.Add(" CL = " + textBox5.Text);
                listView2.Items.Add(" CH = " + textBox6.Text);
                listView2.Items.Add(" DL = " + textBox7.Text);
                listView2.Items.Add(" DH = " + textBox8.Text);
            }
        }
        public TextBox SelectToRegister()
        {
            if (checkedListBox1.SelectedItem.ToString() == "AL") return textBox1;
            if (checkedListBox1.SelectedItem.ToString() == "AH") return textBox2;
            if (checkedListBox1.SelectedItem.ToString() == "BL") return textBox3;
            if (checkedListBox1.SelectedItem.ToString() == "BH") return textBox4;
            if (checkedListBox1.SelectedItem.ToString() == "CL") return textBox5;
            if (checkedListBox1.SelectedItem.ToString() == "CH") return textBox6;
            if (checkedListBox1.SelectedItem.ToString() == "DL") return textBox7;
            else  return textBox8;
        }
        public TextBox SelectFromRegister()
        {
            if (checkedListBox2.SelectedItem.ToString() == "AL") return textBox1;
            if (checkedListBox2.SelectedItem.ToString() == "AH") return textBox2;
            if (checkedListBox2.SelectedItem.ToString() == "BL") return textBox3;
            if (checkedListBox2.SelectedItem.ToString() == "BH") return textBox4;
            if (checkedListBox2.SelectedItem.ToString() == "CL") return textBox5;
            if (checkedListBox2.SelectedItem.ToString() == "CH") return textBox6;
            if (checkedListBox2.SelectedItem.ToString() == "DL") return textBox7;
            else return textBox8;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            MOV();
        }










    }
}
