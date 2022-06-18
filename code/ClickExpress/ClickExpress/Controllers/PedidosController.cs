using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClickExpress.Models;
using System.Security.Claims;


namespace ClickExpress.Controllers
{
    public class PedidosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedidosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pedidos.Include(p => p.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var pedido = await _context.Pedidos
                .Include(p => p.Usuario)
                .Include(p => p.Itens)
                .Include(p => p.Orcamentos)
                .FirstOrDefaultAsync(m => m.Id_contrato == id);
            if (pedido == null)
            {
                return NotFound();
            }



            return View(pedido);
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> DetailsResposta(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.Usuario)
                .Include(p => p.Itens)
                .FirstOrDefaultAsync(m => m.Id_contrato == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> DetailsAprovacao(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.Usuario)
                .Include(p => p.Itens)
                .Include(p => p.Orcamentos)
                .FirstOrDefaultAsync(m => m.Id_contrato == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }


        // GET: Pedidos/Create   
        public IActionResult Create()

        {
            ViewData["Id_usuario"] = new SelectList(_context.Usuarios, "Id_usuario", "Nome");
            return View();
        }

        // POST: Pedidos/Create

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pedido pedido)
        {
            if (ModelState.IsValid && pedido.Dt_agendamento >= DateTime.Now)
            {

                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                pedido.Id_usuario = Convert.ToInt32(userId);
                var userCliente = _context.Clientes
                    .FirstOrDefault(m => m.Id_usuario == pedido.Id_usuario);
                pedido.Id_cliente = userCliente.Id_cliente;
                pedido.Dt_contrato = DateTime.Now;
                _context.Add(pedido);
                _context.SaveChanges();
                return Json(new { Resultado = pedido.Id_contrato });
            }
            return Json(new { Erro = true });
        }
        
        
        
        private bool PedidoExists(int id)
        {
            return _context.Pedidos.Any(e => e.Id_contrato == id);
        }

        //GET: Usuarios/Details/5
        public async Task<IActionResult> RelatorioUserStatus()
        {
            var pedido = await _context.Pedidos
            .ToListAsync();

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        //GET: Usuarios/Details/5
        public async Task<IActionResult> RelatorioUserStatusPendente()
        {
           // var teste = new StatusServico();
            //teste = (StatusServico)0;

            var pedido = await _context.Pedidos
                //.Where(x => x.Status == teste)
                .ToListAsync();

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        public async Task<IActionResult> Aceitar(int? id_orcam)
        {
            var orcamento = _context.Orcamentos
                        .Include(t => t.Pedido)
                      .FirstOrDefault(m => m.Id_orcamento == id_orcam);


            orcamento.Pedido.Status = StatusServico.Aceito;
            orcamento.Pedido.Id_prestador = orcamento.Id_prestador;
            orcamento.Pedido.Preco = orcamento.Preco;
            orcamento.Status_orcamento = "Aprovado";
            _context.Update(orcamento.Pedido);

            await _context.SaveChangesAsync();

            return View(orcamento.Pedido);

        }

        public async Task<IActionResult> Finalizar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.FindAsync(id);
            pedido.Status = StatusServico.Finalizado;
            _context.Update(pedido);

            await _context.SaveChangesAsync();

            return View(pedido);

        }

        // GET: Usuarios/Details/5
        //Relatorio usuario logado status Aceito
        public async Task<IActionResult> RelatoriosUserPrestadorAceito()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int id = Convert.ToInt32(userId);

            var prestador = await _context.Prestadores
                .FirstOrDefaultAsync(m => m.Id_usuario == id);

            var idPrestador = prestador.Id_prestador;

            var pedido = _context.Pedidos
                .Where(x => x.Id_prestador == idPrestador);

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

    }
}
