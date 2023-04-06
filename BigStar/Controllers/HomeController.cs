using BigStar.Data;
using BigStar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BigStar.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ApplicationContext _applicationContext;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment, ApplicationContext applicationContext)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            var model = _applicationContext.Movies.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Like(int id)
        {
            var movie = _applicationContext.Movies.Find(id);
            if(movie != null)
            {
                movie.LikeCount++;
                _applicationContext.Movies.Update(movie);
                _applicationContext.SaveChanges();
            }
            return Ok();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}