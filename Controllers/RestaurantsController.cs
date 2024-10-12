using foodArena.Models;
using Microsoft.AspNetCore.Mvc;

namespace foodArena.Controllers
{
    public class RestaurantsController : Controller
    {
        //get all restaurants
        public IActionResult Index()
        {
            var restaurants = Restaurant.RestaurantsList;
            return View(restaurants);
        }

    }
}
