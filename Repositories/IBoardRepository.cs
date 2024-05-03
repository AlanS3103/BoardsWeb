public interface IBoardRepository{
    public void Create(Board board);
    IEnumerable<Board> Read();

}