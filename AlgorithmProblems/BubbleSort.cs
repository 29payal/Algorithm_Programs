using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class BubbleSort
    {
        public static void bubblesort()
        {
            int[] number = { 43, 87, 97, 27 };

            int temp;

            for (int j = 0; j <= number.Length - 2; j++)
            {
                for (int i = 0; i <= number.Length - 2; i++)
                {
                    if (number[i] > number[i + 1])
                    {
                        temp = number[i + 1];
                        number[i + 1] = number[i];
                        number[i] = temp;
                    }
                }
            }
            Console.WriteLine("||  Bubble sorted elements ||");
            foreach (int i in number)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }
    }
}