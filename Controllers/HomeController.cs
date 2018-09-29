using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap01.Models;
using Fiap01.Data;

namespace Fiap01.controllers
{
    public class HomeController : Controller
    {

        private PerguntasContext _context;

        public HomeController(PerguntasContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //ViewBag.Nome = "Carlos Eduardo de Souza";
            //ViewData["nomeDoAluno"] = $"outro nome {DateTime.Now}"; 
        

            //var pergunta = new Pergunta()
            //{
            //    Id = 1,
            //    Descricao = "Que dia é hoje"
            //};

            return View(_context.Perguntas.ToList());
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Pergunta pergunta)
        {

            if (ModelState.IsValid)
            {
                _context.Perguntas.Add(pergunta);
                await _context.SaveChangesAsync();

                var a = pergunta;

            }
            return View();
        }

      
    }
}
