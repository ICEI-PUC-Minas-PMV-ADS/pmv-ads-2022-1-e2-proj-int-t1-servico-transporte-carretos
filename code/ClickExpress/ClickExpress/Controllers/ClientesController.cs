﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClickExpress.Models;

namespace ClickExpress.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        /*public async Task<IActionResult> Index()
        {
            return View(await _context.Cliente.ToListAsync());
        }*/

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_cliente,Id_usuario,Nome,Email,Tel,Senha,Cep,Cidade,Logradouro,UF,Bairro,Num_endereco,Cpf_Cnpj,Perfil,Veiculo")] Cliente cliente)
        {
            if (_context.Usuarios.Any(c => c.Email == cliente.Email))
            {
                ModelState.AddModelError("Email", $"Esse Email já está registrado.");
            }

            if (ModelState.IsValid)
            {
                cliente.Perfil = "Cliente";
                cliente.Senha = BCrypt.Net.BCrypt.HashPassword(cliente.Senha);
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                //return RedirectToAction("Index", "Usuarios");
                return RedirectToAction("CadastroConcluido", "Usuarios");

            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_cliente,Id_usuario,Nome,Email,Tel,Senha,Cep,Cidade,Logradouro,UF,Bairro,Num_endereco,Cpf_Cnpj,Perfil,Veiculo")] Cliente cliente)
        {
            if (id != cliente.Id_usuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cliente.Perfil = "Cliente";
                    cliente.Senha = BCrypt.Net.BCrypt.HashPassword(cliente.Senha);
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id_usuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
                //return RedirectToAction("Index", "Usuarios");
                return RedirectToAction("CadastroConcluido", "Usuarios");
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            //return RedirectToAction("Index", "Usuarios");
            return RedirectToAction("CadastroConcluido", "Usuarios");
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id_usuario == id);
        }
    }
}
