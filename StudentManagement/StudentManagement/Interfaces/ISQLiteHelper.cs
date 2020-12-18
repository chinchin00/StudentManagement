using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using StudentManagement.Models;

namespace StudentManagement.Interfaces
{
    public interface ISQLiteHelper
    {
        #region Gets
        T GetWithChildren<T>(string primaryKey, bool isRecursive = false) where T : class, new();
        //T GetWithChildren<T>(Expression<Func<T, bool>> predicate, bool isRecursive = false) where T : class, new ();
        T Get<T>(string primarykey) where T : class, new();
        T Get<T>(Expression<Func<T, bool>> predicate) where T : class, new();
        IEnumerable<T> GetList<T>(Expression<Func<T, bool>> predicate) where T : class, new();
        Setting GetSetting();
        User GetUser();
        #endregion

        #region Searchs

        //IEnumerable<StudentModel> SearchStudents<TStudentModel>(string searchInfo, string classId);
        //IEnumerable<ClassModel> SearchClasses<TClassModel>(string searchInfo, string classId);
        #endregion

        #region Inserts
        // Insert new object
        int Insert<T>(T obj);

        int InsertAll<T>(IEnumerable<T> list);

        void InsertWithChildren<T>(T obj, bool isRecursive = false);

        #endregion

        #region Updates
        int Update<T>(T obj);

        void UpdateWithChildren<T>(T obj);
        #endregion

        #region Deletes
        // Delete object with primary Key
        int Delete<T>(string id);

        void Delete<T>(T obj, bool isRecursive = false);

        int DeleteAll<T>();

        void DeleteAll<T>(IEnumerable<T> obj);
        #endregion

        #region Checks
        //bool CheckAccount(string username, string password);

        //bool CheckLogin();
        #endregion
    }
}
