using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class BubbleSort
    {
        public static void DisplayNumbers()
        {
            int[] array = { 78, 55, 45, 98, 13 };

            Console.WriteLine("\nBefore sorting : ");
            foreach (int e in array)
            {
                Console.WriteLine(e);
            }

            for (int j=0;j<=array.Length-2;j++)
            {
                for(int i=0;i<=array.Length-2;i++)
                {
                    if (array[i] > array[i+1])
                    {
                        int temp = array[i + 1];
                        array[i+1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted array: ");
            foreach(int e in array)
            {
                Console.WriteLine(e);
            }
        }
    }
}
