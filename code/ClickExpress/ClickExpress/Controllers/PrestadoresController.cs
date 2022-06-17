using ClickExpress.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ClickExpress.Controllers
{
    public class PrestadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrestadoresController(ApplicationDbContext context)
        {
            _context = context;
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
        public async Task<IActionResult> EditProfile([Bind("Id_usuario,Nome,Email,Tel,Senha,Cep,Cidade,Logradouro,Bairro,UF,Num_endereco,Cpf_Cnpj,Perfil,Veiculo")] Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    prestador.Senha = BCrypt.Net.BCrypt.HashPassword(prestador.Senha);
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    prestador.Id_usuario = Convert.ToInt32(userId);
                    prestador.Perfil = "Prestador";

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

                return RedirectToAction("EdicaoConcluida", "Usuarios");
            }

            return View(prestador);
        }

        private bool PrestadorExists(int id)
        {
            return _context.Prestadores.Any(e => e.Id_usuario == id);
        }
    }
}
