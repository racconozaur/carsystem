using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullmock
{
    internal class PassengerType : Car
    {
        public override string AType
        {
            get
            {
                type = "Passenger";
                return type;
            }
        }
    }
}
