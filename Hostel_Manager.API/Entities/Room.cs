namespace Hostel_Manager.API.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int Hostel { get; set; }
        public string Room_description { get; set; }
        public int Number { get; set; }
        public float Electric { get; set; }
        public float Water { get; set; }
        public float Price { get; set; }
        public string Note { get; set; }

        public Hostel Hostels { get; set; }

    }
}
