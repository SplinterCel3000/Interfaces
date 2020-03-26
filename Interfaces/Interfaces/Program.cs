using System;
using Interfaces.classes;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cow thing = new Cow();
            Console.WriteLine("things about a cow");
            Console.WriteLine(thing.eating("grass"));
            Console.WriteLine(thing.Friendly);
            Console.WriteLine(thing.Legs);
            Console.WriteLine(thing.HasFeet());
        }
    }
}
