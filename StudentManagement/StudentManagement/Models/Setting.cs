using SQLite;

namespace StudentManagement.Models
{
    public class Setting
    {
        [PrimaryKey]
        public int Id { get; set; }

        public int MaxStudentPerClass { get; set; }

        public int MaxStudentAge { get; set; }

        public int MinStudentAge { get; set; }

        public float SubjectPassScore { get; set; }

        public bool IsInitData { get; set; }
    }
}
