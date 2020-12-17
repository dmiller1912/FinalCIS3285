using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCIS3285
{
    class Question : Quiz
    {
       //Question[] questions = new Question[12];


        private String text;
        private String answer;

        public Question()
        {
            text = "";
            answer = "";
        }

        public String getText()
        {
            return text;
        }
        public void setText(String inText)
        {
            text = inText;
        }
        public String getAnwser()
        {
            return answer;
        }
        public void setAnswer(String inAnswer)
        {
            answer = inAnswer;
        }

        public bool isCorrect(String userGuess)
        {
            bool correct = false;
            if (userGuess.Equals(answer))
            {
                correct = true;
            }
            return correct;
        }

    }
}
