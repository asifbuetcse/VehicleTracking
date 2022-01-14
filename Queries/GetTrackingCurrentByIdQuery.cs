using MediatR;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Queries
{
    public class GetTrackingCurrentByIdQuery: IRequest<TrackingCurrentView>
    {
        public int Id { get; set; }
        public GetTrackingCurrentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
