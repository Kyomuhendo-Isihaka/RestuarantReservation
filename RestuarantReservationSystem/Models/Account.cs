﻿using System.ComponentModel.DataAnnotations;

namespace RestuarantReservationSystem.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public int Phone { get; set; }


    }
}
