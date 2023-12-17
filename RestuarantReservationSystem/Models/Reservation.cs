using System.ComponentModel.DataAnnotations;

namespace RestuarantReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        public DateOnly DateCreated { get; set; }
    }
}
