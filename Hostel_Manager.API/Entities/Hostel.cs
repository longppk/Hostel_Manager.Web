namespace Hostel_Manager.API.Entities
{
    public class Hostel
    {
        public int Id { get; set; }
        public string Hostel_name { get; set; }
        public int Hostel_address { get; set; }
        public int Owner { get; set; }
        public string Hostel_discription { get; set; }
        public string Parking { get; set; }
        public int Available { get; set; }
        public string Image_Hostel { get; set; }
        public DateTime Create { get; set; }
        public string Hostel_phone { get; set; }

        public Address Addresses { get; set; }
        public User Users { get; set; }
        public List<Room> Rooms { get; set; }


    }
}
