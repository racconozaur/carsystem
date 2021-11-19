using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullmock
{
    internal class createInduatrial : ICreator
    {
        public Car createCar(Guid carId, string model, string brand, int year, int price, ECondition condition)
        {
            return new IndustrialType()
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
