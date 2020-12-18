using SQLite;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using System;
using System.Linq;
using Xamarin.Forms;

namespace StudentManagement.Models
{
    public class Student
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string FullName { get; set; }

        public int ClassId { get; set; }

        public string ClassName { get; set; }

        public int Gender { get; set; }

        public DateTime DoB { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        [Ignore]
        public string Avatar => Gender == 0 ? "student_girl.png" : "student_boy.png";

        [Ignore]
        public string GenderString => Gender == 0 ? "Nữ" : "Nam";

        [Ignore]
        public string GenderIcon => Gender == 0 ? Ionicons.Female : Ionicons.Male;

        [Ignore]
        public Color GenderColor => Gender == 0
            ? (Color)Application.Current.Resources["PinkColor"]
            : Color.Green;

        [Ignore]
        public string DoBstring => DoB.ToString("dd-MM-yyyy");


        /// <summary>
        /// Get score for 1 subject in 1 semester of 1 student
        /// </summary>
        [Ignore]
        public Score Score { get; set; }

        /// <summary>
        /// Average Score in Semester 1
        /// </summary>
        [Ignore]
        public float ScoreAvg1 { get; private set; }

        /// <summary>
        /// Average Score in Semester 2
        /// </summary>
        [Ignore]
        public float ScoreAvg2 { get; private set; }

        public void GetAvgScore(ISQLiteHelper db)
        {
            var scores = db.GetList<Score>(score => score.StudentId == this.Id).ToList();

            float totalScore1 = 0;
            float totalScore2 = 0;
            foreach (var score in scores)
            {
                if (score.Semester == 1) totalScore1 += score.ScoreAverage;
                else totalScore2 += score.ScoreAverage;
            }
            ScoreAvg1 = (float)Math.Round(totalScore1 / (scores.Count / 2), 1);
            ScoreAvg2 = (float)Math.Round(totalScore2 / (scores.Count / 2), 1);
        }

        public void GetScore(ISQLiteHelper db, int subjectId, int semester)
        {
            var score = db.Get<Score>(s =>
                s.StudentId == this.Id && s.SubjectId == subjectId && s.Semester == semester);
            if (score != null)
                this.Score = score;
        }
    }
}
