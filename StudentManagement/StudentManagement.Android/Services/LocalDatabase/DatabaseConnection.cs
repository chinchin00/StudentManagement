using System;
using System.IO;
using SQLite;
using StudentManagement.Droid.Services.LocalDatabase;
using StudentManagement.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection))]
namespace StudentManagement.Droid.Services.LocalDatabase
{
    public class DatabaseConnection : IDatabaseConnection
    {
        string GetPath(string databaseName)
        {
            var sqliteFilename = $"{databaseName}.db3";
            var path = Path.Combine(GetDatabasePath(), sqliteFilename);

            if (!File.Exists(path)) File.Create(path);

            return path;
        }

        public string GetDatabasePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        public SQLiteConnection SqliteConnection(string databaseName)
        {
            return new SQLiteConnection(GetPath(databaseName));
        }

        public long GetSize(string databaseName)
        {
            var fileInfo = new FileInfo(GetPath(databaseName));
            return fileInfo.Length;
        }
    }
}