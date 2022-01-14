using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTracking.ViewModels
{
    public class VehicleView
    {
        [Key]
        [MaxLength(40)]
        public string licenseNumber { get; set; }
    }
}
