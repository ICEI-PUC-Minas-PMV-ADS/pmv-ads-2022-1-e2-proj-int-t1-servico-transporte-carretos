using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClickExpress.Models;
using System.Security.Claims;

namespace ClickExpress.Controllers
{
    public class OrcamentosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrcamentosController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Orcamentos/Create
        public IActionResult Create(int idContrato)
        {

            var orcamento = new Orcamento { Id_contrato = idContrato };
            return View(orcamento);
 
        }

        // POST: Orcamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_orcamento,Id_contrato,Id_prestador,Preco")] Orcamento orcamento)
        {

                if (ModelState.IsValid)
                {
                    var userId = Convert.ToInt32(this.User.FindFirstValue(ClaimTypes.NameIdentifier));
                    var userPrestador = _context.Prestadores
                    .FirstOrDefault(m => m.Id_usuario == userId);
                    orcamento.Id_prestador = userPrestador.Id_prestador;
                    orcamento.Status_orcamento = "Reprovado";

                var pedido = _context.Pedidos
                        .FirstOrDefault(m => m.Id_contrato == orcamento.Id_contrato);
                    pedido.Status = StatusServico.Respondido;
                    _context.Update(pedido);

                var orcam = _context.Orcamentos
                    .FirstOrDefault(m => m.Id_prestador == orcamento.Id_prestador&&m.Id_contrato==orcamento.Id_contrato);


                if (orcam == null)
                {
                    _context.Add(orcamento);
                    //await _context.SaveChangesAsync();
                }
                else
                {
                    orcam.Preco = orcamento.Preco;
                    _context.Update(orcam);
                   // _context.SaveChangesAsync();
                }

                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(OrcamentoRespondido));
                }

            return View(orcamento);
        }

        // GET: Usuarios/Create
        public IActionResult OrcamentoRespondido()
        {            
            return View();
        }

    }
}
