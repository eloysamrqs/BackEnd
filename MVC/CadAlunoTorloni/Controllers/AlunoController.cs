using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadAlunoTorloni.Models;
using Microsoft.EntityFrameworkCore;
using CadAlunoTorloni.Models;

namespace CadAlunoTorloni.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger, CadAlunoTorloniContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        private static List<Aluno> Aluno = new List<Aluno>
        {
            new Aluno { Id = 1, Nome = "Laura", Idade = 11, Cpf = "201125" },
            new Aluno { Id = 2, Nome = "Lorenzo", Idade = 23, Cpf = "010100" }
        };

        private readonly CadAlunoTorloniContext _context;

        public async Task<IActionResult> Index()
        {
            var Aluno = await _context.Alunos.ToListAsync(); // Certifique-se de que 'Alunos' está correto
            return View(Aluno);
        }

        [HttpGet]

        // public IActionResult Index()
        // {
        //     return View(Alunos); // Passa a lista de Alunos para a view
        // }




        //Action para cadastrar uma Aluno - Formulário
        public IActionResult Create()
        {
           
            return View();
        }



      
    

        public IActionResult CadastrarAlunos(Aluno aluno)
        {
             return View(Index);
        }


        //método para salvar a Aluno recebida do formulário, sem uma view
        [HttpPost]
                public async Task<IActionResult> Create(Aluno aluno)
        {
           _context.Add(aluno);
           await _context.SaveChangesAsync();
           return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        }
        }