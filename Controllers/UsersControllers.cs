using Microsoft.AspNetCore.Mvc;


public class UsersController : Controller
{
    // https://localhost:5253/users/index
    public ActionResult Index(){
        // poderiamos conectar e acessar dados do BD
        // poderiamos conectar a uma API e obter os dados
        // poderiamos implementar regras de negócio
        // Views/Users/Index.cshtml
        return View();
    }
}