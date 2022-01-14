using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTracking.DataModels
{
    public class TrackingCurrent
    {
        [Key]
        public int TrackingId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [MaxLength(10)]
        public string Longitude { get; set; }
        [MaxLength(10)]
        public string Latitude { get; set; }
        [Display(Name = "Vehicle")]
        public virtual int VehicleId { get; set; }
        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }

    }
}
