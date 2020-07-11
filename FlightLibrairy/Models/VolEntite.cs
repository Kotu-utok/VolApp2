using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FlightLibrairy.Models
{
    public class VolEntite
    {
        [Key]
        public string Id { get; set; }
        public string AeroportDepart { get; set; }
        public string AeroportArrivee { get; set; }
        public string Prix { get; set; }
        public string TotalTravelTime { get; set; }
        public DateTime DateDepart { get; set; }
        public DateTime DateArrivee { get; set; }
    }
}
