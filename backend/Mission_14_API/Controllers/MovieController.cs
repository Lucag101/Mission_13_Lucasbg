using Microsoft.AspNetCore.Mvc;
using Mission_14_API.Models;
using System.Security.Cryptography.X509Certificates;

namespace Mission_14_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;
        public MovieController(MovieDbContext temp)
        {
            context = temp;
            
        }
        public IEnumerable<MovieCollection> Get()
        {
            var x = context.Movies.ToArray()
                ;
            return x;
        }


    }
}
