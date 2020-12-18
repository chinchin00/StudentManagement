using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudentManagement.Interfaces;
using StudentManagement.Models;

namespace StudentManagement.Services.LocalDatabase
{
    public class MockData
    {
        private ISQLiteHelper _db;

        public MockData(ISQLiteHelper sqLite)
        {
            _db = sqLite;
        }

        public void InitMockData()
        {
            InitStudent();
            InitClass();
            InitSubject();
            InitScore();
            InitSetting();
        }

        private void InitClass()
        {
            // Insert or Replace Class
            MockClassData mockClassData = new MockClassData();
            _db.InsertAll(mockClassData.Classes);
        }

        private void InitStudent()
        {
            // Insert or Replace student
            MockStudentData mockStudentData = new MockStudentData();
            _db.InsertAll(mockStudentData.Students);
        }

        private void InitSubject()
        {
            // Insert or Replace Subject
            MockSubjectData mockSubjectData = new MockSubjectData();
            _db.InsertAll(mockSubjectData.Subjects);
        }

        private void InitScore()
        {
            // Insert or Replace Score
            MockScoreData mockScoreData = new MockScoreData();
            _db.InsertAll(mockScoreData.Scores);
        }

        private void InitSetting()
        {
            _db.Insert(new Setting()
            {
                Id = 1,
                IsInitData = true,
                MinStudentAge = 15,
                MaxStudentAge = 20,
                MaxStudentPerClass = 40,
                SubjectPassScore = 5.0f
            });
        }
    }
}
