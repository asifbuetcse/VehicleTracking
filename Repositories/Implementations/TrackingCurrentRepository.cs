using VehicleTracking.DataModels;
using VehicleTracking.Repositories.Interfaces;

namespace VehicleTracking.Repositories.Implementations
{
    public class TrackingCurrentRepository: Repository<TrackingCurrent>, ITrackingCurrentRepository
    {
        public TrackingCurrentRepository(Context context) : base(context)
        { }
    }
}
