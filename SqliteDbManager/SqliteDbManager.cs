namespace SqliteDbManager;
using System.Data.SQLite;

public class SqliteDbManager
{
    public string ConnectionString { get; set; }

    public SqliteDbManager(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public void CreateDatabase()
    {
        CreateDatabase(ConnectionString);
    }
    
    public void CreateDatabase(string connectionString)
    {
       
        try
        {
            SQLiteConnection.CreateFile("characterDatabase.sqlite");
        }
        catch (Exception e)
        {
            throw;
        }
    }
}