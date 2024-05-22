using Microsoft.AspNetCore.Mvc;
using VehicleRentalProject.Repositories.Infrastructure;

namespace VehicleRentalProject.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehiclesController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public IActionResult Index()
        {
            var vehicles = _vehicleRepository.GetVehicles();
            return View();
        }
    }
}
