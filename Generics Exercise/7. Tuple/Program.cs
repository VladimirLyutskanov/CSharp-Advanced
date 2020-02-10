using System;

namespace _7._Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string[] personBeerInfo = Console.ReadLine().Split();
            string[] numbersInfo = Console.ReadLine().Split( );

            string personName = personInfo[0] + " " + personInfo[1];
            string personTown = personInfo[2];

            Tuple<string, string> personTuple = new Tuple<string, string>(personName, personTown);

            string personNameBeers = personBeerInfo[0];
            decimal beers =decimal.Parse( personBeerInfo[1]);

            Tuple<string, decimal> personBeersTuple = new Tuple<string, decimal>(personNameBeers, beers);

            int numbersInt = int.Parse(numbersInfo[0]);
            double numbersDouble = double.Parse(numbersInfo[1]);

            Tuple<int, double> numberTuple = new Tuple<int, double>(numbersInt, numbersDouble);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeersTuple.GetInfo());
            Console.WriteLine(numberTuple.GetInfo());

        }
    }
}
