using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace StudentManagement.Services.LocalDatabase
{
    public class MockStudentData
    {
        public List<Student> Students { get; private set; }

        public MockStudentData()
        {
            AddStudent();
        }

        private void AddStudent()
        {
            Students = new List<Student>
            {
                new Student()
                {
                    Id = 10001,
                    FullName = "Phạm Thành An",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("21/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamthanhan@gmail.com"
                },
                new Student()
                {
                    Id = 10002,
                    FullName = "Lại Văn Cử",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("16/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "laivancu@gmail.com"
                },
                new Student()
                {
                    Id = 10003,
                    FullName = "Nguyễn Như Quỳnh",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyennhuquynh@gmail.com"
                },
                new Student()
                {
                    Id = 10004,
                    FullName = "Nguyễn Đoàn Thiên Thương",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyendoanthienthuong@gmail.com"
                },
                new Student()
                {
                    Id = 10005,
                    FullName = "Lục Kim Trân",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("06/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "luckimtran@gmail.com"
                },
                new Student()
                {
                    Id = 10006,
                    FullName = "Lê Tiến Tùng",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letientung@gmail.com"
                },
                new Student()
                {
                    Id = 10007,
                    FullName = "Phạm Anh Thiện Tùng",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("07/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamanhthientung@gmail.com"
                },
                new Student()
                {
                    Id = 10008,
                    FullName = "Trương Thảo Vy",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("28/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongthaovy@gmail.com"
                },
                new Student()
                {
                    Id = 10009,
                    FullName = "Phạm Lam Khê",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("10/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamlamkhe@gmail.com"
                },
                new Student()
                {
                    Id = 10010,
                    FullName = "Trương Duy Nhất",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongduynhat@gmail.com"
                },
                new Student()
                {
                    Id = 10011,
                    FullName = "Nguyễn Anh Đức",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("05/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenanhduc@gmail.com"
                },
                new Student()
                {
                    Id = 10012,
                    FullName = "Lê Ngọc Huy",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lengochuy@gmail.com"
                },
                new Student()
                {
                    Id = 10013,
                    FullName = "Đào Phương Nam",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "daophuongnam@gmail.com"
                },
                new Student()
                {
                    Id = 10014,
                    FullName = "Lê Trần Anh Thư",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("21/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letrananhthu@gmail.com"
                },
                new Student()
                {
                    Id = 10015,
                    FullName = "Phạm Xuân An",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamxuanan@gmail.com"
                },
                new Student()
                {
                    Id = 10016,
                    FullName = "Nguyễn Phong đại",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("10/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenphongdai@gmail.com"
                },
                new Student()
                {
                    Id = 10017,
                    FullName = "Lâm Khắc Duy",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lamkhacduy@gmail.com"
                },
                new Student()
                {
                    Id = 10018,
                    FullName = "Nguyễn Hồng Hà",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("13/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhongha@gmail.com"
                },
                new Student()
                {
                    Id = 10019,
                    FullName = "Trần Thị Ánh Linh",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("19/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranthianhlinh@gmail.com"
                },
                new Student()
                {
                    Id = 10020,
                    FullName = "Lê Thị Huyền Thư",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("07/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethihuyenthu@gmail.com"
                },
                new Student()
                {
                    Id = 10021,
                    FullName = "Hoàng Văn Tú",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("17/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hoangvantu@gmail.com"
                },
                new Student()
                {
                    Id = 10022,
                    FullName = "Trần Nguyễn Quốc Tuấn",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trannguyenquoctuan@gmail.com"
                },
                new Student()
                {
                    Id = 10023,
                    FullName = "Nguyễn Thanh Tùng",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("13/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhtung@gmail.com"
                },
                new Student()
                {
                    Id = 10024,
                    FullName = "Nguyễn Phan Bách",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("01/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenphanbach@gmail.com"
                },
                new Student()
                {
                    Id = 10025,
                    FullName = "Nguyễn Thị Hồng Phúc",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("09/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthihongphuc@gmail.com"
                },
                new Student()
                {
                    Id = 10026,
                    FullName = "Nguyễn Khắc Minh Quân",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenkhacminhquan@gmail.com"
                },
                new Student()
                {
                    Id = 10027,
                    FullName = "Trần Kim Sen",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("10/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trankimsen@gmail.com"
                },
                new Student()
                {
                    Id = 10028,
                    FullName = "Đoàn Công Thành",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("11/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "doancongthanh@gmail.com"
                },
                new Student()
                {
                    Id = 10029,
                    FullName = "Lê Bá Trực",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lebatruc@gmail.com"
                },
                new Student()
                {
                    Id = 10030,
                    FullName = "Thiều Thái An",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "thieuthaian@gmail.com"
                },
                new Student()
                {
                    Id = 10031,
                    FullName = "Nguyễn Ngọc Thế Bão",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("02/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenngocthebao@gmail.com"
                },
                new Student()
                {
                    Id = 10032,
                    FullName = "Nguyễn Đông Hà",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("18/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyendongha@gmail.com"
                },
                new Student()
                {
                    Id = 10033,
                    FullName = "Nguyễn Vĩnh Hải",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenvinhhai@gmail.com"
                },
                new Student()
                {
                    Id = 10034,
                    FullName = "Nguyễn Ngọc Hòa",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("12/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenngochoa@gmail.com"
                },
                new Student()
                {
                    Id = 10035,
                    FullName = "Hà Vũ Minh Ngọc",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 0,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("11/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "havuminhngoc@gmail.com"
                },
                new Student()
                {
                    Id = 10036,
                    FullName = "Hồ Thiện Phúc",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("20/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hothienphuc@gmail.com"
                },
                new Student()
                {
                    Id = 10037,
                    FullName = "Hà Huy Thắng",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hahuythang@gmail.com"
                },
                new Student()
                {
                    Id = 10038,
                    FullName = "Nguyễn Thanh Thảo",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhthao@gmail.com"
                },
                new Student()
                {
                    Id = 10039,
                    FullName = "Lê Phan Vũ Thuận",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lephanvuthuan@gmail.com"
                },
                new Student()
                {
                    Id = 10040,
                    FullName = "Nguyễn Huy Thuật",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("10/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhuythuat@gmail.com"
                },
                new Student()
                {
                    Id = 10041,
                    FullName = "Nguyễn Thanh Tú",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("01/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhtu@gmail.com"
                },
                new Student()
                {
                    Id = 10042,
                    FullName = "Phạm Quang Tuấn",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("28/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamquangtuan@gmail.com"
                },
                new Student()
                {
                    Id = 10043,
                    FullName = "Trần Quốc Tuấn",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranquoctuan@gmail.com"
                },
                new Student()
                {
                    Id = 10044,
                    FullName = "Lê Lý Thuý Vi",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("28/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lelythuyvi@gmail.com"
                },
                new Student()
                {
                    Id = 10045,
                    FullName = "Nguyễn Hải Huy",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhaihuy@gmail.com"
                },
                new Student()
                {
                    Id = 10046,
                    FullName = "Nguyễn Mạnh Kha",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("20/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenmanhkha@gmail.com"
                },
                new Student()
                {
                    Id = 10047,
                    FullName = "Huỳnh Minh Khoa",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("28/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "huynhminhkhoa@gmail.com"
                },
                new Student()
                {
                    Id = 10048,
                    FullName = "Bùi Thị Thùy Trang",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("11/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "buithithuytrang@gmail.com"
                },
                new Student()
                {
                    Id = 10049,
                    FullName = "Huỳnh Xuân An",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("09/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "huynhxuanan@gmail.com"
                },
                new Student()
                {
                    Id = 10050,
                    FullName = "Điểu Minh Thuật",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dieuminhthuat@gmail.com"
                },
                new Student()
                {
                    Id = 10051,
                    FullName = "Đàm Quốc Việt",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("01/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "damquocviet@gmail.com"
                },
                new Student()
                {
                    Id = 10052,
                    FullName = "Nguyễn Thị Thịnh An",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("03/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthithinhan@gmail.com"
                },
                new Student()
                {
                    Id = 10053,
                    FullName = "Phạm Thuận An",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("19/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamthuanan@gmail.com"
                },
                new Student()
                {
                    Id = 10054,
                    FullName = "Nguyễn Tuấn Anh",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyentuananh@gmail.com"
                },
                new Student()
                {
                    Id = 10055,
                    FullName = "Phan Văn Anh",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("23/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phanvananh@gmail.com"
                },
                new Student()
                {
                    Id = 10056,
                    FullName = "Trần Tiến Anh",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trantienanh@gmail.com"
                },
                new Student()
                {
                    Id = 10057,
                    FullName = "Trương Nguyễn Phương Anh",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongnguyenphuonganh@gmail.com"
                },
                new Student()
                {
                    Id = 10058,
                    FullName = "Nguyễn Hữu Dương",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("07/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhuuduong@gmail.com"
                },
                new Student()
                {
                    Id = 10059,
                    FullName = "Nguyễn Hoàng Duy",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("19/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhoangduy@gmail.com"
                },
                new Student()
                {
                    Id = 10060,
                    FullName = "Phạm Nhật Duy",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamnhatduy@gmail.com"
                },
                new Student()
                {
                    Id = 10061,
                    FullName = "Trần Trường Giang",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("14/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trantruonggiang@gmail.com"
                },
                new Student()
                {
                    Id = 10062,
                    FullName = "Nay H'hông",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("30/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nayh'hong@gmail.com"
                },
                new Student()
                {
                    Id = 10063,
                    FullName = "Nguyễn Mạnh Hào",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenmanhhao@gmail.com"
                },
                new Student()
                {
                    Id = 10064,
                    FullName = "Vũ Văn Hiến",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("11/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vuvanhien@gmail.com"
                },
                new Student()
                {
                    Id = 10065,
                    FullName = "Đồng Phước Hiệp",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("24/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dongphuochiep@gmail.com"
                },
                new Student()
                {
                    Id = 10066,
                    FullName = "Hồ Thị Hoài",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("20/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hothihoai@gmail.com"
                },
                new Student()
                {
                    Id = 10067,
                    FullName = "Nguyễn Văn Hoài",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("23/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenvanhoai@gmail.com"
                },
                new Student()
                {
                    Id = 10068,
                    FullName = "Nguyễn Trần Duy Khương",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyentranduykhuong@gmail.com"
                },
                new Student()
                {
                    Id = 10069,
                    FullName = "Trần Lê Ngọc Kim",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 0,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("24/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranlengockim@gmail.com"
                },
                new Student()
                {
                    Id = 10070,
                    FullName = "Lê Bảo Lâm",
                    ClassId = 2002,
                    ClassName = "10A2",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("29/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lebaolam@gmail.com"
                },
                new Student()
                {
                    Id = 10071,
                    FullName = "Lê Thị Ngọc Lan",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethingoclan@gmail.com"
                },
                new Student()
                {
                    Id = 10072,
                    FullName = "Nguyễn Ngọc Anh Linh",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("06/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenngocanhlinh@gmail.com"
                },
                new Student()
                {
                    Id = 10073,
                    FullName = "Phạm Thị Hồng Loan",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("10/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamthihongloan@gmail.com"
                },
                new Student()
                {
                    Id = 10074,
                    FullName = "Trần Văn Lực",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("09/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranvanluc@gmail.com"
                },
                new Student()
                {
                    Id = 10075,
                    FullName = "Bùi Thị Ngọc Mai",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "buithingocmai@gmail.com"
                },
                new Student()
                {
                    Id = 10076,
                    FullName = "Nguyễn Đức Mạnh",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenducmanh@gmail.com"
                },
                new Student()
                {
                    Id = 10077,
                    FullName = "Nguyễn Văn Minh",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenvanminh@gmail.com"
                },
                new Student()
                {
                    Id = 10078,
                    FullName = "Trần Thị Ngọc Minh",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("16/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranthingocminh@gmail.com"
                },
                new Student()
                {
                    Id = 10079,
                    FullName = "Bùi Ngọc Nam",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("19/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "buingocnam@gmail.com"
                },
                new Student()
                {
                    Id = 10080,
                    FullName = "Nguyễn Hữu Nghị",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("20/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhuunghi@gmail.com"
                },
                new Student()
                {
                    Id = 10081,
                    FullName = "Trần Nghĩa",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("20/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trannghia@gmail.com"
                },
                new Student()
                {
                    Id = 10082,
                    FullName = "Trần Trọng Nghĩa",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("28/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trantrongnghia@gmail.com"
                },
                new Student()
                {
                    Id = 10083,
                    FullName = "Trương đức Nghĩa",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("02/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongducnghia@gmail.com"
                },
                new Student()
                {
                    Id = 10084,
                    FullName = "Cao Thị Bích Ngọc",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("17/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "caothibichngoc@gmail.com"
                },
                new Student()
                {
                    Id = 10085,
                    FullName = "Nguyễn Hoàng Nhật",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("02/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhoangnhat@gmail.com"
                },
                new Student()
                {
                    Id = 10086,
                    FullName = "Lê Thị Tuyết Nhi",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("30/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethituyetnhi@gmail.com"
                },
                new Student()
                {
                    Id = 10087,
                    FullName = "Lê Thị Quỳnh Như",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("02/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethiquynhnhu@gmail.com"
                },
                new Student()
                {
                    Id = 10088,
                    FullName = "Nguyễn Thị Tuyết Nhung",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("17/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthituyetnhung@gmail.com"
                },
                new Student()
                {
                    Id = 10089,
                    FullName = "Nguyễn Thị Kim Oanh",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("19/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthikimoanh@gmail.com"
                },
                new Student()
                {
                    Id = 10090,
                    FullName = "Nguyễn Phương Phi",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("11/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenphuongphi@gmail.com"
                },
                new Student()
                {
                    Id = 10091,
                    FullName = "Nguyễn Hồng Phong",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("27/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhongphong@gmail.com"
                },
                new Student()
                {
                    Id = 10092,
                    FullName = "Nguyễn Lê Thanh Phụng",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenlethanhphung@gmail.com"
                },
                new Student()
                {
                    Id = 10093,
                    FullName = "Bùi Hoàng Nhất Phương",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("13/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "buihoangnhatphuong@gmail.com"
                },
                new Student()
                {
                    Id = 10094,
                    FullName = "Đặng Hồng Quang",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "danghongquang@gmail.com"
                },
                new Student()
                {
                    Id = 10095,
                    FullName = "Đinh Văn Hào Quang",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("28/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dinhvanhaoquang@gmail.com"
                },
                new Student()
                {
                    Id = 10096,
                    FullName = "Liên Hiệp Quốc",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("01/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lienhiepquoc@gmail.com"
                },
                new Student()
                {
                    Id = 10097,
                    FullName = "Lâm Thái Sang",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("20/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lamthaisang@gmail.com"
                },
                new Student()
                {
                    Id = 10098,
                    FullName = "Trương Hữu Sang",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("15/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truonghuusang@gmail.com"
                },
                new Student()
                {
                    Id = 10099,
                    FullName = "Nguyễn Thị Minh Tâm",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthiminhtam@gmail.com"
                },
                new Student()
                {
                    Id = 10100,
                    FullName = "Trần Hữu Thanh Tâm",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhuuthanhtam@gmail.com"
                },
                new Student()
                {
                    Id = 10101,
                    FullName = "Hà Ngủ Tân",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 1,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("29/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hangutan@gmail.com"
                },
                new Student()
                {
                    Id = 10102,
                    FullName = "Hồ Thị Trang",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("24/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hothitrang@gmail.com"
                },
                new Student()
                {
                    Id = 10103,
                    FullName = "Đặng Hoàng Trinh",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "danghoangtrinh@gmail.com"
                },
                new Student()
                {
                    Id = 10104,
                    FullName = "Nguyễn Thị Trinh",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("10/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthitrinh@gmail.com"
                },
                new Student()
                {
                    Id = 10105,
                    FullName = "Ngô Minh Tú",
                    ClassId = 2003,
                    ClassName = "10A3",
                    Gender = 0,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "ngominhtu@gmail.com"
                },
                new Student()
                {
                    Id = 10106,
                    FullName = "Võ Văn Tuấn",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("27/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vovantuan@gmail.com"
                },
                new Student()
                {
                    Id = 10107,
                    FullName = "Hồ Sỹ Tuyến",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hosytuyen@gmail.com"
                },
                new Student()
                {
                    Id = 10108,
                    FullName = "Nguyễn Thế Văn",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("10/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthevan@gmail.com"
                },
                new Student()
                {
                    Id = 10109,
                    FullName = "Trần Hồng Văn",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhongvan@gmail.com"
                },
                new Student()
                {
                    Id = 10110,
                    FullName = "Phạm Đình Việt",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamdinhviet@gmail.com"
                },
                new Student()
                {
                    Id = 10111,
                    FullName = "Trương Quang Vinh",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("24/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongquangvinh@gmail.com"
                },
                new Student()
                {
                    Id = 10112,
                    FullName = "Võ Hữu Kim Vy",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("09/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vohuukimvy@gmail.com"
                },
                new Student()
                {
                    Id = 10113,
                    FullName = "Phạm Hữu Cảnh",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamhuucanh@gmail.com"
                },
                new Student()
                {
                    Id = 10114,
                    FullName = "Nguyễn Lương Thiện Hoàng",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("30/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenluongthienhoang@gmail.com"
                },
                new Student()
                {
                    Id = 10115,
                    FullName = "Châu Phan Thông",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "chauphanthong@gmail.com"
                },
                new Student()
                {
                    Id = 10116,
                    FullName = "Lê Đức Toàn",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("16/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "leductoan@gmail.com"
                },
                new Student()
                {
                    Id = 10117,
                    FullName = "Nguyễn Thị Cẩm Tú",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("29/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthicamtu@gmail.com"
                },
                new Student()
                {
                    Id = 10118,
                    FullName = "Hồ Khánh Tường",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("21/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hokhanhtuong@gmail.com"
                },
                new Student()
                {
                    Id = 10119,
                    FullName = "Dương Lê Thanh Bình",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("10/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "duonglethanhbinh@gmail.com"
                },
                new Student()
                {
                    Id = 10120,
                    FullName = "Mai Văn Bình",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "maivanbinh@gmail.com"
                },
                new Student()
                {
                    Id = 10121,
                    FullName = "Bùi Quang Thanh Đạt",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("20/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "buiquangthanhdat@gmail.com"
                },
                new Student()
                {
                    Id = 10122,
                    FullName = "Trần Vĩnh Khiêm",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("06/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranvinhkhiem@gmail.com"
                },
                new Student()
                {
                    Id = 10123,
                    FullName = "Dương Trần Sơn Long",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("16/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "duongtransonlong@gmail.com"
                },
                new Student()
                {
                    Id = 10124,
                    FullName = "Bùi Đức Minh",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("13/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "buiducminh@gmail.com"
                },
                new Student()
                {
                    Id = 10125,
                    FullName = "Nguyễn Huỳnh Như Thảo",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhuynhnhuthao@gmail.com"
                },
                new Student()
                {
                    Id = 10126,
                    FullName = "Thái Hoàng Thịnh",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "thaihoangthinh@gmail.com"
                },
                new Student()
                {
                    Id = 10127,
                    FullName = "Lê Đặng Xuân Thùy",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "ledangxuanthuy@gmail.com"
                },
                new Student()
                {
                    Id = 10128,
                    FullName = "Lê Tuấn",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("17/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letuan@gmail.com"
                },
                new Student()
                {
                    Id = 10129,
                    FullName = "Nguyễn Thanh Tùng",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("11/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhtung@gmail.com"
                },
                new Student()
                {
                    Id = 10130,
                    FullName = "Phạm Thanh An",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("04/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamthanhan@gmail.com"
                },
                new Student()
                {
                    Id = 10131,
                    FullName = "Đỗ Công Chí",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("28/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "docongchi@gmail.com"
                },
                new Student()
                {
                    Id = 10132,
                    FullName = "Đỗ Linh Huệ",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("24/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dolinhhue@gmail.com"
                },
                new Student()
                {
                    Id = 10133,
                    FullName = "Phạm Hoàng Thuyết Linh",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("10/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamhoangthuyetlinh@gmail.com"
                },
                new Student()
                {
                    Id = 10134,
                    FullName = "Trần Hoàng Long",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhoanglong@gmail.com"
                },
                new Student()
                {
                    Id = 10135,
                    FullName = "La Vĩ Minh",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("21/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "laviminh@gmail.com"
                },
                new Student()
                {
                    Id = 10136,
                    FullName = "Cao Thanh Ngân",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "caothanhngan@gmail.com"
                },
                new Student()
                {
                    Id = 10137,
                    FullName = "Nguyễn Thanh Hà",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("09/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhha@gmail.com"
                },
                new Student()
                {
                    Id = 10138,
                    FullName = "Trần Minh Đức",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("23/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranminhduc@gmail.com"
                },
                new Student()
                {
                    Id = 10139,
                    FullName = "Lê Ngọc Hân",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("05/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lengochan@gmail.com"
                },
                new Student()
                {
                    Id = 10140,
                    FullName = "Nguyễn Thị Nhật Hằng",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("07/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthinhathang@gmail.com"
                },
                new Student()
                {
                    Id = 10141,
                    FullName = "Đặng Đăng Hiếu",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("06/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dangdanghieu@gmail.com"
                },
                new Student()
                {
                    Id = 10142,
                    FullName = "Trần Phi Long",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("22/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranphilong@gmail.com"
                },
                new Student()
                {
                    Id = 10143,
                    FullName = "Nguyễn Thị Tố Nga",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 0,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("29/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthitonga@gmail.com"
                },
                new Student()
                {
                    Id = 10144,
                    FullName = "Lê Thanh Nghị",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("15/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethanhnghi@gmail.com"
                },
                new Student()
                {
                    Id = 10145,
                    FullName = "Dương Hồng Ngọc",
                    ClassId = 2004,
                    ClassName = "10A4",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "duonghongngoc@gmail.com"
                },
                new Student()
                {
                    Id = 10146,
                    FullName = "Nguyễn Minh Nhựt",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenminhnhut@gmail.com"
                },
                new Student()
                {
                    Id = 10147,
                    FullName = "Trần Tiến Phát",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("31/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trantienphat@gmail.com"
                },
                new Student()
                {
                    Id = 10148,
                    FullName = "Nguyễn Bích Trâm",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenbichtram@gmail.com"
                },
                new Student()
                {
                    Id = 10149,
                    FullName = "Hoàng Thụy Trinh",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("09/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hoangthuytrinh@gmail.com"
                },
                new Student()
                {
                    Id = 10150,
                    FullName = "Mạc Huy Tú",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("12/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "machuytu@gmail.com"
                },
                new Student()
                {
                    Id = 10151,
                    FullName = "Lê Thị Như Ý",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("03/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethinhuy@gmail.com"
                },
                new Student()
                {
                    Id = 10152,
                    FullName = "Nguyễn Thị Thúy An",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("30/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthithuyan@gmail.com"
                },
                new Student()
                {
                    Id = 10153,
                    FullName = "Trần Hồng Ân",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("06/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhongan@gmail.com"
                },
                new Student()
                {
                    Id = 10154,
                    FullName = "Dương Phúc Huân",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("11/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "duongphuchuan@gmail.com"
                },
                new Student()
                {
                    Id = 10155,
                    FullName = "Nguyễn Văn Huỳnh",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("04/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenvanhuynh@gmail.com"
                },
                new Student()
                {
                    Id = 10156,
                    FullName = "Nguyễn Hữu Minh Khai",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("21/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhuuminhkhai@gmail.com"
                },
                new Student()
                {
                    Id = 10157,
                    FullName = "Nguyễn Ngọc Khải",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenngockhai@gmail.com"
                },
                new Student()
                {
                    Id = 10158,
                    FullName = "Đỗ Ngọc Khánh",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("06/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dongockhanh@gmail.com"
                },
                new Student()
                {
                    Id = 10159,
                    FullName = "Chế Duy Khoa",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("07/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "cheduykhoa@gmail.com"
                },
                new Student()
                {
                    Id = 10160,
                    FullName = "Nguyễn Hữu Tiền Khôi",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("06/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhuutienkhoi@gmail.com"
                },
                new Student()
                {
                    Id = 10161,
                    FullName = "Nguyễn Sanh Kim",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyensanhkim@gmail.com"
                },
                new Student()
                {
                    Id = 10162,
                    FullName = "Hoàng Phan Lê",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("09/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hoangphanle@gmail.com"
                },
                new Student()
                {
                    Id = 10163,
                    FullName = "Nguyễn Phúc Lộc",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("28/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenphucloc@gmail.com"
                },
                new Student()
                {
                    Id = 10164,
                    FullName = "Lê Hồng Ngân",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("15/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lehongngan@gmail.com"
                },
                new Student()
                {
                    Id = 10165,
                    FullName = "Lưu Hoàng Hải Ngân",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("07/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "luuhoanghaingan@gmail.com"
                },
                new Student()
                {
                    Id = 10166,
                    FullName = "Bùi Hà Nguyên",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("01/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "buihanguyen@gmail.com"
                },
                new Student()
                {
                    Id = 10167,
                    FullName = "Phú Hữu Phước",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("29/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phuhuuphuoc@gmail.com"
                },
                new Student()
                {
                    Id = 10168,
                    FullName = "Hồ Thanh Phương",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("23/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hothanhphuong@gmail.com"
                },
                new Student()
                {
                    Id = 10169,
                    FullName = "Hùng Văn Thái",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("09/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hungvanthai@gmail.com"
                },
                new Student()
                {
                    Id = 10170,
                    FullName = "Lương Thị Phương Thanh",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("19/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "luongthiphuongthanh@gmail.com"
                },
                new Student()
                {
                    Id = 10171,
                    FullName = "Lê Hoàng Phương Thể",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("07/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lehoangphuongthe@gmail.com"
                },
                new Student()
                {
                    Id = 10172,
                    FullName = "Nguyễn Thanh Thịnh",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhthinh@gmail.com"
                },
                new Student()
                {
                    Id = 10173,
                    FullName = "Huỳnh Qui Thuận",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("16/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "huynhquithuan@gmail.com"
                },
                new Student()
                {
                    Id = 10174,
                    FullName = "Ngô Võ Thùy Trang",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("05/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "ngovothuytrang@gmail.com"
                },
                new Student()
                {
                    Id = 10175,
                    FullName = "Võ Đình Triết",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("21/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vodinhtriet@gmail.com"
                },
                new Student()
                {
                    Id = 10176,
                    FullName = "Âu Chí Trung",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("28/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "auchitrung@gmail.com"
                },
                new Student()
                {
                    Id = 10177,
                    FullName = "Phạm Ngọc Vương",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("09/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamngocvuong@gmail.com"
                },
                new Student()
                {
                    Id = 10178,
                    FullName = "Phan Thùy Dương",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("01/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phanthuyduong@gmail.com"
                },
                new Student()
                {
                    Id = 10179,
                    FullName = "Lê Thị Phương Khanh",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethiphuongkhanh@gmail.com"
                },
                new Student()
                {
                    Id = 10180,
                    FullName = "Đỗ Hữu Lượng",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("16/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dohuuluong@gmail.com"
                },
                new Student()
                {
                    Id = 10181,
                    FullName = "Trần Hữu Phát",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 1,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("09/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhuuphat@gmail.com"
                },
                new Student()
                {
                    Id = 10182,
                    FullName = "Lê Đức Anh",
                    ClassId = 2005,
                    ClassName = "11A1",
                    Gender = 0,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("10/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "leducanh@gmail.com"
                },
                new Student()
                {
                    Id = 10183,
                    FullName = "Trần Ngọc Anh",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("06/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranngocanh@gmail.com"
                },
                new Student()
                {
                    Id = 10184,
                    FullName = "Trương Thị Hoài Ánh",
                    ClassId = 2006,
                    ClassName = "11Á2",
                    Gender = 0,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongthihoaianh@gmail.com"
                },
                new Student()
                {
                    Id = 10185,
                    FullName = "Cao Hoài Bảo",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "caohoaibao@gmail.com"
                },
                new Student()
                {
                    Id = 10186,
                    FullName = "Nguyễn Quốc Cường",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("30/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenquoccuong@gmail.com"
                },
                new Student()
                {
                    Id = 10187,
                    FullName = "Đồng Xuân Danh",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("17/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dongxuandanh@gmail.com"
                },
                new Student()
                {
                    Id = 10188,
                    FullName = "Nguyễn Thị Ngọc Điệp",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("30/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthingocdiep@gmail.com"
                },
                new Student()
                {
                    Id = 10189,
                    FullName = "Trịnh Lê Nhật Huy",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trinhlenhathuy@gmail.com"
                },
                new Student()
                {
                    Id = 10190,
                    FullName = "Hồ Thị Ngọc Huyền",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("01/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hòthịngọchuyèn@gmail.com"
                },
                new Student()
                {
                    Id = 10191,
                    FullName = "Võ Quý Khánh",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("20/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "voquykhanh@gmail.com"
                },
                new Student()
                {
                    Id = 10192,
                    FullName = "Trần Trọng Khiêm",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("04/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trantrongkhiem@gmail.com"
                },
                new Student()
                {
                    Id = 10193,
                    FullName = "Đỗ Hoàng Anh Khoa",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("17/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dohoanganhkhoa@gmail.com"
                },
                new Student()
                {
                    Id = 10194,
                    FullName = "Lê Tuấn Khôi",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("30/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letuankhoi@gmail.com"
                },
                new Student()
                {
                    Id = 10195,
                    FullName = "Nguyễn Thị Anh Kiều",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthianhkieu@gmail.com"
                },
                new Student()
                {
                    Id = 10196,
                    FullName = "Nguyễn Thị Lan",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthilan@gmail.com"
                },
                new Student()
                {
                    Id = 10197,
                    FullName = "Trương Thị Mỹ Linh",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("24/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongthimylinh@gmail.com"
                },
                new Student()
                {
                    Id = 10198,
                    FullName = "Huỳnh Chí Lương",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("15/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "huynhchiluong@gmail.com"
                },
                new Student()
                {
                    Id = 10199,
                    FullName = "Dương Phước Mậu",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "duongphuocmau@gmail.com"
                },
                new Student()
                {
                    Id = 10200,
                    FullName = "Lê Hồng Minh",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("16/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lehongminh@gmail.com"
                },
                new Student()
                {
                    Id = 10201,
                    FullName = "Nguyễn Duy Minh",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("20/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenduyminh@gmail.com"
                },
                new Student()
                {
                    Id = 10202,
                    FullName = "Trần Thanh Minh",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("07/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranthanhminh@gmail.com"
                },
                new Student()
                {
                    Id = 10203,
                    FullName = "Cao Thị Trà My",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("06/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "caothitramy@gmail.com"
                },
                new Student()
                {
                    Id = 10204,
                    FullName = "Nguyễn Thị Anh Nga",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthianhnga@gmail.com"
                },
                new Student()
                {
                    Id = 10205,
                    FullName = "Đinh Thị Yến Ngân",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dinhthiyenngan@gmail.com"
                },
                new Student()
                {
                    Id = 10206,
                    FullName = "Trần Trọng Nghĩa",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("27/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trantrongnghia@gmail.com"
                },
                new Student()
                {
                    Id = 10207,
                    FullName = "Trà Thảo Nguyên",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trathaonguyen@gmail.com"
                },
                new Student()
                {
                    Id = 10208,
                    FullName = "Võ Tấn Nguyên",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("02/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "votannguyen@gmail.com"
                },
                new Student()
                {
                    Id = 10209,
                    FullName = "Phan Trọng Nhân",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("21/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phantrongnhan@gmail.com"
                },
                new Student()
                {
                    Id = 10210,
                    FullName = "Trịnh Hồng Nhung",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("06/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trinhhongnhung@gmail.com"
                },
                new Student()
                {
                    Id = 10211,
                    FullName = "Đỗ Minh Nhựt",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dominhnhut@gmail.com"
                },
                new Student()
                {
                    Id = 10212,
                    FullName = "Trần Minh Phát",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranminhphat@gmail.com"
                },
                new Student()
                {
                    Id = 10213,
                    FullName = "Nguyễn Thị Bích Phượng",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("11/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthibichphuong@gmail.com"
                },
                new Student()
                {
                    Id = 10214,
                    FullName = "Quách Nam Phương",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("22/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "quachnamphuong@gmail.com"
                },
                new Student()
                {
                    Id = 10215,
                    FullName = "Phạm Văn Hào Quang",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamvanhaoquang@gmail.com"
                },
                new Student()
                {
                    Id = 10216,
                    FullName = "Lê Minh Quốc",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "leminhquoc@gmail.com"
                },
                new Student()
                {
                    Id = 10217,
                    FullName = "Dương Ngọc Như Quỳnh",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 0,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("04/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "duongngocnhuquynh@gmail.com"
                },
                new Student()
                {
                    Id = 10218,
                    FullName = "Lê Trần Duy Sang",
                    ClassId = 2006,
                    ClassName = "11A2",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("28/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letranduysang@gmail.com"
                },
                new Student()
                {
                    Id = 10219,
                    FullName = "Nguyễn Tấn Sang",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("13/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyentansang@gmail.com"
                },
                new Student()
                {
                    Id = 10220,
                    FullName = "Hoàng Thị Thanh",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hoangthithanh@gmail.com"
                },
                new Student()
                {
                    Id = 10221,
                    FullName = "Võ Thị Duy Thảo",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("16/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vothiduythao@gmail.com"
                },
                new Student()
                {
                    Id = 10222,
                    FullName = "Lê Phước Thiện",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("29/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lephuocthien@gmail.com"
                },
                new Student()
                {
                    Id = 10223,
                    FullName = "Trương Minh Thiện",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("30/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongminhthien@gmail.com"
                },
                new Student()
                {
                    Id = 10224,
                    FullName = "Nguyễn Thị Kim Thoa",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("09/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthikimthoa@gmail.com"
                },
                new Student()
                {
                    Id = 10225,
                    FullName = "Trần Quốc Thống",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("01/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranquocthong@gmail.com"
                },
                new Student()
                {
                    Id = 10226,
                    FullName = "Trần Trọng Tiến",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("03/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trantrongtien@gmail.com"
                },
                new Student()
                {
                    Id = 10227,
                    FullName = "Nguyễn Thị Hồng Trúc",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("22/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthihongtruc@gmail.com"
                },
                new Student()
                {
                    Id = 10228,
                    FullName = "Phan Thanh Tú",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("17/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phanthanhtu@gmail.com"
                },
                new Student()
                {
                    Id = 10229,
                    FullName = "Trần Anh Tuân",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("03/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trananhtuan@gmail.com"
                },
                new Student()
                {
                    Id = 10230,
                    FullName = "Đinh Đạt Vi",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dinhdatvi@gmail.com"
                },
                new Student()
                {
                    Id = 10231,
                    FullName = "Huỳnh Hữu Ý",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("04/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "huynhhuuy@gmail.com"
                },
                new Student()
                {
                    Id = 10232,
                    FullName = "Lê Thị Như ý",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("25/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethinhuy@gmail.com"
                },
                new Student()
                {
                    Id = 10233,
                    FullName = "Huỳnh Khánh Hòa",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("23/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "huynhkhanhhoa@gmail.com"
                },
                new Student()
                {
                    Id = 10234,
                    FullName = "Nguyễn Thanh Hoàng",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("11/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhhoang@gmail.com"
                },
                new Student()
                {
                    Id = 10235,
                    FullName = "An Minh Hùng",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("27/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "anminhhung@gmail.com"
                },
                new Student()
                {
                    Id = 10236,
                    FullName = "Trần Việt Hùng",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("01/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranviethung@gmail.com"
                },
                new Student()
                {
                    Id = 10237,
                    FullName = "Trần Hoàng Huy",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhoanghuy@gmail.com"
                },
                new Student()
                {
                    Id = 10238,
                    FullName = "Lê Hoàng Khánh",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("16/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lehoangkhanh@gmail.com"
                },
                new Student()
                {
                    Id = 10239,
                    FullName = "Lê Tuấn Kiệt",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("27/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letuankiet@gmail.com"
                },
                new Student()
                {
                    Id = 10240,
                    FullName = "Lê Si Lắc",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lesilac@gmail.com"
                },
                new Student()
                {
                    Id = 10241,
                    FullName = "Nguyễn Trường Lâu",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("16/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyentruonglau@gmail.com"
                },
                new Student()
                {
                    Id = 10242,
                    FullName = "Lê Thị Thảo Linh",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("16/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethithaolinh@gmail.com"
                },
                new Student()
                {
                    Id = 10243,
                    FullName = "Nguyễn Duy Hoài Sơn",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("09/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenduyhoaison@gmail.com"
                },
                new Student()
                {
                    Id = 10244,
                    FullName = "Lê Thủy Triều",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("18/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethuytrieu@gmail.com"
                },
                new Student()
                {
                    Id = 10245,
                    FullName = "Nguyễn Đăng An",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("19/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyendangan@gmail.com"
                },
                new Student()
                {
                    Id = 10246,
                    FullName = "Nguyễn Đức An",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("11/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenducan@gmail.com"
                },
                new Student()
                {
                    Id = 10247,
                    FullName = "Nguyễn Thị Vân Anh",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("26/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthivananh@gmail.com"
                },
                new Student()
                {
                    Id = 10248,
                    FullName = "Lê Duy Thành Công",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("26/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "leduythanhcong@gmail.com"
                },
                new Student()
                {
                    Id = 10249,
                    FullName = "Phạm Bá Đạt",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("04/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phambadat@gmail.com"
                },
                new Student()
                {
                    Id = 10250,
                    FullName = "Nguyễn Khắc An Dương",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("07/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenkhacanduong@gmail.com"
                },
                new Student()
                {
                    Id = 10251,
                    FullName = "Nguyễn Thị Phương Hảo",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthiphuonghao@gmail.com"
                },
                new Student()
                {
                    Id = 10252,
                    FullName = "Lê Cao Hưng",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lecaohung@gmail.com"
                },
                new Student()
                {
                    Id = 10253,
                    FullName = "Phạm Hoàng Đăng Khoa",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamhoangdangkhoa@gmail.com"
                },
                new Student()
                {
                    Id = 10254,
                    FullName = "Trương Bá Luân",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("01/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "truongbaluan@gmail.com"
                },
                new Student()
                {
                    Id = 10255,
                    FullName = "Đặng Tuấn Minh",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("03/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dangtuanminh@gmail.com"
                },
                new Student()
                {
                    Id = 10256,
                    FullName = "Nguyễn Ngọc Minh",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("21/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenngocminh@gmail.com"
                },
                new Student()
                {
                    Id = 10257,
                    FullName = "Phan Duy Nam",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 1,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phanduynam@gmail.com"
                },
                new Student()
                {
                    Id = 10258,
                    FullName = "Nguyễn Bảo Ngọc",
                    ClassId = 2007,
                    ClassName = "11A3",
                    Gender = 0,
                    Address = "P.Phước Long B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("27/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenbaongoc@gmail.com"
                },
                new Student()
                {
                    Id = 10259,
                    FullName = "Lê Chấn Hải Phong",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("21/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lechanhaiphong@gmail.com"
                },
                new Student()
                {
                    Id = 10260,
                    FullName = "Võ Lê Phong",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "volephong@gmail.com"
                },
                new Student()
                {
                    Id = 10261,
                    FullName = "Trần Nguyễn Hồng Quân",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("07/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trannguyenhongquan@gmail.com"
                },
                new Student()
                {
                    Id = 10262,
                    FullName = "Đặng Xuân Trường",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("28/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dangxuantruong@gmail.com"
                },
                new Student()
                {
                    Id = 10263,
                    FullName = "Lê Thanh Tùng",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("29/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lethanhtung@gmail.com"
                },
                new Student()
                {
                    Id = 10264,
                    FullName = "Vũ Đức Vĩ",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vuducvi@gmail.com"
                },
                new Student()
                {
                    Id = 10265,
                    FullName = "Nguyễn Hữu Phong",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhuuphong@gmail.com"
                },
                new Student()
                {
                    Id = 10266,
                    FullName = "Lê Hoàng Ân",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("19/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lehoangan@gmail.com"
                },
                new Student()
                {
                    Id = 10267,
                    FullName = "Lý Hồng Thiên Ân",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lyhongthienan@gmail.com"
                },
                new Student()
                {
                    Id = 10268,
                    FullName = "Đặng Đình Quyền Anh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("01/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dangdinhquyenanh@gmail.com"
                },
                new Student()
                {
                    Id = 10269,
                    FullName = "Nguyễn Trung Bảo Anh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("25/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyentrungbaoanh@gmail.com"
                },
                new Student()
                {
                    Id = 10270,
                    FullName = "Trần Xuân Ánh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranxuananh@gmail.com"
                },
                new Student()
                {
                    Id = 10271,
                    FullName = "Nguyễn Chí Bảo",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("21/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenchibao@gmail.com"
                },
                new Student()
                {
                    Id = 10272,
                    FullName = "Nguyễn Thành Danh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("17/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhdanh@gmail.com"
                },
                new Student()
                {
                    Id = 10273,
                    FullName = "Nguyễn Thanh Liêm",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Long Trường, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("01/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthanhliem@gmail.com"
                },
                new Student()
                {
                    Id = 10274,
                    FullName = "Nguyễn Thùy Linh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenthuylinh@gmail.com"
                },
                new Student()
                {
                    Id = 10275,
                    FullName = "Phạm Viết Lưu",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("25/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamvietluu@gmail.com"
                },
                new Student()
                {
                    Id = 10276,
                    FullName = "Vũ Đình Vi Nghiệm",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Long Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("31/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vudinhvinghiem@gmail.com"
                },
                new Student()
                {
                    Id = 10277,
                    FullName = "Phan Nguyên",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("20/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phannguyen@gmail.com"
                },
                new Student()
                {
                    Id = 10278,
                    FullName = "Nguyễn Trường Phát",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("12/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyentruongphat@gmail.com"
                },
                new Student()
                {
                    Id = 10279,
                    FullName = "Trầm Hữu Phúc",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("21/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tramhuuphuc@gmail.com"
                },
                new Student()
                {
                    Id = 10280,
                    FullName = "Vũ Lê Hoàng Phúc",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("20/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vulehoangphuc@gmail.com"
                },
                new Student()
                {
                    Id = 10281,
                    FullName = "Lê Tuấn Thanh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Tam Phú, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("09/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letuanthanh@gmail.com"
                },
                new Student()
                {
                    Id = 10282,
                    FullName = "Lê Quốc Thịnh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("26/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lequocthinh@gmail.com"
                },
                new Student()
                {
                    Id = 10283,
                    FullName = "Nguyễn Hoàng Trung",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("15/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhoangtrung@gmail.com"
                },
                new Student()
                {
                    Id = 10284,
                    FullName = "Lâm Trường",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lamtruong@gmail.com"
                },
                new Student()
                {
                    Id = 10285,
                    FullName = "Vũ Ngọc Trường",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("02/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vungoctruong@gmail.com"
                },
                new Student()
                {
                    Id = 10286,
                    FullName = "Danh Đức Khánh Duy",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("10/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "danhduckhanhduy@gmail.com"
                },
                new Student()
                {
                    Id = 10287,
                    FullName = "Hồ Thái An",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("23/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hothaian@gmail.com"
                },
                new Student()
                {
                    Id = 10288,
                    FullName = "Nguyễn Bá An",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenbaan@gmail.com"
                },
                new Student()
                {
                    Id = 10289,
                    FullName = "Lê Tuấn Anh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Bình Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("09/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letuananh@gmail.com"
                },
                new Student()
                {
                    Id = 10290,
                    FullName = "Trần Hoàng Anh",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("07/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhoanganh@gmail.com"
                },
                new Student()
                {
                    Id = 10291,
                    FullName = "Phan Hữu Đạt",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("24/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phanhuudat@gmail.com"
                },
                new Student()
                {
                    Id = 10292,
                    FullName = "Lê Văn Ngọc Đoan",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "levanngocdoan@gmail.com"
                },
                new Student()
                {
                    Id = 10293,
                    FullName = "Bùi Phùng Hữu Đức",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("25/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "buiphunghuuduc@gmail.com"
                },
                new Student()
                {
                    Id = 10294,
                    FullName = "Lê Nguyễn Hải Duy",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lenguyenhaiduy@gmail.com"
                },
                new Student()
                {
                    Id = 10295,
                    FullName = "Vũ Ngọc Anh Hà",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 0,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("31/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "vungocanhha@gmail.com"
                },
                new Student()
                {
                    Id = 10296,
                    FullName = "Phùng Văn Hảo",
                    ClassId = 2008,
                    ClassName = "12A1",
                    Gender = 1,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("18/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phungvanhao@gmail.com"
                },
                new Student()
                {
                    Id = 10297,
                    FullName = "Nguyễn Văn Mạnh",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("18/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenvanmanh@gmail.com"
                },
                new Student()
                {
                    Id = 10298,
                    FullName = "Lê Huy Ngọc Nam",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "lehuyngocnam@gmail.com"
                },
                new Student()
                {
                    Id = 10299,
                    FullName = "Mai Như Ngọc",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Hiệp Bình Chánh, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "mainhungoc@gmail.com"
                },
                new Student()
                {
                    Id = 10300,
                    FullName = "Nguyễn Cao Nguyên",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("31/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyencaonguyen@gmail.com"
                },
                new Student()
                {
                    Id = 10301,
                    FullName = "Phan Vũ Nguyên",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Trường Thạnh, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("30/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phanvunguyen@gmail.com"
                },
                new Student()
                {
                    Id = 10302,
                    FullName = "Phạm Đình Nhân",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("24/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamdinhnhan@gmail.com"
                },
                new Student()
                {
                    Id = 10303,
                    FullName = "Ngô Quốc Nhu",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "ngoquocnhu@gmail.com"
                },
                new Student()
                {
                    Id = 10304,
                    FullName = "Đặng Nhật Phi",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Hiệp Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dangnhatphi@gmail.com"
                },
                new Student()
                {
                    Id = 10305,
                    FullName = "Trần Thanh Phong",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("16/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranthanhphong@gmail.com"
                },
                new Student()
                {
                    Id = 10306,
                    FullName = "Trần Hữu Phước",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("06/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhuuphuoc@gmail.com"
                },
                new Student()
                {
                    Id = 10307,
                    FullName = "Nguyễn Bình Phương",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("26/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenbinhphuong@gmail.com"
                },
                new Student()
                {
                    Id = 10308,
                    FullName = "Lê Tuấn Quốc",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("24/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letuanquoc@gmail.com"
                },
                new Student()
                {
                    Id = 10309,
                    FullName = "Nguyễn Hoàng Quốc",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Phước Long A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenhoangquoc@gmail.com"
                },
                new Student()
                {
                    Id = 10310,
                    FullName = "Chu Minh Tân",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "chuminhtan@gmail.com"
                },
                new Student()
                {
                    Id = 10311,
                    FullName = "Lưu Thành Tấn",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Tân Phú, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("01/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "luuthanhtan@gmail.com"
                },
                new Student()
                {
                    Id = 10312,
                    FullName = "Nguyễn Tuấn Thành",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("29/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyentuanthanh@gmail.com"
                },
                new Student()
                {
                    Id = 10313,
                    FullName = "Trần Hoài Thanh",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("08/07/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranhoaithanh@gmail.com"
                },
                new Student()
                {
                    Id = 10314,
                    FullName = "Nguyễn Kim Thảo",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("03/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenkimthao@gmail.com"
                },
                new Student()
                {
                    Id = 10315,
                    FullName = "Nguyễn Kim Thiên",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Trường Thọ, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/12/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenkimthien@gmail.com"
                },
                new Student()
                {
                    Id = 10316,
                    FullName = "Trần Tiến Thiệu",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("11/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "trantienthieu@gmail.com"
                },
                new Student()
                {
                    Id = 10317,
                    FullName = "Lê Trọng Thức",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("13/10/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "letrongthuc@gmail.com"
                },
                new Student()
                {
                    Id = 10318,
                    FullName = "Lê Minh Tiến",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Phú Hữu, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("05/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "leminhtien@gmail.com"
                },
                new Student()
                {
                    Id = 10319,
                    FullName = "Hồng Châu Toàn",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Linh Tây, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("25/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "hongchautoan@gmail.com"
                },
                new Student()
                {
                    Id = 10320,
                    FullName = "Nguyễn Quốc Toàn",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Phước Bình, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("23/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenquoctoan@gmail.com"
                },
                new Student()
                {
                    Id = 10321,
                    FullName = "Nguyễn Quốc Toản",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("27/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenquoctoan@gmail.com"
                },
                new Student()
                {
                    Id = 10322,
                    FullName = "Trần Thị Lan Trinh",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("19/11/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranthilantrinh@gmail.com"
                },
                new Student()
                {
                    Id = 10323,
                    FullName = "Trần Minh Trung",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Linh Ðông, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("23/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranminhtrung@gmail.com"
                },
                new Student()
                {
                    Id = 10324,
                    FullName = "Phạm Quang Trường",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("18/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamquangtruong@gmail.com"
                },
                new Student()
                {
                    Id = 10325,
                    FullName = "Trần Văn Trường",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("03/03/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "tranvantruong@gmail.com"
                },
                new Student()
                {
                    Id = 10326,
                    FullName = "Mai Lê Nhật Tú",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Tam Bình, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("14/04/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "mailenhattu@gmail.com"
                },
                new Student()
                {
                    Id = 10327,
                    FullName = "Phạm Minh Tú",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Long Thạnh Mỹ, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("24/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamminhtu@gmail.com"
                },
                new Student()
                {
                    Id = 10328,
                    FullName = "Thân Thế Tùng",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("06/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "thanthetung@gmail.com"
                },
                new Student()
                {
                    Id = 10329,
                    FullName = "Huỳnh Thị Bích Tuyền",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("10/05/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "huynhthibichtuyen@gmail.com"
                },
                new Student()
                {
                    Id = 10330,
                    FullName = "Chướng Sec Váy",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Hiệp Bình Phước, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("07/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "chuongsecvay@gmail.com"
                },
                new Student()
                {
                    Id = 10331,
                    FullName = "Nguyễn Phi Yến",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Tăng Nhơn Phú B, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("13/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenphiyen@gmail.com"
                },
                new Student()
                {
                    Id = 10332,
                    FullName = "Phạm Đông Yên",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 0,
                    Address = "P.Linh Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("08/08/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamdongyen@gmail.com"
                },
                new Student()
                {
                    Id = 10333,
                    FullName = "Nguyễn Lương Duy",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Long Phước, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("25/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenluongduy@gmail.com"
                },
                new Student()
                {
                    Id = 10334,
                    FullName = "Phạm Tuấn Anh",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Bình Chiểu, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("21/01/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "phamtuananh@gmail.com"
                },
                new Student()
                {
                    Id = 10335,
                    FullName = "Nguyễn Văn Gia Bảo",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Linh Trung, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("20/02/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nguyenvangiabao@gmail.com"
                },
                new Student()
                {
                    Id = 10336,
                    FullName = "Trần Quốc Đạt",
                    ClassId = 2009,
                    ClassName = "12A2",
                    Gender = 1,
                    Address = "P.Tăng Nhơn Phú A, Q.9, TP HCM",
                    DoB = DateTime.ParseExact("06/09/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "dattq@gmail.com"
                },
                new Student()
                {
                    Id = 10337,
                    FullName = "Trần Nghĩa",
                    ClassId = 2001,
                    ClassName = "10A1",
                    Gender = 1,
                    Address = "P.Linh Xuân, Q.Thủ Đức, TP HCM",
                    DoB = DateTime.ParseExact("09/06/1996", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = "nghiat@gmail.com"
                },
            };
        }
    }
}
