using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbAndRepo
{
    public class CarRepository : ICarRepository
    {
        public static List<Car> AllCars = new List<Car>
            {
                new Car
                {
                    Name = "Venza",
                     Amount =1900000m,
                     Color = "White",
                      EngineType ="2L",
                       Id = 1,
                       OrganizationId = 1,
                },
                 new Car
                {
                    Name = "Lexus570",
                     Amount =5200000m,
                     Color = "White",
                      EngineType ="2L",
                       Id = 2,
                       OrganizationId = 1,
                },
                  new Car
                {
                    Name = "Hyundai-Elantra",
                     Amount =1200000m,
                     Color = "White",
                      EngineType ="2L",
                       Id = 3,
                        OrganizationId = 1,
                }
            };
        public List<Car> GetAllCars()
        {
            return AllCars;
        }

        public Car GetCarById(int id)
        {
            if (AllCars.Any(c => c.Id == id))
            {
                return AllCars.FirstOrDefault(c => c.Id == id);
            }

            throw new Exception($"Car with Id {id} does not exist");
        }

        public Car AddCar(Car car)
        {
            AllCars.Add(car);
            return car;
        }
    }
}
