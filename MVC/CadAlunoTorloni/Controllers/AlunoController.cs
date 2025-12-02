using Microsoft.AspNetCore.Mvc;

using CadastroAlunos.Models;
namespace CadastroAlunos.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }
        private static List<Aluno> alunos = new List<Aluno>()
        {
        };
        public IActionResult Index()
        {
            return View(alunos);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            if (alunos.Count > 0)
            {
                aluno.Id = alunos.Max(a => a.Id) + 1;
            }
            else
            {
                aluno.Id = 1;
            }
            alunos.Add(aluno);
            return RedirectToAction("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}