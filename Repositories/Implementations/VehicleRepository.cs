using VehicleTracking.DataModels;
using VehicleTracking.Repositories.Interfaces;

namespace VehicleTracking.Repositories.Implementations
{
    public class VehicleRepository: Repository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(Context context) : base(context)
        { }
    }
}
