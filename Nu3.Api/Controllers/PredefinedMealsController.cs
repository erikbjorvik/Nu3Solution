using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nu3.Models;

namespace Nu3.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
    public class PredefinedMealsController : Controller
    {
		
        static HttpClient client = new HttpClient();

        [Produces("application/json")]
        [HttpGet]
        public JsonResult Index()
        {
            List<PredefinedMeal> list = new List<PredefinedMeal>();
            list.Add(new PredefinedMeal { Id = "123", Name = "Grandiz", ImagePath = "https://g.acdn.no/obscura/API/dynamic/r1/pp/tr_480_427_l_f/0000/polopoly_fs/1.7021970!/image/2040133393.jpg?chk=59522B" });
            list.Add(new PredefinedMeal { Id = "1234", Name = "Koteletter med erter", ImagePath = "https://g.acdn.no/obscura/API/dynamic/r1/pp/tr_480_427_l_f/0000/polopoly_fs/1.7021970!/image/2040133393.jpg?chk=59522B" });
            list.Add(new PredefinedMeal { Id = "12345", Name = "Grot med spy", ImagePath = "https://g.acdn.no/obscura/API/dynamic/r1/pp/tr_480_427_l_f/0000/polopoly_fs/1.7021970!/image/2040133393.jpg?chk=59522B" });

            return Json(list);
        }
    }
}
