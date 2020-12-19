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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void answerRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("3 french hens"))
            {
                answerRecord.Items.Add("question 1: correct");
            }
            else
            {
                answerRecord.Items.Add("question 1: incorrect");
            }

            answerRecord.Items.Add(Form1.textbox2.Text);
            answerRecord.Items.Add(Form2.textbox3.Text);
            answerRecord.Items.Add(Form3.textBox3.Text);
            answerRecord.Items.Add(Form4.textBox3.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog(); //should show new form??
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNxtQues_Click(object sender, EventArgs e)
        {
            //Form6 f6 = new Form6();
            //f6.ShowDialog(); //should show new form??
        }
    }
}
