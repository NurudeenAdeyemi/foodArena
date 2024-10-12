using foodArena.Models;
using Microsoft.AspNetCore.Mvc;

namespace foodArena.Controllers
{
    public class FoodMenusController : Controller
    {
        //get restaurant food menus
        public IActionResult Index(string restaurantName)
        {
            //filtering the foodmenus with restaurant name
            var foodMenus = FoodMenu.FoodMenusList.Where(x => x.RestaurantName == restaurantName).ToList();

            return View(foodMenus);
        }
    }
}
