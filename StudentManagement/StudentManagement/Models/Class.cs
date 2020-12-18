using SQLite;
using StudentManagement.Interfaces;
using System.Linq;

namespace StudentManagement.Models
{
    public class Class
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public string SchoolYear { get; set; }

        [Ignore]
        public int Students { get; private set; }

        [Ignore]
        public int Boys { get; private set; }

        [Ignore]
        public int Girls { get; private set; }

        [Ignore]
        public int MaxStudents { get; private set; }

        [Ignore]
        public bool IsFull { get; private set; }


        [Ignore]
        public int Passes { get; private set; }

        [Ignore]
        public float PassesPercents { get; private set; }

        public void CountStudent(ISQLiteHelper db)
        {
            var students = db.GetList<Student>(s => s.ClassId == Id);
            Students = students?.Count() ?? 0;
            Boys = students?.Count(s => s.Gender == 1) ?? 0;
            Girls = Students - Boys;

            MaxStudents = db.GetSetting().MaxStudentPerClass;
            IsFull = Students >= MaxStudents;
        }

        public void GetReportBySubject(ISQLiteHelper db, int subjectId, int semester)
        {
            var students = db.GetList<Student>(s => s.ClassId == Id);
            var settings = db.GetSetting();
            Passes = 0;

            foreach (var student in students)
            {
                student.GetScore(db, subjectId, semester);
                if (student.Score.ScoreAverage >= settings.SubjectPassScore)
                {
                    this.Passes++;
                }
            }
            PassesPercents = (float)Passes / Students * 100;
        }

        public void GetReportBySemester(ISQLiteHelper db, int semester)
        {
            var students = db.GetList<Student>(s => s.ClassId == Id);
            var settings = db.GetSetting();
            Passes = 0;

            foreach (var student in students)
            {
                student.GetAvgScore(db);
                if (settings.SubjectPassScore <= (semester == 1 ? student.ScoreAvg1 : student.ScoreAvg2))
                {
                    this.Passes++;
                }
            }
            PassesPercents = (float)Passes / Students * 100;
        }
    }
}
