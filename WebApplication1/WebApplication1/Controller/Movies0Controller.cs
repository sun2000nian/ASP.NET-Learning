using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class Movies0Controller : ControllerBase
    {
        public Movies0Controller(JsonFileMovie productservice)
        {
            this.JsonFileMovieService = productservice;
        }

        public JsonFileMovie JsonFileMovieService { get; }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return JsonFileMovieService.GetMovies();
        }
    }
}
