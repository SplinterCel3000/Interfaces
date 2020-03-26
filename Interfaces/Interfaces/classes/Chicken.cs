using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.interfaces;

namespace Interfaces.classes
{
    class Chicken : Domestic , IStuck , IFly
    {
        public override int Legs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string HasFeet()
        {
            return "I dont have any feet";
        }

        public override void hunting()
        {
            throw new NotImplementedException();
        }

        public int MinWings()
        {
            return 0;
        }

        public override void sounds()
        {
            throw new NotImplementedException();
        }

        public string stuck()
        {
            return "Im stuck on the ground";
        }
    }
}
