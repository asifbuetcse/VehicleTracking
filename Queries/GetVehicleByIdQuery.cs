using MediatR;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Queries
{
    public class GetVehicleByIdQuery: IRequest<VehicleView>
    {
        public int Id { get; set; }
        public GetVehicleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
