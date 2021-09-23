using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1, 1, 2, 3, 5, 8
            int[] practiceArray = { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < practiceArray.Length; i++)
            {
                if (practiceArray[i] % 2 != 0)
                {
                    Console.WriteLine(practiceArray[i]);
                }
            }
        }
    }
}
