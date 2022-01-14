using MediatR;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Queries
{
    public class GetAllUsersQuery: IRequest<List<User>>
    {
    }
}
