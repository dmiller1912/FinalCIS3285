using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCIS3285
{
   public class Quiz 
    {
        String userInput;
        string[] questions = new String[12];

        public Quiz(string userInput, string[] questions)
        {
            this.userInput = userInput;
            this.questions = questions;
            questions[0] = "On the first day of Christmas my true love gave to me: ?";
            questions[1] = "On the second day of Christmas my true love gave to me: ?";
            questions[2] = "On the third day of Christmas my true love gave to me: ?";
            questions[3] = "On the fourth day of Christmas my true love gave to me: ?";
            questions[4] = "On the fifth day of Christmas my true love gave to me: ?";
            questions[5] = "On the sixth day of Christmas my true love gave to me: ?";
            questions[6] = "On the seventh day of Christmas my true love gave to me: ?";
            questions[7] = "On the eighth day of Christmas my true love gave to me: ?";
            questions[8] = "On the ninth day of Christmas my true love gave to me: ?";
            questions[9] = "On the tenth day of Christmas my true love gave to me: ?";
            questions[10] = "On the eleventh day of Christmas my true love gave to me: ?";
            questions[11] = "On the twelfth day of Christmas my true love gave to me: ?";
        }
        public static void main() { 
        String valueString = "Greetings user, this is the 12 days of christmas";
        Console.WriteLine(valueString);
            }

    }
}
