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

            for (int i = 0; i < Card.Length; i++) // This is a outer array of for loop that creates the COLUMN
            {
                for (int j = 0; j < Card[i].Length; j++) // This is a inner array of for loop that creates the ROW
                {
                    bool numPass = false;
                    while (!numPass)
                    {
                        temp = rng.Next(1 + (j * 15), 16 + (j * 15)); // Generate Random Number and Increments by 15 on min and max value per row for BINGO
                        for (int k = 0; k < 5; k++)
                        {
                            if (i == 0)
                            {
                                Card[i][j] = temp;
                                numPass = true;
                                break;
                            }
                            if (Card[k][j] == temp) // Checks every ROW for reoccuring value
                                break;
                            if (k == 4) // If done checking assign the value to the array
                            {
                                Card[i][j] = temp;
                                numPass = true;
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
