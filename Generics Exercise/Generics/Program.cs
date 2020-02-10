using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var scale = new EqualityScale<int>(5,6);
            

            Console.WriteLine(scale.AreEqual());

            scale.WhichIsHAvier();

            List<int> tetsty = new List<int>();

            tetsty.Remove(2);
        }
    }
}
