using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Askhsh1
    {   
        public Askhsh1() { }
        public static string ReversedName(string name)
        {

            char[] charArray = name.ToCharArray();

            string reversedName = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedName += charArray[i];
            }
            return reversedName;
        }

    }
}