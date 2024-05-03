
using Microsoft.Data.SqlClient;

public class BoardSqlRepository : DatabaseConnection, IBoardRepository
{
    public void Create(Board board)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "INSERT INTO Board VALUES (@id, @name)";

        cmd.Parameters.AddWithValue("@id", board.BoardId);
        cmd.Parameters.AddWithValue("@name", board.Name);

        cmd.ExecuteNonQuery();
    }

    public IEnumerable<Board> Read()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "SELECT * FROM Board";

        SqlDataReader reader = cmd.ExecuteReader();

        List<Board> boards = new List<Board>();

        while (reader.Read())
        {
            Board board = new Board();
            board.BoardId = reader.GetGuid(0);
            board.Name = reader.GetString(1);

            boards.Add(board);
        }

        return boards;
    }
}