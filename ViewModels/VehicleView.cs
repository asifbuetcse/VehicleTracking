﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTracking.ViewModels
{
    public class VehicleView
    {
        [Key]
        [MaxLength(40)]
        private string licenseNumber { get; set; }
        public int UserId { get; set; }
    }
}
