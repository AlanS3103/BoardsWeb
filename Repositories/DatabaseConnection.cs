using Microsoft.Data.SqlClient;

public abstract class DatabaseConnection : IDisposable
{

    protected SqlConnection connection;

    public DatabaseConnection()
    {
        string strConn = @"Data Source=localhost;
        Initial Catalog=DBBoards
        Integrated Security=True
        TrustServerCertificate=True";
        // Integrated Security=False
        // User=aluno
        // Password=dba
        // TrustServerCertified=True
        connection = new SqlConnection(strConn);
        connection.Open();
    }

    public void Dispose(){
        connection.Close();
    }
}