using System.ComponentModel.DataAnnotations;
using VehicleTracking.Enums;

namespace VehicleTracking.ViewModels
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }

    }
}
