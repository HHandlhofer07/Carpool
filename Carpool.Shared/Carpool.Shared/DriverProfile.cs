using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Shared
{
    public class DriverProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Route { get; set; }
        public decimal Preis { get; set; }
        public int Plaetze { get; set; }
        public string AutoBildUrl { get; set; }
        public List<TimeSlot> Zeitfenster { get; set; }
        public string Parkbereich { get; set; }
    }

    public class TimeSlot
    {
        public int Id { get; set; }       // <- EF Core Primary Key
        public DayOfWeek Wochentag { get; set; }
        public TimeSpan Startzeit { get; set; }
        public TimeSpan Endzeit { get; set; }
        public bool Hinreise { get; set; }
        public int DriverProfileId { get; set; }  // Fremdschlüssel
        public DriverProfile DriverProfile { get; set; }
    }
}

