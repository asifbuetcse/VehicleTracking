using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTracking.DataModels
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [MaxLength(40)]
        public string LicenseNumber { get; set; }
        [Display(Name = "User")]
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<TrackingCurrent> VehicleTrackingCurrent { get; set; }
        public virtual ICollection<TrackingHistory> VehicleTrackingHistory { get; set; }
        public Vehicle()
        {
            VehicleTrackingCurrent = new HashSet<TrackingCurrent>();
            VehicleTrackingHistory = new HashSet<TrackingHistory>();
        }
    }
}
