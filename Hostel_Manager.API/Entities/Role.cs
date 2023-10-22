namespace Hostel_Manager.API.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public Roles role { get; set; }

        public enum Roles
        {
            Admin, User, Business
        }
        public List<User> users { get; set; }
    }
}
