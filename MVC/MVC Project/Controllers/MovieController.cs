using Core.Contracts.Service;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class MovieController : Controller
    {

        IMovieServiceAsync service;

        public MovieController(IMovieServiceAsync _service)
        {
            service = _service;
        }

        public IActionResult Index(string name)
        {
            Console.WriteLine("name index: " + name); // test to see if I can detect name, can be used to navigate through details
            return View();
        }

        public IActionResult List(string name)
		{
            //int pages = 4;
            //int perPage = 3;
            Task<IEnumerable<Movie>> results = service.GetAllMoviesAsync();
            List<Movie> dataSet = results.Result.ToList();
            //List<List<Movie>> paginatedMovies = PaginatedResults(dataSet, perPage);
            Console.WriteLine("name list: " + name);
            return View(dataSet);
        }

        public IActionResult Details(int movieId)
		{
            Task<Movie> result = service.GetByIdAsync(movieId);
            return View(result.Result);
		}

        private List<List<Movie>> PaginatedResults(List<Movie> dataSet, int perPage)
		{
            List<List<Movie>> paginated = new List<List<Movie>>();
            int counter = 0;
            List<Movie> sub = null;
            foreach (var m in dataSet)
			{
                if (counter % perPage == 0)
				{
                    if (sub != null)
                        paginated.Add(sub);
                    sub = new List<Movie>();
				}
                    
                sub.Add(m);
			}
            if (sub.Count != 0)
                paginated.Add(sub);

            return paginated;
		}
    }
}
