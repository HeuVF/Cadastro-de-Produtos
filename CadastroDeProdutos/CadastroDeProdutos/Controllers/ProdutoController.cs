using Microsoft.AspNetCore.Mvc;

namespace CadastroDeProdutos.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
