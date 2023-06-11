using System.Data;
using System.Data.SqlClient;

namespace DndOverlordHomePage.Repositories;
using DndOverlordHomePage.Models;

public class CharacterRepository
{

    public void Insert(Character character) => Insert(new List<Character>() { character });
    
    public void Insert(List<Character> characters)
    {
        
    }

    public void Delete()
    {
        
    }

    public void Update()
    {
        
    }

    public Character Get(long characterId)
    {
        using (var sqlConnection = new SqlConnection(GetConnectionString()))
        {
            sqlConnection.Open();
            var storedProcedureName = "GetCharacter_01";
            using (var sqlCommand = new SqlCommand(storedProcedureName, sqlConnection))
            {
                sqlCommand.CommandTimeout = 30;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CharacterID",characterId);
                return new Character(sqlCommand.ExecuteReader());
            }
        }
    }

    private string GetConnectionString() => "";
}