namespace Hostel_Manager.API.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Blog_Description { get; set; }
        public int Blog_Image { get; set; }
        public DateTime Blog_Created { get; set; }
        public int Blog_Poster { get; set; }

        public User Users { get; set; }
        public Image Images { get; set; }
    }
}
