using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayExam
{
    class Program
    {
        static string[] words = new string[] { "do", "re", "mi", "fa", "sol", "la", "si", "do"};
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
                    int comparacionIzquierda = comparacion(words[from], words[j]);
                    if (comparacionIzquierda == 1)
                    {
                        swap(j, from);
                    }
                    int comparacionDerecha = comparacion(words[to], words[j]);
                    if (comparacionDerecha == -1)
                    {
                        swap(to, j);
                    }

                }
                from++;
                to--;
            }
            printArrr(words);
        }

        private static int comparacion(string word1, string word2)
        {
            for (int i = 0; i < 2; i++)
            {
                char letra1 = word1[i];
                char letra2 = word2[i];
                if (letra1 > letra2)
                {
                    return 1;
                }
                else if (letra1 < letra2)
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
        private static void printArrr(string[] arrayPrint)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arrayPrint[i]}   ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
