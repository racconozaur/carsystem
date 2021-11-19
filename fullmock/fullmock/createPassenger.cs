using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullmock
{
    internal class createPassenger : ICreator
    {
        public Car createCar(Guid carId, string model, string brand, int year, int price, ECondition condition)
        {
            return new PassengerType()
            {
                Id = carId,
                Model = model,
                Brand = brand,
                Year = year,
                Price = price,
                Condition = condition

            };
        }
    }
}
