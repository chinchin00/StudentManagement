using SQLite;

namespace StudentManagement.Interfaces
{
    public interface IDatabaseConnection
    {
        SQLiteConnection SqliteConnection(string databaseName);
        long GetSize(string databaseName);
        string GetDatabasePath();
    }
}
