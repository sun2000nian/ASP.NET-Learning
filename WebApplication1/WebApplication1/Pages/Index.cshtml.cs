using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileMovie ProductService;
        public IEnumerable<Movie> movies { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileMovie productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            movies = ProductService.GetMovies();
        }
    }
}
