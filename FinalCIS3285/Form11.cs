﻿using System;
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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog(); //should show new form??
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userInput = textBox1.Text;
            String answers = userInput;
        }

        private void buttonNxtQues_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.ShowDialog(); //should show new form??

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void answerRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("11 pipers piping"))
            {
                answerRecord.Items.Add("question 11: correct");
            }
            else
            {
                answerRecord.Items.Add("question 11: incorrect");
            }

            answerRecord.Items.Add(Form1.textbox2.Text);
            answerRecord.Items.Add(Form2.textbox3.Text);
            answerRecord.Items.Add(Form3.textBox3.Text);
            answerRecord.Items.Add(Form4.textBox3.Text);
            answerRecord.Items.Add(Form5.textBox1.Text);
            answerRecord.Items.Add(Form6.textbox1.Text);
            answerRecord.Items.Add(Form7.textBox1.Text);
            answerRecord.Items.Add(Form8.textBox1.Text);
            answerRecord.Items.Add(Form9.textBox1.Text);
            answerRecord.Items.Add(Form10.textBox1.Text);

        }

    }
}
