using AutoMapper;

namespace VehicleTracking.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<DataModels.User, ViewModels.UserView>();
            CreateMap<DataModels.Vehicle, ViewModels.VehicleView>();
            CreateMap<DataModels.TrackingCurrent, ViewModels.TrackingCurrentView>();
            CreateMap<DataModels.TrackingHistory, ViewModels.TrackingHistoryView>();
        }
    }
}
