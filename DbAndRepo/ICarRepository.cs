using Entities;
using System.Collections.Generic;

namespace DbAndRepo
{
    public interface ICarRepository
    {
        Car AddCar(Car car);
        List<Car> GetAllCars();
        Car GetCarById(int id);
    }
}