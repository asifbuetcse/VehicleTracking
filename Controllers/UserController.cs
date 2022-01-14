using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using VehicleTracking.Commands;
using VehicleTracking.DataModels;
using VehicleTracking.Enums;
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

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        public async Task<IActionResult> GetUserById(int Id)
        {
            var query = new GetUserByIdQuery(Id);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> CreateUser(string UserName, string Email, string Password)
        {
            var user = new User
            {
                UserName = UserName,
                Email = Email,
                HashedPassword = Password,
                UserRole = Role.Admin
            };
            var query = new CreateUserCommand(user);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
