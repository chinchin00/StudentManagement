using SQLite;

namespace StudentManagement.Models
{
    public class Account
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public string Avatar { get; set; }

        public int ClassId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ClassName { get; set; }

        public string SchoolYear { get; set; }

    }
}
