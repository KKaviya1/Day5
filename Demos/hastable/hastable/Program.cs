using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hardware = new Hashtable() { { 1, "compact disc " }, { 2, "mouse" }, { 3, "Keyboard"} };
            Console.WriteLine("list of keys");
            foreach(var k in hardware.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("list of values");
            foreach (var v in hardware.Keys)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Hardware Key \t name of hardware");
            foreach (var k in hardware.Keys)
            {
                Console.WriteLine(k +"\t \t" + hardware[k]);
            }
            Console.ReadKey();
        }
    }
}
