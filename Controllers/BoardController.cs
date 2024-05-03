using Microsoft.AspNetCore.Mvc;

public class BoardController : Controller
{
    private readonly IBoardRepository repository;

    public BoardController(IBoardRepository repository){
        this.repository = repository;
    }
    
    // GET http://localhost:123/board/index
    
    // é a mesma coisa que:

    // BoardController board = new BoardController();
    // board.Index()
    public ActionResult Index(){
        // return /Views/Board/Index.cshtml
        IEnumerable<Board> boards = repository.Read();
        
        return View(boards);
    }

    [HttpGet]
    public ActionResult Create(){
        // return /Views/Board/Index.cshtml
        return View();
    }

    [HttpPost]
    public ActionResult Create(Board board){
        // string name = form["name"];

        // Board board = new Board();
        // board.Name = name;
        
        repository.Create(board);
        
        return RedirectToAction("Index");
    }
}