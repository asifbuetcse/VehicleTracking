using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTracking.ViewModels
{
    public class TrackingHistoryView
    {
        public int TrackingId { get; set; }
        public DateTime Date { get; set; }
        public string HistoryForOneDay { get; set; }
        public virtual int VehicleId { get; set; }      
    }
}
