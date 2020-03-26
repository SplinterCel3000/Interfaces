using Interfaces.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.classes
{
    class Cow : Domestic , IFly
    {
        public override void sounds()
        {
            Console.WriteLine("Mooo");
            return;
        }

        public override void hunting()
        {
            Console.WriteLine("Bro Im a cow I cant hunt");
            return;
        }

        public override string eating(string food)
        {
            food = "I eat grrraaaass";
            Console.WriteLine(food);
            return base.eating(food);
        }

        public override bool Tail { get; set; } = true;

        public override int Legs { get; set; } = 4;

        public override string Friendly { get; set; } = "yess im friendly";

        public override string Color { get; set; } = "im brown";
        
        public string HasFeet()
        {
            return "Yes I have feet";
        }
        public int MinWings()
        {
            return 4; 
        }
    }
}
