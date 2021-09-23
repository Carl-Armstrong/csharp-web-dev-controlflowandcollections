using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    class Class1
    {
        public static int sumEven(List<int> intList)
        {
            int sum = 0;

            foreach (int i in intList)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

       
    }
}
