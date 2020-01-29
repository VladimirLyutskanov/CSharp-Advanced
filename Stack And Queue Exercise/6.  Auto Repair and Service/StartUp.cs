namespace _6.__Auto_Repair_and_Service
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> cars = new Queue<string>(input);

            string command = string.Empty;
            Stack<string> servedCars = new Stack<string>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] splittedCommand = command.Split("-");

                if (splittedCommand[0] == "Service" && cars.Count > 0)
                {
                    servedCars.Push(cars.Peek());
                    Console.WriteLine($"Vehicle {cars.Dequeue()} got served.");
                }
                else if (splittedCommand[0] == "CarInfo")
                {
                    string carmodel = splittedCommand[1];
                    if (servedCars.Contains(carmodel))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (splittedCommand[0] == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }         
            }
            
            if (cars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");

        }
    }
}
