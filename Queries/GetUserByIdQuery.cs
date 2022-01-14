using MediatR;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Queries
{
    public class GetUserByIdQuery: IRequest<UserView>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
