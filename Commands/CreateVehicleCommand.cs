using MediatR;
using VehicleTracking.DataModels;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Commands
{
    public class CreateVehicleCommand : IRequest<VehicleView>
    {
        public Vehicle Vehicle { get; set; }
        public CreateVehicleCommand(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
    }
}
