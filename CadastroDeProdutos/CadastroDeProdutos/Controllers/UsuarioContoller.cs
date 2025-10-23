using Microsoft.AspNetCore.Mvc;

namespace CadastroDeProdutos.Controllers
{
    public class UsuarioContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
