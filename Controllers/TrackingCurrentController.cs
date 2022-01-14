using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using VehicleTracking.Commands;
using VehicleTracking.DataModels;
using VehicleTracking.Enums;
using VehicleTracking.Queries;

namespace VehicleTracking.Controllers
{
    public class TrackingCurrentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TrackingCurrentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public string Index()
        {
            return "";
        }
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllTrackingCurrents()
        {
            var query = new GetAllTrackingCurrentsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        public async Task<IActionResult> GetTrackingCurrentById(int Id)
        {
            var query = new GetTrackingCurrentByIdQuery(Id);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> CreateTrackingCurrent(DateTime dateTime, string longitude, string latitude, int vehicleId)
        {
            var trackingCurrent = new TrackingCurrent
            {
                DateTime = dateTime,
                Longitude = longitude,
                Latitude = latitude,
                VehicleId = vehicleId
            };
            var query = new CreateTrackingCurrentCommand(trackingCurrent);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
