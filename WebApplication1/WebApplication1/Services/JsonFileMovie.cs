using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class JsonFileMovie
    {
        public JsonFileMovie(IWebHostEnvironment WebHostEnvironment)
        {
            webHostEnvironment = WebHostEnvironment;
        }

        public IWebHostEnvironment webHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(webHostEnvironment.WebRootPath, "data", "products.json"); }
        }

        public IEnumerable<Movie> GetMovies()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Movie[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        IgnoreReadOnlyProperties = true
                    });
            }
        }
    }
}
