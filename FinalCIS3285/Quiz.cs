using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCIS3285
{
   public class Quiz : Program
    {
        String userInput;
        string[] questions = new String[12];

        public Quiz(string userInput, string[] questions)
        {
            this.userInput = userInput;
            this.questions = questions;
            questions[0] = "On the first day of Christmas my true love gave to me: ?";
            questions[1] = "On the second day of Christmas my true love gave to me: ?";
        }


        




        public static void main() { 
        String valueString = "Greetings user, this is the 12 days of christmas";
        Console.WriteLine(valueString);
            }

    }
}
