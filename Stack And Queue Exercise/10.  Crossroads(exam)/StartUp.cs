namespace _10.__Crossroads_exam_
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public  class StartUp
    {
       public static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            string car = string.Empty;
            int carLenght = 0;
            bool isHit = false;
            char hittedSymbol = '\0';
            int carsCount = 0;

            string input = string.Empty;

            while ((input=Console.ReadLine())!="END")
            {
                if (input!="green")
                {
                    cars.Enqueue(input);
                    continue;
                }
                int currentGreenLight = greenLight;

                while (currentGreenLight>0  && cars.Count>0)
                {                  
                    car = cars.Dequeue();
                    carLenght = car.Length;
                    if (currentGreenLight - carLenght >=0)
                    {
                        currentGreenLight -= carLenght;
                        carsCount++;
                    }
                    else
                    {
                        currentGreenLight += freeWindow;
                        if (currentGreenLight - carLenght >= 0)
                        {
                            currentGreenLight -= carLenght;
                            carsCount++;
                            break;
                        }
                        else
                        {
                            isHit = true;
                            hittedSymbol = car[currentGreenLight];
                            break;
                        }
                    }
                }
                if (isHit)
                {
                    break;
                }
              
            }
            if (isHit)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{car} was hit at {hittedSymbol}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsCount} total cars passed the crossroads.");
            }
        }
    }
}
