using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___7
{
    internal class Program
    {
        static void Main(string[] args)
        {
                ArrayList fruits = new ArrayList();

                fruits.Add("apple");
                fruits.Add("banana");
                fruits.Add("cherry");
                fruits.Add("date");
                fruits.Add("elderberry");

                Console.WriteLine("Total number of elements: " + fruits.Count);
     
                bool containsDate = fruits.Contains("date");
                Console.WriteLine("Contains 'date': " + containsDate);
               
                fruits.Insert(1, "fig");
              
                fruits.Remove("banana");

                Console.WriteLine("\nElements in the ArrayList:");
                foreach (var fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }
            Console.ReadKey();
            }
        }

    }

