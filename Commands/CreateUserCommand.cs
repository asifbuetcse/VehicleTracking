using MediatR;
using VehicleTracking.DataModels;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Commands
{
    public class CreateUserCommand : IRequest<UserView>
    {
        public User User { get; set; }
        public CreateUserCommand(User user)
        {
            User = user;
        }
    }
}
