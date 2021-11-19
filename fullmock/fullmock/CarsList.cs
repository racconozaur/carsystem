using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullmock
{
     class CarsList
    {
        public List<Car> LCars { get; set; }

        public string TypeToSearch  { get; set; }

        public List<Car> Search()
        {
            return LCars.Where(item => item.AType == TypeToSearch).ToList();
        }

        //constructor
        private CarsList()
        {
            LCars = new List<Car>();
        }

        //singleton

        public static CarsList thisCarsList;
        public static CarsList GetCars()
        {
            if (thisCarsList == null)
            {
                thisCarsList = new CarsList();
            }
            return thisCarsList;
        }

        
        public void CarsForTest()
        {
            CarsList tolistofCars = GetCars();

            Car car1 = new createPassenger().createCar(Guid.NewGuid(), "Mers", "e-class", 2000, 12000, ECondition.New);
            tolistofCars.LCars.Add(car1);
            Car car2 = new createPassenger().createCar(Guid.NewGuid(), "BMW", "2 class", 2010, 15000, ECondition.AlmostNew);
            tolistofCars.LCars.Add(car2);
            Car car3 = new createInduatrial().createCar(Guid.NewGuid(), "Avtobus", "dabba", 2001, 14000, ECondition.Old);
            tolistofCars.LCars.Add(car3);


        }

    }
}
