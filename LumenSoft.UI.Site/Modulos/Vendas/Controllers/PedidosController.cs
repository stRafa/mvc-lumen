using Microsoft.AspNetCore.Mvc;

namespace LumenSoft.UI.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("Pedidos")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}