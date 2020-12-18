using SQLite;

namespace StudentManagement.Models
{
    public class Score
    {
        [PrimaryKey]
        public int Id { get; set; }
        
        public int StudentId { get; set; }
        
        public int SubjectId { get; set; }
        
        public int Semester { get; set; }

        public float Score15M { get; set; }

        public float Score45M { get; set; }

        public float ScoreFinal { get; set; }

        [Ignore]
        public float ScoreAverage => (Score15M + Score45M * 2 + ScoreFinal * 3) / 6;
    }
}
