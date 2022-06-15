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
    public class PrestadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrestadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prestadores
       /* public async Task<IActionResult> Index()
        {
            return View(await _context.Prestadores.ToListAsync());
        }*/

        // GET: Prestadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestadores
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (prestador == null)
            {
                return NotFound();
            }

            return View(prestador);
        }

        // GET: Prestadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prestadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_prestador,Veiculo,Id_usuario,Nome,Email,Tel,Senha,Cep,Cidade,Logradouro,UF,Bairro,Num_endereco,Cpf_Cnpj,Perfil")] Prestador prestador)
        {
            if (_context.Usuarios.Any(c => c.Email == prestador.Email))
            {
                ModelState.AddModelError("Email", $"Esse Email já está registrado.");
            }

            if (ModelState.IsValid)
            {
                prestador.Perfil = "Prestador";
                prestador.Senha = BCrypt.Net.BCrypt.HashPassword(prestador.Senha);
                _context.Add(prestador);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                //return RedirectToAction("Index", "Usuarios");
                return RedirectToAction("CadastroConcluido", "Usuarios");
            }
            return View(prestador);
        }

        // GET: Prestadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestadores.FindAsync(id);
            if (prestador == null)
            {
                return NotFound();
            }
            return View(prestador);
        }

        // POST: Prestadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_prestador,Veiculo,Id_usuario,Nome,Email,Tel,Senha,Cep,Cidade,Logradouro,UF,Bairro,Num_endereco,Cpf_Cnpj,Perfil")] Prestador prestador)
        {
            if (id != prestador.Id_usuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    prestador.Perfil = "Prestador";
                    prestador.Senha = BCrypt.Net.BCrypt.HashPassword(prestador.Senha);
                    _context.Update(prestador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestadorExists(prestador.Id_usuario))
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
            return View(prestador);
        }

        // GET: Usuarios/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        public async Task<IActionResult> EditProfile()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int id = Convert.ToInt32(userId);

            //var usuario = await _context.Usuarios.FindAsync(id);

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id_usuario == id);

            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile([Bind("Id_usuario,Nome,Email,Tel,Senha,Cep,Cidade,Logradouro,Bairro,UF,Num_endereco,Cpf_Cnpj,Perfil,Veiculo")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Item inserido 
                    usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    usuario.Id_usuario = Convert.ToInt32(userId);
                    usuario.Perfil = "Prestador";

                    _context.Update(usuario);

                    //ViewBag.Message = "Alterações excutadas com sucesso!";
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestadorExists(usuario.Id_usuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("EdicaoConcluida", "Usuarios");
                //return RedirectToAction(nameof(Index));
            }

            return View(usuario);
        }

        // GET: Prestadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestadores
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (prestador == null)
            {
                return NotFound();
            }

            return View(prestador);
        }

        // POST: Prestadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prestador = await _context.Prestadores.FindAsync(id);
            _context.Prestadores.Remove(prestador);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            //return RedirectToAction("Index", "Usuarios");
            return RedirectToAction("CadastroConcluido", "Usuarios");
        }

        private bool PrestadorExists(int id)
        {
            return _context.Prestadores.Any(e => e.Id_usuario == id);
        }
    }
}
