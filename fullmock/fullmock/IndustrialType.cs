using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullmock
{
    internal class IndustrialType : Car
    {
        public override string AType
        {
            get
            {
                type = "Industrial";
                return type;

            }
        }
    }
}
