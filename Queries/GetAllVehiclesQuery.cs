using MediatR;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Queries
{
    public class GetAllVehiclesQuery: IRequest<List<VehicleView>>
    {
    }
}
