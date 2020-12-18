using StudentManagement.Interfaces;
using StudentManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Helpers
{
    public class UserHelper
    {
        private List<User> _users;
        private List<Account> _account;
        private static UserHelper _instance;
        public static UserHelper Instance => _instance ?? (_instance = new UserHelper());

        public UserHelper()
        {
            InitData();
        }

        private User GetUserInfo(Account accInfo)
        {
            if (accInfo == null) return null;
            return new User()
            {
                Id = accInfo.Id,
                Name = accInfo.Name,
                Role = accInfo.Role,
                Avatar = accInfo.Avatar,
                ClassId = accInfo.ClassId,
                UserName = accInfo.UserName,
                Password = accInfo.Password
            };
        }

        public bool Login(ISQLiteHelper db, string username, string password)
        {
            //var user = _users.FirstOrDefault(u => u.UserName.ToLower().Equals(username.Trim().ToLower())
            //                                      && u.Password.Equals(password));

            User user;// = new User();
            var account = db.GetList<Account>(a => a.Id >= 0);


            if (account == null) return false;
            if (account.Count() == 0)
            {
                db.InsertAll(_account);

                var accInfo = _account.FirstOrDefault(u => u.UserName.ToLower().Equals(username.Trim().ToLower())
                                                  && u.Password.Equals(password));

                user = GetUserInfo(accInfo);
            }
            else
            {
                var accInfo = account.FirstOrDefault(u => u.UserName.ToLower().Equals(username.Trim().ToLower())
                                                           && u.Password.Equals(password));

                user = GetUserInfo(accInfo);
            }

            if (user == null)
                return false;

            db.DeleteAll<User>();
            db.Insert(user);

            return true;
        }

        public bool ConfirmPassword(string name, string password)
        {
            var user = _users.FirstOrDefault(u => u.Name.ToLower().Equals(name.Trim().ToLower()));

            if (user == null)
                return false;

            if (user.Password.Equals(password))
                return true;

            return false;
        }

        public void Logout(ISQLiteHelper db)
        {
            db.DeleteAll<User>();
        }


        private void InitData()
        {
            _users = new List<User>
            {
                new User
                {
                    Id = 10336,
                    Name = "Trần Quốc Đạt",
                    Avatar = "student_boy.png",
                    Role = RoleManager.StudentRole,
                    UserName = "dattq@gmail.com",
                    Password = "dat123",
                    ClassId = 2009,
                },
                new User
                {
                    Id = 10337,
                    Name = "Trần Nghĩa",
                    Avatar = "student_boy.png",
                    Role = RoleManager.StudentRole,
                    UserName = "nghiat@gmail.com",
                    Password = "nghia123",
                    ClassId = 2001
                },
                new User
                {
                    Id = 3,
                    Name = "Nguyễn Thị Trinh",
                    Avatar = "teacher_1.png",
                    Role = RoleManager.TeacherRole,
                    UserName = "trinhnt@gmail.com",
                    Password = "trinh123",
                    ClassId = 2005
                },
                new User
                {
                    Id = 2,
                    Name = "Hồ Thị Trang",
                    Avatar = "teacher_1.png",
                    Role = RoleManager.TeacherRole,
                    UserName = "tranght@gmail.com",
                    Password = "trang123",
                    ClassId = 2006
                },
                new User
                {
                    Id = 1,
                    Name = "Hà Ngủ Tân",
                    Avatar = "teacher_5.png",
                    Role = RoleManager.PrincipalRole,
                    UserName = "tannt@gmail.com",
                    Password = "tan123"
                },
                new User
                {
                    Id = 0,
                    Name = "Admin",
                    Avatar = "teacher_5.png",
                    Role = RoleManager.AdminRole,
                    UserName = "admin@gmail.com",
                    Password = "admin123"
                },
            };

            _account = new List<Account>
            {
                new Account
                { 
                    Id = 10336,
                    Name = "Trần Quốc Đạt",
                    Avatar = "student_boy.png",
                    Role = RoleManager.StudentRole,
                    UserName = "dattq@gmail.com",
                    Password = "dat123",
                    ClassId = 2009,
                },
                new Account
                {
                    Id = 10337,
                    Name = "Trần Nghĩa",
                    Avatar = "student_boy.png",
                    Role = RoleManager.StudentRole,
                    UserName = "nghiat@gmail.com",
                    Password = "nghia123",
                    ClassId = 2001
                },
                new Account
                {
                    Id = 3,
                    Name = "Nguyễn Thị Trinh",
                    Avatar = "teacher_1.png",
                    Role = RoleManager.TeacherRole,
                    UserName = "trinhnt@gmail.com",
                    Password = "trinh123",
                    ClassId = 2005
                },
                new Account
                {
                    Id = 2,
                    Name = "Hồ Thị Trang",
                    Avatar = "teacher_1.png",
                    Role = RoleManager.TeacherRole,
                    UserName = "tranght@gmail.com",
                    Password = "trang123",
                    ClassId = 2006
                },
                new Account
                {
                    Id = 1,
                    Name = "Hà Ngủ Tân",
                    Avatar = "teacher_5.png",
                    Role = RoleManager.PrincipalRole,
                    UserName = "tannt@gmail.com",
                    Password = "tan123"
                },
                new Account
                {
                    Id = 0,
                    Name = "Admin",
                    Avatar = "teacher_5.png",
                    Role = RoleManager.AdminRole,
                    UserName = "admin@gmail.com",
                    Password = "admin123"
                },
            };
        }
    }
}
