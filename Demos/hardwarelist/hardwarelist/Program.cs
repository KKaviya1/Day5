using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardwarelist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList hardwareList = new ArrayList();
            hardwareList.Add("CD");
            hardwareList.Add("Printer");
            hardwareList.Add("Keyboard");
            hardwareList.Add("Mouse");
            hardwareList.Add("Network Card");
            Console.WriteLine("initial hardware list");
            for(int i = 0; i<hardwareList.Count; i++)
            {
                Console.WriteLine(hardwareList[i]);
            }
            Console.WriteLine("enter item to search & update");
            string searchItem = Console.ReadLine();
            int index=hardwareList.IndexOf(searchItem); 
            if(index ==-1)
            {
                Console.WriteLine($"no such item {searchItem} exist in hardware list");

            }
            else
            {
                Console.WriteLine(" enter upadte item");
                hardwareList[index] = Console.ReadLine();
                Console.WriteLine("update hardware list is as follows !!");
                for (int i = 0; i < hardwareList.Count; i++)
                {
                    Console.WriteLine(hardwareList[i]);
                }
                Console.ReadKey();
            }
        }


    }
}
