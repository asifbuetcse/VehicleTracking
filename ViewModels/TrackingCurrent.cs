﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTracking.ViewModels
{
    public class TrackingCurrent
    {

        public int TrackingId { get; set; }
        public DateTime DateTime { get; set; }    
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}