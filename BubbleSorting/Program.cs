using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 15, 12, 3, 17, 189, 10, 36, 45, 33, 5 };
            int temp = 0;
            
            Console.Write("Unsorted array: ");
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            } 
            
            for (int i = 0; i < arr.Length; i++)
            {                
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            
            Console.Write("\n" + "Sorted array: " + " ");
            
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            
            Console.WriteLine();
        }
    }
}
