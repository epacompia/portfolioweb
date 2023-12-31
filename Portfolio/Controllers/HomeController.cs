﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Servicios;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        

        public HomeController(ILogger<HomeController> logger ,  IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
       
        }

        public IActionResult Index()
        {
            //ViewBag.Nombre = "Eduardo Pacompía López";
            //ViewBag.Edad = "36";


            //creo mi variable persona que viene de mi modelo
            //var persona= new Persona() { 
            //    Nombre="Eduardo Pacompía López",
            //    Edad=36            
            //};

            //mando esa variable a mi vista,ya no es necesario pasarle el nombre de la vista Index
            //ViewBag.Edad = "36";

            //var repositorioProyectos = new RepositorioProyectos();

            var proyectos= repositorioProyectos.obtenerProyectos().Take(3).ToList();
            
            
            var modelo=new HomeIndexViewModel() 
            { 
                Proyectos=proyectos
            };
            return View(modelo);
        }



        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.obtenerProyectos().Take(3).ToList();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
    
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }
    
    
    }
}