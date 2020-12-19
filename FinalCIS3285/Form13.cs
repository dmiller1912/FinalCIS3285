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
    public partial class Form13 : Form
    {
        String answers;
        String userInput;
        public Form13()
        {
            InitializeComponent();
        }

        private void answerRecord_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            answerRecord.Items.Add(Form11.textBox1.Text);
            answerRecord.Items.Add(Form12.textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInput = answerRecord.Items.ToString();
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
