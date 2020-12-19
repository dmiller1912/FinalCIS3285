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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            listBox1.Items.Add(Form1.textbox2.Text);
            listBox1.Items.Add(Form2.textbox3.Text);
            listBox1.Items.Add(Form3.textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String userInput = textBox3.Text;
            String answers = userInput;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog(); //should show new form??
        }

        private void buttonNxtQues_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog(); //should show new form??
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
