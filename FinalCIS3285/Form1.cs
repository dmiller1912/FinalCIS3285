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
    public partial class Form1 : Form
    {
        private Form1 form;
        private Form2 form2;
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
            Console.WriteLine(" " + Question[0]);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("a Partridge");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("a ParaKeet");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
