using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int processors = Environment.ProcessorCount;
        int checkedProc;
        int arrayLength;
        int threadCount;
        List<CheckBox> boxes = new List<CheckBox>();

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text += " "+processors.ToString();
            //  MessageBox.Show(processors.ToString());
            foreach (Control item in this.Controls)
            {
                if (item is CheckBox )
                {
                    boxes.Add((CheckBox)item);
                }
            }
            boxes.Reverse();
            for (int i = boxes.Count-1; i >=0; i--)
            {
                if (i<processors)
                {
                    boxes[i].Enabled = true;
                }
                else
                {
                    boxes[i].Enabled = false;
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkedProc.ToString());
        }

        private void CheckPrevious(int k)
        {
            if (k>0)
            {
                for (int i = 0; i < k; i++)
                {
                    if (!boxes[i].Checked)
                    {
                        boxes[i].Checked = true;


                    }


                }
            }
            
            
            checkedProc = ++k;
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CheckPrevious(0);
            }
            else
            {

            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                CheckPrevious(1);
            }
            else
            {
                CheckPrevious(0);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                CheckPrevious(2);
            }
            else
            {
                CheckPrevious(1);
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                CheckPrevious(3);
            }
            else
            {
                CheckPrevious(2);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                CheckPrevious(4);
            }
            else
            {
                CheckPrevious(3);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                CheckPrevious(5);
            }
            else
            {
                CheckPrevious(4);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                CheckPrevious(6);
            }
            else
            {
                CheckPrevious(5);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                CheckPrevious(7);
            }
            else
            {
                CheckPrevious(6);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text == "-"|| textBox2.Text=="0")
            {
                throw new Exception("Только положительные числа");
            }
            if (textBox2.Text!="")
            {
                arrayLength = Convert.ToInt32(textBox2.Text);
            }
            
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "-"|| textBox3.Text == "0")
            {
                throw new Exception("Только положительные числа");
            }
            if (textBox3.Text!="")
            {
                threadCount = Convert.ToInt32(textBox3.Text);
                
            }
           
                
            
           

            
        }
    }
}
