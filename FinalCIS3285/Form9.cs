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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog(); //should show new form??
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userInput = textBox1.Text;
            String answers = userInput;
        }

        private void buttonNxtQues_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog(); //should show new form??

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void answerRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("9 ladies dancing"))
            {
                answerRecord.Items.Add("question 9: correct");
            }
            else
            {
                answerRecord.Items.Add("question 9: incorrect");
            }

            answerRecord.Items.Add(Form1.textbox2.Text);
            answerRecord.Items.Add(Form2.textbox3.Text);
            answerRecord.Items.Add(Form3.textBox3.Text);
            answerRecord.Items.Add(Form4.textBox3.Text);
            answerRecord.Items.Add(Form5.textBox1.Text);
            answerRecord.Items.Add(Form6.textbox1.Text);
            answerRecord.Items.Add(Form7.textBox1.Text);
            answerRecord.Items.Add(Form8.textBox1.Text);
        }

    }
}
