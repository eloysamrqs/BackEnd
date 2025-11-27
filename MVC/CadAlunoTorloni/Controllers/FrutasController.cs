using CadAlunoTorloni.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadAlunoTorloni.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }



        // Criar uma listar de Frutas 
        private static List<Fruta> frutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Laranja", Cor = "Laranja", Categoria = "Cítrica" },
            new Fruta{ Id = 2, Nome = "Limão", Cor = "Verde", Categoria = "Cítrica" },
            new Fruta{ Id = 3, Nome = "Abacaxi", Cor = "Amarelo", Categoria = "Tropical" },
            new Fruta{ Id = 4, Nome = "Manga", Cor = "Amarelo", Categoria = "Tropical" },
            new Fruta{ Id = 5, Nome = "Uva", Cor = "Roxo", Categoria = "Tropical" }
        };


    

        public IActionResult Index()
        {
            return View(frutas);
        }

        // Action para exibir o formulário de criação de nova fruta - fORMULARIO (Viewl)
        public IActionResult Create()
        {
            return View();
        }

        // Método para salvar a nova fruta, sem View (apenas lógica)
        [HttpPost]
        public IActionResult Create(Fruta fruta)
        {
            // salvar no array
            frutas.Add(fruta);
            fruta.Id = frutas.Max(f => f.Id) + 1;
            //redimensionae o usuario para o Index
            return RedirectToAction("Index");
        }

        public IActionResult FrutasCitricas()
        {
            return View();
        }

        public IActionResult FrutasTropicais()
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