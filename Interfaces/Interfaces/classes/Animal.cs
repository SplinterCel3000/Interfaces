using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.classes
{
    abstract class Animal
    {
        public abstract int Legs { get; set; }
        public virtual bool Tail { get; set; }
        public abstract string Color { get; set; }
        public virtual string Friendly { get; set; }

        public abstract void sounds();

        public virtual string sleeping() 
        {
            return "is sleeping";
        }

        public abstract void hunting();

        public virtual string eating(string food)
        {
            return "Where the food at I need to eat";
        }

        
    }
}
