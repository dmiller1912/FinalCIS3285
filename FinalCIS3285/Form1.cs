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
        // private Form1 form;
        // private Form2 form2;
        String answers;
        String userInput;

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

        
       
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
           //Console.WriteLine(" " + Quiz.questions[0]);
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            userInput = textBox2.Text;
            answers = userInput;
        }

        private void WriteXmlToFile(DataSet thisDataSet)
        {
            if (thisDataSet.Equals(answers)) { return; }

            string fileName = "Answers.xml";

            System.IO.FileStream stream = new System.IO.FileStream
            (fileName, System.IO.FileMode.Create);

            System.Xml.XmlTextWriter xmlWriter =
            new System.Xml.XmlTextWriter(stream,
            System.Text.Encoding.Unicode);

            thisDataSet.WriteXml(xmlWriter);
            xmlWriter.Close();

        }
    }
}
