using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol
{
    public class Binary
    {
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