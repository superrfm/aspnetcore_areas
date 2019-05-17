using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_areas.Areas.Medico.Controllers
{
    [Area("Medico")]
    public class MedicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}