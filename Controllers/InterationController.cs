using Microsoft.AspNetCore.Mvc;

public class InterationController : Controller
{
    private readonly IInterationRepository repository;
    public InterationController(IInterationRepository repository){
        this.repository = repository;
    }

    public ActionResult Index(){
        IEnumerable<Interation> interation = repository.Read();
        
        return View(interation);
    }

    [HttpGet]
    public ActionResult Create(Interation interation){
        repository.Create(interation);

        return RedirectToAction("Index");
    }
}