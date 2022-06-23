using ClickExpress.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace ClickExpress.Controllers
{

    public class ItensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItensController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult ListarItens(int id)
        {
            var lista = _context.Itens.Where(m => m.Pedido.Id_contrato == id);
            ViewBag.Pedido = id;
            return PartialView(lista);
        }

        public ActionResult SalvarItens(int quantidade, string descricao, int Id_contrato)
        {
            if (ModelState.IsValid && quantidade>0)
            {
                var item = new Item()
                {
                    Quantidade = quantidade,
                    Descricao = descricao,
                    Pedido = _context.Pedidos.Find(Id_contrato)
                };

                _context.Itens.Add(item);
                _context.SaveChanges();

                return Json(new { Resultado = item.Id_item });

            }
            return Json(new { Erro = true });
        }
        public IActionResult ConcluirPedido()
        {
            return View();
        }
                
    }
}
