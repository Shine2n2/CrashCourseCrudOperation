using Entities.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface ICarService
    {
        CarDTO AddCar(CarDTO viewModel);
        CarDTO GetCar(int id);
        List<CarDTO> GetCars();
    }
}