namespace foodArena.Models
{
    public class Restaurant
    {
        //- name, short description, full description, image, address, phone number
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


        //create static list of restaurant
        public static List<Restaurant> RestaurantsList = new List<Restaurant>
        {
            new Restaurant {Name = "Jollof & co", ShortDescription = "Everyday Naija favourites", FullDescription = "food vendors, best in Africa", Image = "https://www.getfoodcourt.com/static/media/Chow_AsianMeal.52475107636a8eec95da.webp", Address = "Lagos, Nigeria", PhoneNumber = "0808865676"},
            new Restaurant {Name = "Sweet Treats", ShortDescription = "Sweet Naija favourites", FullDescription = "Sweet vendors, best in Africa", Image = "https://www.getfoodcourt.com/static/media/SweetTreatMeal.e1d683bdc0942cc0cb64.webp", Address = "Lagos, Nigeria", PhoneNumber = "0808865676"},
            new Restaurant {Name = "Wing Kings", ShortDescription = "Good chicken and more", FullDescription = "chicken vendors, best in Africa", Image = "https://www.getfoodcourt.com/static/media/WingKingsMeal.342e1b8cb0368b43b334.png", Address = "Lagos, Nigeria", PhoneNumber = "0808865676"},
            new Restaurant {Name = "Frankies", ShortDescription = "Burgers and Hotdogs", FullDescription = "food vendors, best in Africa", Image = "https://www.getfoodcourt.com/static/media/FrankiesMeal.ebf2b82b93f7aa343f4c.webp", Address = "Lagos, Nigeria", PhoneNumber = "0808865676"}
        };
    }
}
