using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayExam
{
    class Program
    {
        static string[] words = new string[] { "do", "re", "mi", "fa", "la", "si"};
        static int n = words.Length;

        static void Main(string[] args)
        {
            int from = 0;
            int to = n - 1;
            int x = n / 2;

            for (int i = 0; i < x; i++)
            {

                for (int j = i + 1; j < to; j++)
                {
                    int leftComparison = Comparison(words[from], words[j]);
                    if (leftComparison == 1)
                    {
                        swap(j, from);
                    }
                    int rightComparison = Comparison(words[to], words[j]);
                    if (rightComparison == -1)
                    {
                        swap(to, j);
                    }

                }
                from++;
                to--;
            }
            printArr(words);
        }

        private static int Comparison(string word1, string word2)
        {
            for (int i = 0; i < 2; i++)
            {
                char letter1 = word1[i];
                char letter2 = word2[i];
                if (letter1 > letter2)
                {
                    return 1;
                }
                else if (letter1 < letter2)
                {
                    return -1;
                }
            }
            return -1;
        }

        private static void swap(int pos1, int pos2)
        {
            string tmp = words[pos1];
            words[pos1] = words[pos2];
            words[pos2] = tmp;
        }
        private static void printArr(string[] arrayToPrint)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arrayToPrint[i]}   ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
