namespace TransportSystem.DTOs
{
    public class RideHistoryDto
    {
        public DateTime ReadingTime { get; set; }
        public int TransportUnitId { get; set; }
        public string RouteName { get; set; }
    }
}
