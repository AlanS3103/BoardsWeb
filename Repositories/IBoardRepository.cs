public interface IBoarRepository{
    public void Create(Board board);
    IEnumerable<Board> Read();

}