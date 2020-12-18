using SQLite;

namespace StudentManagement.Models
{
    public class Subject
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        [Ignore]
        public float ScoreAvg { get; set; }

        [Ignore]
        public int Semester { get; set; }
    }
}
