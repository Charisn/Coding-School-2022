using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Multiply
    {

        public Multiply() { }
        public static void MultiplicationArray()
        {
            int[] Array = new int[16]; // i
            int[] Array1 = { 2, 4, 9, 12 };// j
            int[] Array2 = { 1, 3, 7, 10 };// k 

            for (int i = 0; i < 16;)
            {
                for (int j = 0; j < 4; j++) //Do this for every number in Array1
                {
                    for (int k = 0; k < 4; k++) // Do this for every number in Array2
                    {
                        Array[i] = Array1[j] * Array2[k];

                        i++; 
                    }
                }
            }

            Console.WriteLine(Array);
        }

    }
}
