using System.Collections.Generic;
using StudentManagement.Models;

namespace StudentManagement.Services.LocalDatabase
{
    public class MockSubjectData
    {
        public List<Subject> Subjects { get; private set; }

        public MockSubjectData()
        {
            AddSubject();
        }

        private void AddSubject()
        {
            Subjects = new List<Subject>
            {
                new Subject { Id = 3001, Name = "Toán" },
                new Subject { Id = 3002, Name = "Lý" },
                new Subject { Id = 3003, Name = "Hóa" },
                new Subject { Id = 3004, Name = "Sinh" },
                new Subject { Id = 3005, Name = "Sử" },
                new Subject { Id = 3006, Name = "Địa" },
                new Subject { Id = 3007, Name = "Văn" },
                new Subject { Id = 3008, Name = "Đạo Đức" },
                new Subject { Id = 3009, Name = "Thể Dục" },
            };
        }
    }
}
