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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog(); //should show new form??
        }

        private void buttonNxtQues_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals("2 turtle doves"))
            {
                listBox1.Items.Add("question 2: correct");
            }
            else
            {
                listBox1.Items.Add("question 2: incorrect");
            }

            listBox1.Items.Add(Form1.textbox2.text);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String userInput = textBox3.Text;
            String answers = userInput;
        }
    }
}
