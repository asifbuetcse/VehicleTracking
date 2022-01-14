using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using VehicleTracking.Queries;

namespace VehicleTracking.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public string Index()
        {
            return "success";
        }
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
