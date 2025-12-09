
using System.Threading.Tasks;
using DevConnect.Context;
using DevConnect.Context;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;


namespace DevConnect.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.UsuarioCadastrado = "";
            TempData["UsuarioCadastrado"] = "";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            // Console.WriteLine($"{form["NomeCompleto"]}");
            // Console.WriteLine($"{form.Files[0].FileName}");
            
           TbUsuario novoUsuario = new TbUsuario
           {
            NomeCompleto = form["NomeCompleto"].ToString(),
            NomeUsuario = form["NomeUsuario"].ToString(),
            Email = form["Email"].ToString(),
            Senha = form["Senha"].ToString()
           };
           if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                var path = Path.Combine(folder, file.FileName);


                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novoUsuario.FotoPerfilUrl = file.FileName;
            }
            else
            {
                novoUsuario.FotoPerfilUrl = "FotoPadrão.png";
            }

            try
            {
                _context.TbUsuario.Add(novoUsuario);
                await  _context.SaveChangesAsync();

                TempData["UsuarioCadastrado"] = "Usuário cadastrado com sucesso!";
                ViewBag.UsuarioCadastrado = "";

                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioCadastrado = "Não cadastrado";
                TempData["UsuarioCadastrado"] = "";
                return View();
            }
            
        }
        public IActionResult Perfil()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}