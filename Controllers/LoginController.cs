using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreGeneratedDocument;
using Bibliotec.Contexts;
using Bibliotec.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bibliotec.Controllers
{
    [Route("[controller]")]
    public class Login : Controller
    {
        private readonly ILogger<Login> _logger;

        public Login(ILogger<Login> logger)
        {
            _logger = logger;
        }


        Context context = new Context();


        public IActionResult Index()
        {
            return View();
        }
        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
// Criar duas variaveis para armazenar as informacoes do formulario 
        string emailInformado = form ["Email"];
        string senhaInformado = form ["Senha"];
            
        // //Busca no banco de dados

        Usuario usuarioBuscado = context.Usuario.FirstOrDefault
        (usuario => usuario.Email == emailInformado && usuario.Senha == senhaInformado)!;
        
        List<Usuario>listaUsuario = context.Usuario.ToList();

        foreach (Usuario usuario_ in  listaUsuario)
        {
            if(usuario_.Email == emailInformado && usuario_.Senha == senhaInformado)
            {

            } else {

            }
        }

        if (usuarioBuscado == null)
        {
            Console.WriteLine($"Dados invalidos! ");
            return LocalRedirect("~");

        } else {
            Console.WriteLine(@"  
            *-----------------------------*
            |          Bem-Vindo          |
            *-----------------------------*  
            ");
            return LocalRedirect("~/Livro");
            
        }


        
    return View();
        }

        
    }
}