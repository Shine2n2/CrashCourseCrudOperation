using DbAndRepo;
using Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public CarDTO GetCar(int id)
        {
            var car = _carRepository.GetCarById(id);
            return new CarDTO
            {
                Amount = car.Amount,
                Color = car.Color,
                EngineType = car.EngineType,
                Id = car.Id,
                Name = car.Name,
            };
        }

        public List<CarDTO> GetCars()
        {
            var cars = _carRepository.GetAllCars();
            var result = new List<CarDTO>();
            foreach (var car in cars)
            {
                result.Add(new CarDTO
                {
                    Amount = car.Amount,
                    Color = car.Color,
                    EngineType = car.EngineType,
                    Id = car.Id,
                    Name = car.Name,
                });
            }

            return result;
        }

        public CarDTO AddCar(CarDTO viewModel)
        {
            var car = new Car
            {
                Amount = viewModel.Amount,
                EngineType = viewModel.EngineType,
                Name = viewModel.Name,
                Id = viewModel.Id,
                Color = viewModel.Color,
                OrganizationId = viewModel.OrganizationId
            };

            _carRepository.AddCar(car);
            return viewModel;
        }
    }
}
