namespace Carpool.Shared.Models
{
    public class DriverProfile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Route { get; set; }
        public decimal Price { get; set; }
        public int Seats { get; set; }
        public string CarImageUrl { get; set; }
        public string ParkingArea { get; set; }
    }
}

