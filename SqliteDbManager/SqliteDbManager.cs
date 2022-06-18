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
        if (string.IsNullOrEmpty(connectionString))
            throw new Exception("Connection string is not defined.");
        
        try
        {
            using var con = new SQLiteConnection(cs);
        }
        catch (Exception e)
        {
            throw;
        }
    }
}