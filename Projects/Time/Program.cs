using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Waged Employee");
                Console.WriteLine("2. Salaried Employee");
                Console.WriteLine("3. Sales Employee");
                Console.WriteLine("4. Exit/n");
                Console.WriteLine("Choose an Employee or an Action: ");

                string c = Console.ReadLine();

                string name;				// variables used by all employee types
                int year;
                int month;
                int day;
                string street;
                string city;

                switch (c)
                {
                    case "1":	// waged employee
                        {
                            double wage;
                            double hours;
                            Input("Name", ref name);
                            Input("Wage", ref wage);
                            Input("Hours", ref hours);
                            Input("Year", ref year);
                            Input("Month", ref month);
                            Input("Date", ref day);
                            Input("Street", ref street);
                            Input("City", ref city);
                            WagedEmployee we = new WagedEmployee(name, year, month, day, wage, hours);
                            we.SetAddress(street, city);
                            Console.WriteLine(we.DisplayStat());
                            break;
                        }

                    case "2":	// salaried employee
                        {
                            double salary;
                            Input("Name", ref name);
                            Input("Salary", ref salary);
                            Input("Year", ref year);
                            Input("Month", ref month);
                            Input("Date", ref day);
                            Input("Street", ref street);
                            Input("City", ref city);
                            SalariedEmployee se = new SalariedEmployee(name, year, month, day, salary);
                            se.SetAddress(street, city);
                            Console.WriteLine(se.DisplayStat());
                            break;
                        }

                    case "3":	// sales employee
                        {
                            double salary;
                            double commission;
                            double sales;
                            Input("Name", ref name);
                            Input("Salary", ref salary);
                            Input("Commission", ref commission);
                            Input("Sales", ref sales);
                            Input("Year", ref year);
                            Input("Month", ref month);
                            Input("Date", ref day);
                            Input("Street", ref street);
                            Input("City", ref city);
                            SalesEmployee se = new SalesEmployee(name, year, month, day, salary, commission, sales);
                            se.SetAddress(street, city);
                            Console.WriteLine(se.DisplayStat());
                            break;
                        }

                    case "4":
                        break;
                }
            }
        }

        static void Input(string message, ref string var)
        {
            Console.WriteLine("{0} : ", message);
            var = Console.ReadLine();
        }

        static void Input(string message, ref int var)
        {
            Console.WriteLine("{0} : ", message);
            var = int.Parse(Console.ReadLine());
        }

        static void Input(string message, ref double var)
        {
            Console.WriteLine("{0} : ", message);
            var = double.Parse(Console.ReadLine());
        }
    }
}
