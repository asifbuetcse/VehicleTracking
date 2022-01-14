using System.ComponentModel.DataAnnotations;

namespace VehicleTracking.ViewModels
{
    public class VehicleView
    {
        [Key]
        [MaxLength(40)]
        public string licenseNumber { get; set; }
    }
}
