using System.ComponentModel.DataAnnotations;
using VehicleTracking.Enums;

namespace VehicleTracking.DataModels
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        [MaxLength(40)]
        public string Email { get; set; }
        [MaxLength(80)]
        public string HashedPassword { get; set; }
        public Role UserRole { get; set; }
        public virtual ICollection<Vehicle> UserVehicles { get; set; }
        public User()
        {
            UserVehicles = new HashSet<Vehicle>();
        }
    }
}
