using MediatR;
using VehicleTracking.DataModels;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Commands
{
    public class CreateTrackingCurrentCommand : IRequest<TrackingCurrentView>
    {
        public TrackingCurrent TrackingCurrent { get; set; }
        public CreateTrackingCurrentCommand(TrackingCurrent trackingCurrent)
        {
            TrackingCurrent = trackingCurrent;
        }
    }
}
