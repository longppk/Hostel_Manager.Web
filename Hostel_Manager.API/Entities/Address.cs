namespace Hostel_Manager.API.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Ward { get; set; }
        public string? Street { get; set; }
        public string? Detail { get; set; }

        public Hostel Hostles { get; set; }
    }
}
