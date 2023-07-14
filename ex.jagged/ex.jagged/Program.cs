using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter No of employees: ");
        int numOfEmployees = int.Parse(Console.ReadLine());

        Console.Write("Enter No of working days for each employee: ");
        int numOfDays = int.Parse(Console.ReadLine());

        int[][] employeeSalaries = new int[numOfEmployees][];

        for (int i = 0; i < numOfEmployees; i++)
        {
            employeeSalaries[i] = new int[numOfDays];

            for (int j = 0; j < numOfDays; j++)
            {
                Console.Write($"\nEnter salary for Day {j + 1} of Employee {i + 1}: ");
                employeeSalaries[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nWeekly Salaries:");

        for (int i = 0; i < numOfEmployees; i++)
        {
            int weeklySalary = 0;

            for (int j = 0; j < numOfDays; j++)
            {
                weeklySalary += employeeSalaries[i][j];
            }

            Console.WriteLine($"Employee {i + 1}: {weeklySalary}");
        }

            Console.ReadKey();
        }
    
}