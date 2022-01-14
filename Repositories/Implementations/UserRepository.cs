using VehicleTracking.DataModels;
using VehicleTracking.Repositories.Interfaces;

namespace VehicleTracking.Repositories.Implementations
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        { }
    }
}
