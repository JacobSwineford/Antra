using Core.Contracts.Service;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class CastController : Controller
    {
        ICastServiceAsync service;
        public CastController(ICastServiceAsync _service)
        {
            service = _service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Task<IEnumerable<Cast>> cast = service.GetCastDetails();
            IEnumerable<Cast> result = cast.Result;
            List<CastData> model = new List<CastData>();
            foreach (var c in result)
            {
                CastData ca = new CastData();
                ca.Name = c.Name;
                ca.Id = c.Id;
                ca.Gender = c.Gender;
                model.Add(ca);
            }
            return View(model);
        }
    }
}
