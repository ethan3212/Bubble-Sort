using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 100; 
            int[] a = new int[N]; 
            Random r = new Random(); 
            for (int i = 0; i < N; i++) 
            { 
                a[i] = r.Next(1, N + 1); 
            }

            // display unsorted list
            WriteLine("Unsorted: ");
            foreach (int i in a)
            {
                Write(i + " ");
            }
            WriteLine();

            // call sort routine        
            BubbleSort(a, N);
            //SpecialInsertionSort(testArray, N, testArray[0], testArray[N-1]);

            // display sorted list
            WriteLine("Sorted: ");
            foreach (int i in a)
            {
                Write(i + " ");
            }
            WriteLine();
            ReadLine();
        }
        static void BubbleSort(int[] list, int N)
            // list: the elements to be put into order
            // N: the number of elements in the lsit
        {
            int numberOfPairs = N;
            bool swappedElements = true;

            while(swappedElements)
            {
                numberOfPairs = numberOfPairs - 1;
                swappedElements = false;

                for(int i = 0; i < numberOfPairs; i++)
                {
                    if(list[i] > list[i + 1])
                    {
                        Swap(list, i, (i + 1));
                        swappedElements = true;
                    }
                }
            }
        }
        static void Swap(int[] list, int i, int j)
        {
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}