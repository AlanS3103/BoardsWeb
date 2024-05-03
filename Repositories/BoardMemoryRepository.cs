
public class BoardMemoryRepository : IBoardRepository
{
    private List<Board> boards = new List<Board>();
    public void Create(Board board)
    {
        board.BoardId = new Guid();
        boards.Add(board);
    }

    public IEnumerable<Board> Read()
    {
        return boards;
    }
}