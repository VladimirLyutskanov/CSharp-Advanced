using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Speed_Racing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {


                string[] carsData = Console.ReadLine().Split();

                string carModel = carsData[0];
                double fuelAmount = double.Parse(carsData[1]);
                double fuelConsumptionPerKilometer = double.Parse(carsData[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(car);
            }
            string inputline = "";

            while ((inputline = Console.ReadLine()) != "End")
            {
                string[] data = inputline.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModelTo = data[1];

                double amountOfKm = double.Parse(data[2]);

                Car car = cars.FirstOrDefault(c => c.Model == carModelTo);

                car.Drive(amountOfKm);
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

