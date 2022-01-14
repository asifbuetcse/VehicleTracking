﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTracking.ViewModels
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [MaxLength(40)]
        private string licenseNumber { get; set; }

        public int UserId { get; set; }

      
    }
}
