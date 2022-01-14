using MediatR;
using Microsoft.AspNetCore.Mvc;
using VehicleTracking.Commands;
using VehicleTracking.DataModels;
using VehicleTracking.Queries;

namespace VehicleTracking.Controllers
{
    public class VehicleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllVehicles()
        {
            var query = new GetAllVehiclesQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        public async Task<IActionResult> GetVehicleById(int Id)
        {
            var query = new GetVehicleByIdQuery(Id);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> CreateVehicle(string LicenseNumber, int UserId)
        {
            var vehicle = new Vehicle
            {
                LicenseNumber = LicenseNumber,
                UserId = UserId
            };
            var query = new CreateVehicleCommand(vehicle);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
