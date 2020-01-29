namespace _7.__Truck_Tour
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Queue<int[]> petrolpumps = new Queue<int[]>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int[] petrolpump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                petrolpumps.Enqueue(petrolpump);
            }

            int index = 0;


            while (true)
            {
                int totalFuel = 0;
                foreach (var pump in petrolpumps)
                {


                    int petrol = pump[0];
                    int distance = pump[1];

                    totalFuel += petrol - distance;
                    if (totalFuel < 0)
                    {
                        petrolpumps.Enqueue(petrolpumps.Dequeue());
                        index++;
                        break;
                    }

                }
                if (totalFuel > 0)
                {
                    break;
                }

            }
            Console.WriteLine(index);
        }
    }
}
