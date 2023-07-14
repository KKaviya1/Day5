using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[][] {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
        };

                Console.WriteLine("Student Scores:");
                for (int i = 0; i < studentScores.Length; i++)
                {
                    Console.Write("Student {0}: ", i + 1);
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        Console.Write(studentScores[i][j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nAverage Scores:");
                for (int i = 0; i < studentScores.Length; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        sum += studentScores[i][j];
                    }
                    double average = (double)sum / studentScores[i].Length;
                    Console.WriteLine("Student {0}: {1}", i + 1, average);
                }

                Console.WriteLine("\nAverage Score for All Students Combined:");
                int totalSum = 0;
                int totalLength = 0;
                for (int i = 0; i < studentScores.Length; i++)
                {
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        totalSum += studentScores[i][j];
                        totalLength++;
                    }
                }
                double totalAverage = (double)totalSum / totalLength;
                Console.WriteLine(totalAverage);
                Console.ReadKey();
        }
              
        }

    }
