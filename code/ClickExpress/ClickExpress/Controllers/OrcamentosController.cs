﻿using System;
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

        // GET: Orcamentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orcamentos.ToListAsync());
        }

        // GET: Orcamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orcamentos
                .FirstOrDefaultAsync(m => m.Id_orcamento == id);
            if (orcamento == null)
            {
                return NotFound();
            }

            return View(orcamento);
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

                    var pedido = _context.Pedidos
                        .FirstOrDefault(m => m.Id_contrato == orcamento.Id_contrato);
                    pedido.Status = StatusServico.Respondido;
                    _context.Update(pedido);

                var orcam = _context.Orcamentos;

                if(orcam !=null)
                {
                    foreach (var aux in orcam)
                    {
                        if(aux.Id_contrato == orcamento.Id_contrato && aux.Id_prestador == orcamento.Id_prestador)
                        {
                            orcam.Preco = orcamento.Preco;
                            _context.Update(orcam);
                        }
                    }
                }
                        //.FirstOrDefault(m => m.Id_prestador == orcamento.Id_prestador);

                if(orcam == null)
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

        // GET: Orcamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orcamentos.FindAsync(id);
            if (orcamento == null)
            {
                return NotFound();
            }
            return View(orcamento);
        }

        // POST: Orcamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_orcamento,Id_contrato,Id_prestador,Preco")] Orcamento orcamento)
        {
            if (id != orcamento.Id_orcamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orcamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrcamentoExists(orcamento.Id_orcamento))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(orcamento);
        }

        // GET: Orcamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orcamentos
                .FirstOrDefaultAsync(m => m.Id_orcamento == id);
            if (orcamento == null)
            {
                return NotFound();
            }

            return View(orcamento);
        }

        // POST: Orcamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orcamento = await _context.Orcamentos.FindAsync(id);
            _context.Orcamentos.Remove(orcamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrcamentoExists(int id)
        {
            return _context.Orcamentos.Any(e => e.Id_orcamento == id);
        }


        // GET: Usuarios/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        public async Task<IActionResult> Aceitar(int? id_orcam)
        {
            if (id_orcam == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Usuarios.FindAsync(id_orcam);
            if (orcamento == null)
            {
                return NotFound();
            }
            return View(orcamento);
        }
    }
}
