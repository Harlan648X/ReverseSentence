using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Reverser
    {
        public static void ReverseSentence()
        {
            string result = "";
            string input = "";
            //Char.IsLetter(ch)
            Console.WriteLine("Enter a sentence to reverse");
            input = Console.ReadLine();
            string[] stringArray = input.Split(' ');
            Array.Reverse(stringArray);
            result = string.Join(" ", stringArray);
            Console.WriteLine(result);
        }

    }
}
