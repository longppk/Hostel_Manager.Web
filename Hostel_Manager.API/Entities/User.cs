namespace Hostel_Manager.API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<Hostel> Hostels { get; set; }
        public Comment Comments { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Role> Roles { get; set; }



    }
}
