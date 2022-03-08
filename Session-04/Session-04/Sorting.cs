using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Sorting
    {
        public Sorting() { }

        public static void Sort()
        {
            int[] ArrayForSorting = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            int j = 0;
            int[] NegativesArray = new int[] { };

            // Store all negative values
            for (int i = 0; i < 10; i++)
            {
                if (ArrayForSorting[i] < 0)
                {
                    ArrayForSorting[i] = NegativesArray[j];
                }
            }


        }
    }
}
