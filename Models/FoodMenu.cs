namespace foodArena.Models
{
    public class FoodMenu
    {
        //name, description, image, price
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string RestaurantName { get; set; }

        //
        // FoodMenu list with 10 items, across all restaurants
        public static List<FoodMenu> FoodMenusList = new List<FoodMenu>
        {
            // Jollof & co
            new FoodMenu { Name = "Rice and Beef", Description = "Enjoy rice with Beef", Image = "http://res.cloudinary.com/cokitchen/image/upload/q_auto:good/v1629810276/optimized_uz2czw.jpg", Price = 10.99m, RestaurantName = "Jollof & co" },
            new FoodMenu { Name = "Jollof Rice", Description = "Spicy Jollof rice", Image = "http://res.cloudinary.com/cokitchen/image/upload/q_auto:good/v1664731689/grf0uwbvcrlsfxmqszi1.jpg", Price = 8.99m, RestaurantName = "Jollof & co" },
            new FoodMenu { Name = "Plantain and Beans", Description = "Ripe plantain served with beans", Image = "http://res.cloudinary.com/cokitchen/image/upload/q_auto:good/v1650275264/tpn6mlsjpi6qqtp5cptu.jpg", Price = 7.99m, RestaurantName = "Jollof & co" },

            // Sweet Treats
            new FoodMenu { Name = "Cupcake Delight", Description = "Tasty cupcakes with buttercream frosting", Image = "http://res.cloudinary.com/cokitchen/image/upload/v1656451850/a7dt0h4i1w9d5qgen3b4.jpg", Price = 5.99m, RestaurantName = "Sweet Treats" },
            new FoodMenu { Name = "Chocolate Cake", Description = "Rich chocolate cake topped with ganache", Image = "http://res.cloudinary.com/cokitchen/image/upload/v1656451703/ufadtikrypw34qlw2rdo.jpg", Price = 6.99m, RestaurantName = "Sweet Treats" },
            new FoodMenu { Name = "Puff-Puff", Description = "Golden fried dough balls", Image = "http://res.cloudinary.com/cokitchen/image/upload/v1656452010/aljpcwrgzgzd7dkrhaas.jpg", Price = 3.99m, RestaurantName = "Sweet Treats" },

            // Wing Kings
            new FoodMenu { Name = "Chicken Wings", Description = "Crispy chicken wings with special sauce", Image = "http://res.cloudinary.com/cokitchen/image/upload/v1629810157/optimized_azdgxj.jpg", Price = 12.99m, RestaurantName = "Wing Kings" },
            new FoodMenu { Name = "Spicy Drumsticks", Description = "Spicy grilled chicken drumsticks", Image = "http://res.cloudinary.com/cokitchen/image/upload/v1629807939/optimized_nojy3n.jpg", Price = 11.99m, RestaurantName = "Wing Kings" },
    
            // Frankies
            new FoodMenu { Name = "Burger and Fries", Description = "Classic burger with fries", Image = "http://res.cloudinary.com/cokitchen/image/upload/v1650274567/a6uvjzziqz4fzig7wqp2.jpg", Price = 9.99m, RestaurantName = "Frankies" },
            new FoodMenu { Name = "Hotdog Combo", Description = "Hotdog served with soda and fries", Image = "http://res.cloudinary.com/cokitchen/image/upload/v1650274534/yuakf5z87mzwbatdfumi.jpg", Price = 8.99m, RestaurantName = "Frankies" }
        };
    }
}
