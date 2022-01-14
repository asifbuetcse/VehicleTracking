using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTracking.DataModels
{
    public class TrackingHistory
    {
        [Key]
        public int TrackingId { get; set; }
        public DateTime Date { get; set; }
        public string HistoryForOneDay { get; set; }
        [Display(Name = "Vehicle")]
        public virtual int VehicleId { get; set; }
        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }       
    }
}
