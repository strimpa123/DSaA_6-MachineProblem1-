using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_6__MachineProblem1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] Card = new int[5][];
            Random rng = new Random();
            int temp = 0;
            for (int i = 0; i < Card.Length; i++)
                Card[i] = new int[5];

            for (int i = 0; i < Card.Length; i++)
            {
                for (int j = 0; j < Card[i].Length; j++)
                {
                    if (i == 0)
                        Card[i][j] = rng.Next(1 + (j * 15), 16 + (j * 15));
                    else
                    {
                        bool numPass = false;
                        while (!numPass)
                        {
                            temp = rng.Next(1 + (j * 15), 16 + (j * 15));
                            for (int k = 0; k < 5; k++)
                            {
                                if (Card[k][j] == temp)
                                    break;
                                if (k == 4)
                                {
                                    Card[i][j] = temp;
                                    numPass = true;
                                }
                            }
                        }
                    }
                    Console.Write($"[{Card[i][j]}]\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
