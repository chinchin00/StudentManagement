using SQLite;

namespace StudentManagement.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Avatar { get; set; }
        [Ignore]
        public string Password { get; set; }
        [Ignore]
        public string UserName { get; set; }
    }
}
