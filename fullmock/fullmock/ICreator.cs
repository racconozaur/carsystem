using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullmock
{
    interface ICreator
    {
        public Car createCar(Guid carId, string model, string brand, int year, int price, ECondition condition );
    }
}
