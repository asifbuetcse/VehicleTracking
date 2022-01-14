using AutoMapper;

namespace VehicleTracking.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<DataModels.User, ViewModels.User>();
            CreateMap<DataModels.Vehicle, ViewModels.Vehicle>();
            CreateMap<DataModels.TrackingCurrent, ViewModels.TrackingCurrent>();
            CreateMap<DataModels.TrackingHistory, ViewModels.TrackingHistory>();
        }
    }
}
