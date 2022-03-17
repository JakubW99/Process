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

                textBox1.Text = AL.ToUpper();
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

                textBox2.Text = AH.ToUpper();
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

                textBox3.Text = BL.ToUpper();
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

                textBox4.Text = BH.ToUpper();
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

                textBox5.Text = CL.ToUpper();
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

                textBox6.Text = CH.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DL = textBox7.Text;
            if (DL.Length == 2)
            {

                textBox7.Text = DL.ToUpper();
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

                textBox8.Text = DH.ToUpper();
            }
            else
            {
                MessageBox.Show("podaj poprawną wartość!", "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add(" AL = " + AL);
            listView1.Items.Add(" AH = " + AH);
            listView1.Items.Add(" BL = " + BL);
            listView1.Items.Add(" BH = " + BH);
            listView1.Items.Add(" CL = " + CL);
            listView1.Items.Add(" CH = " + CH);
            listView1.Items.Add(" DL = " + DL);
            listView1.Items.Add(" DH = " + DH);

        }
        public string Checked0()
        {
            var check0 = "";
            foreach (object Item in checkedListBox1.CheckedItems)
            {
                check0 = Item.ToString();

            }
            return check0;
           

        }
        public string Checked1()
        {
            var check1 = "";
            foreach (object Item in checkedListBox2.CheckedItems)
            {
                check1 = Item.ToString();

            }
            return check1;
        }


        public void MOV()
        {
            var List = new List<string> { "AL", "AH", "BL", "BH", "CL", "CH", "DL", "DH" };
            var list1 = new List<string> { AL, AH, BL, BH, CL, CH, DL, DH };
            var itemToChange = "";
            var itemChanging = "";
            if(checkedListBox3.SelectedItem.ToString() == "MOV")
            {
                foreach ( var item in List)
                {
                    foreach (var value in list1)
                    {


                        if (Checked0() == item.)
                        {
                            itemToChange = value;
                        }
                        if (Checked1() == item)
                        {
                            itemChanging = value;
                        }
                    }
                }
                MessageBox.Show(itemToChange +" "+itemChanging, "bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            MOV();
        }










    }
}
