using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.classes
{
    class Lion : NonDomestic
    {
        public override int Legs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void hunting()
        {
            throw new NotImplementedException();
        }

        public override void sounds()
        {
            throw new NotImplementedException();
        }
    }
}
