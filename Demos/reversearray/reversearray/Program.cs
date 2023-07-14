using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcometo Collection!");
            ArrayList arrayList = new ArrayList
            {
                "Viya",
                 "Priya",
                  "saranya"
            };
            Console.WriteLine("number of element in array list are: \t" + arrayList.Count);
            Console.WriteLine("Capacity of array list is: \t " + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("hema");
            arrayList.Add("lekha");
            Console.WriteLine("number of element in array list are: \t" + arrayList.Count);
            Console.WriteLine("Capacity of array list is: \t " + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reverse the list");
            arrayList.Reverse();
            Console.WriteLine("*** sorted array list in Dsc***");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
}
