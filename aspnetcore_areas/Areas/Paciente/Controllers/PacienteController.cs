﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnetcore_areas.Areas.Paciente.Controllers
{
    [Area("Paciente")]
    public class PacienteController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Paciente/Index");
        }
    }
}
