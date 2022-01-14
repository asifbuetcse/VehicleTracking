using MediatR;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Queries
{
    public class GetAllTrackingCurrentsQuery: IRequest<List<TrackingCurrentView>>
    {
    }
}
