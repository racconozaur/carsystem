using System;
using System.Collections.Generic;

namespace fullmock
{
    class Program
    {
        public static void WriteCars(List<Car> cars)
        {
            cars.ForEach(car =>
            {
            Console.WriteLine("UId: " + $"{car.Id}, {car.Model}, {car.Brand}, {car.AType}, {car.Condition}, {car.Price} ");
            });
        }
        static void Main(string[] args)
        {

            CarsList.GetCars().CarsForTest();
            var carscatalog = CarsList.GetCars();
            WriteCars(carscatalog.LCars);

            Console.WriteLine("Search by type (Industrial | Passenger | All)");
            var input = Console.ReadLine();



            switch (input)
            {
                case "Industrial":
                case "industrial":
                    Console.WriteLine("ind correct");
                    carscatalog.TypeToSearch = "Industrial";
                    var seachRes = carscatalog.Search();
                    WriteCars(seachRes);
                    break;
                case "Passenger":
                case "passenger":
                    Console.WriteLine("pas correct");
                    carscatalog.TypeToSearch = "Passenger";
                    var seachRes1 = carscatalog.Search();
                    WriteCars(seachRes1);
                    break;
                case "All":
                case "all":
                    Console.WriteLine("All cars");
                    WriteCars(carscatalog.LCars);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }

            /*carscatalog.TypeToSearch = "Industrial";
            var seachRes = carscatalog.Search();
            WriteCars(seachRes);*/



        }
    }
}

