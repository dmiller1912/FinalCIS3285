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
    public partial class Form1 : Form
    {
        // private Form1 form;
        // private Form2 form2;
        String answers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonNxtQues_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); //should show new form??


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
               
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(" " + Quiz.questions[0]);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" " + Quiz.questions[0]);
        }

        private void answerRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("a partridge in a pear tree"))
            {
                answerRecord.Items.Add("question 1: correct");
            } else
            {
                answerRecord.Items.Add("question 1: incorrect");
            }
        }
    }
}
