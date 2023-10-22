namespace Hostel_Manager.API.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Comment_Image { get; set; }
        public int Comment_Poster { get; set; }
        public DateTime Comment_Created { get; set; }

        public User Users { get; set; }
        public Image Images { get; set; }

    }
}
