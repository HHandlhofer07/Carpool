using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Shared
{
    public class RideRequest
    {
        public int Id { get; set; }
        public int DriverProfileId { get; set; }
        public int MitfahrerId { get; set; }
        public bool? Accepted { get; set; } 
        public string Kommentar { get; set; }
    }
}
