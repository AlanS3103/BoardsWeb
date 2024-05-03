
public class InterationMemoryRepository : IInterationRepository
{
    private List<Interation> interations = new List<Interation>();

    public void Create(Interation interation)
    {
        interation.InterationId = Guid.NewGuid();
        interations.Add(interation);
    }

    public void Delete(Guid id)
    {
        foreach(var interation in interations) {
            if(interation.InterationId == id)
                interations.Remove(interation);
                break;
        }
    }

    public IEnumerable<Interation> Read()
    {
        return interations;
    }

    public Interation Read(Guid id)
    {
        return interations.SingleOrDefault(i => i.InterationId == id);
        // foreach(var interation in interations) {
        //     if(interation.InterationId == id)
        //         return interation;
        // }

        // return null;
    }

    public void Update(Guid id, Interation interation)
    {
        foreach(var _interation in interations) {
            if(_interation.InterationId == id)
                _interation.Name = interation.Name;
                _interation.StartDate = interation.StartDate;
                _interation.EndDate = interation.EndDate;
                break;
        }
    }
}