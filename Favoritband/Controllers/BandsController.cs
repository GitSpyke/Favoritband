using Favoritband.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favoritband.Controllers
{

    public class BandsController : Controller
    {
        BandService service = new BandService();

        [Route("")]
        public IActionResult Index()
        {
            var bands = service.GetAllBands();
            return View(bands);
        }
        [Route("bands/{Id}")]
        public IActionResult Description(int id)
        {
            var band = service.GetBandById(id);
            return View(band);
        }
    }
}
