using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClickExpress.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace ClickExpress.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        // GET: Usuarios/Create
        public IActionResult CadastroConcluido()
        {
            ViewBag.Message = "Cadastro concluido :), seja muito bem vindo! Efetue Login para iniciar a navegação.";
            return View();
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_usuario,Perfil,Nome,Email,Tel,Senha,Cep,Cidade,Logradouro,Bairro,UF,Num_endereco,Cpf_Cnpj,Veiculo")] Usuario usuario)
        {
            if (_context.Usuarios.Any(c => c.Email == usuario.Email))
            {
                ModelState.AddModelError("Email", $"Esse Email já está registrado.");
            }


            if (ModelState.IsValid)
            {
                // Item inserido 
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CadastroConcluido));

            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);

            ViewBag.Message = "Usuário removido com sucesso!";
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id_usuario,Nome,Email,Tel,Senha,Cep,Cidade,Logradouro,Bairro,UF,Num_endereco,Cpf_Cnpj,Perfil")] Usuario usuario)
        {
            if (id != usuario.Id_usuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Item inserido 
                    usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                    _context.Update(usuario);

                    //ViewBag.Message = "Alterações excutadas com sucesso!";
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id_usuario))
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
            return View(usuario);
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
                    _context.Update(usuario);

                    //ViewBag.Message = "Alterações excutadas com sucesso!";
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id_usuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(EdicaoConcluida));
                //return RedirectToAction(nameof(Index));
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult EdicaoConcluida()
        {
            ViewBag.Message = "Alteracao efetuada com sucesso! :)";
            return View();
        }


        public IActionResult Historico()
        {
            return View();
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // Login: Usuarios - item adicionado
        public IActionResult Login()
        {
            return View();
        }

        // Login: Usuarios - item adicionado
        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Usuario usuario)
        {
            //faz consulta no banco de dados dos dados inseridos
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == usuario.Email);

            //condição usuário inxistente
            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
            }

            //comparação da senha preenchida com a armazenada no banco de dados
            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, user.Senha);

            //condição usuário existente
            if (isSenhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Id_usuario.ToString()),
                    new Claim(ClaimTypes.Role, user.Perfil.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7), //mantém login por 7 dias
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/"); //redicionamento do usuário, após auteticação, para página Home

            }

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Usuarios");
        }

        // Login: Usuarios - item adicionado
        public IActionResult MinhaArea()
        {
            return View();
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Relatorios(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(t => t.Pedidos)
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Details/5
        //Relatorio usuario logado todos os status
        public async Task<IActionResult> RelatoriosUser()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int id = Convert.ToInt32(userId);

            var usuario = await _context.Usuarios
                .Include(t => t.Pedidos)
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Details/5
        //Relatorio usuario logado status Pendente
        public async Task<IActionResult> RelatoriosUserPendente()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int id = Convert.ToInt32(userId);

            var usuario = await _context.Usuarios
                .Include(t => t.Pedidos)
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Details/5
        //Relatorio usuario logado status Respondido
        public async Task<IActionResult> RelatoriosUserRespondido()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int id = Convert.ToInt32(userId);

            var usuario = await _context.Usuarios
                .Include(t => t.Pedidos)
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Details/5
        //Relatorio usuario logado status Aceito
        public async Task<IActionResult> RelatoriosUserAceito()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int id = Convert.ToInt32(userId);

            var usuario = await _context.Usuarios
                .Include(t => t.Pedidos)
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Details/5
        //Relatorio usuario logado status Finalizado
        public async Task<IActionResult> RelatoriosUserFinalizado()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int id = Convert.ToInt32(userId);

            var usuario = await _context.Usuarios
                .Include(t => t.Pedidos)
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id_usuario == id);
        }
    }
}
