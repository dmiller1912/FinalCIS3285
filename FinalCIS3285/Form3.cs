using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCIS3285
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String userInput = textBox3.Text;
            String answers = userInput;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals("3 french hens"))
            {
                listBox1.Items.Add("question 1: correct");
            }
            else
            {
                listBox1.Items.Add("question 1: incorrect");
            }

            listBox1.Items.Add(Form1.textbox2.text);
            listBox1.Items.Add(Form2.textbox3.text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonNxtQues_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog(); //should show new form??
        }
    }
}
