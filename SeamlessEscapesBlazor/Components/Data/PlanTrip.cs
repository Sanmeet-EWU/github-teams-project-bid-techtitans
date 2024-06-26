using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace SeamlessEscapesBlazor.Models
{
    public class PlanTrip
    {
        [Key]
        public int PlanTripId { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        [Required]
        public DateTime ArrivalDate { get; set; }

        [Required, StringLength(100)]
        public string SourceLocation { get; set; }

        [Required, StringLength(100)]
        public string Destination { get; set; }

        [Required]
        public int NumberOfPeople { get; set; }

        [Required]
        public List<Interest> Interests { get; set; } = new List<Interest>();

        public List<Itinerary> Itineraries { get; set; } = new List<Itinerary>();
    }

}


