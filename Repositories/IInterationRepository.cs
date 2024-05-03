public interface IInterationRepository
{
    void Create(Interation interation);

    IEnumerable<Interation> Read();

    Interation Read(Guid id);

    void Update(Guid id, Interation interation);
    
    void Delete(Guid id);
}