namespace TransportSystem.DTOs
{
    public class RideRegisterDto
    {
        public DateTime ReadingTime { get; set; }

        public int UserId { get; set; }

        public int TransportUnitId { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
