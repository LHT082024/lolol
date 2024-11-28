using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol
{
    public class Binary
    {
        //the class that acually converts the string to binary.
        //the foreach loop, loops through each character in the provided string
        //and converts it to binary string "base-2" 
        //then the badleft makes sure we have enough zeros that the words are 8 characters long. 
        //the + " " makes sure there are spaces between the words.
        public static string makeBinary(string text)
        {
            string binary = string.Empty;
            foreach (char chir in text)
            {
                binary += Convert.ToString(chir, 2).PadLeft(8, '0') + " ";
            }
            return binary.Trim();
        }
    }
}