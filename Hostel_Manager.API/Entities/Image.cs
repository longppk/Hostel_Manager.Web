namespace Hostel_Manager.API.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string URL_Images { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Hostel> Hostels { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
