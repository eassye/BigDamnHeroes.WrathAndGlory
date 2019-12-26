using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BigDamnHeroes.WrathAndGlory.Service;
using Newtonsoft.Json;
using BigDamnHeroes.WrathAndGlory.Service.Models;
using Microsoft.AspNetCore.Cors;

namespace BigDamnHeroes.WrathAndGlory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeciesController : Controller
    {
        private readonly ISpeciesService _speciesService;
        public SpeciesController(ISpeciesService speciesService)
        {
            _speciesService = speciesService;
        }

        [HttpGet]
        public JsonResult GetSpecies()
        {
            return Json(_speciesService.ReturnSpeciesList());
        }
    }
}