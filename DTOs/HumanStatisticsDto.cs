namespace TransportSystem.DTOs
{
    public class HumanStatisticsDto
    {
        public Guid HumanGuid { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public DateTime? RegistredAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
    }
}
