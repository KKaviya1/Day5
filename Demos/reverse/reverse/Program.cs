using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList { 12, 45, 30, 11 };
            Console.WriteLine("Number List");
            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }
            myList.Reverse();
            Console.WriteLine("***Reverse Number List***");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            myList.Sort();
            Console.WriteLine("***Sorted number List***");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            myList.RemoveAt(3);
            Console.WriteLine("after removing from index 3");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            myList.Remove(45);
            Console.WriteLine("after removing");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
