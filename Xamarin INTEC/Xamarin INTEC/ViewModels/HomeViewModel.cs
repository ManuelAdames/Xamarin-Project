using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_INTEC.Models;

namespace Xamarin_INTEC.ViewModels
{
    public class HomeViewModel
    {
        public MenuOption BarsAndHotels { get; set; } = new MenuOption();
        public MenuOption FineDining { get; set; } = new MenuOption();
        public MenuOption Cafes { get; set; } = new MenuOption();
        public MenuOption Nearby { get; set; } = new MenuOption();
        public MenuOption FastFoods { get; set; } = new MenuOption();
        public MenuOption FeaturedFoods { get; set; } = new MenuOption();

        public MenuOption HomeOption { get; set; } = new MenuOption();
        public MenuOption DiscoveryOption { get; set; } = new MenuOption();
        public MenuOption BookmarkOption { get; set; } = new MenuOption();
        public MenuOption TopFoodsOption { get; set; } = new MenuOption();
        public MenuOption ProfileOption { get; set; } = new MenuOption();


        public HomeViewModel()
        {
            BarsAndHotels.Title = "Bars And Hotels"; BarsAndHotels.Image = "beerimage.png";
            FineDining.Title = "Fine Dining"; FineDining.Image = "Dinning.png";
            Cafes.Title = "Cafes"; Cafes.Image = "cafe.png";
            Nearby.Title = "Bars And Hotels"; Nearby.Image = "gpsmap.png";
            FastFoods.Title = "Fast Foods"; FastFoods.Image = "fastfood2.png";
            FeaturedFoods.Title = "Featured Foods"; FeaturedFoods.Image = "pizza.png";

            HomeOption.Title = "Home"; HomeOption.Image = "home.png";
            DiscoveryOption.Title = "Discovery"; DiscoveryOption.Image = "GPS.png";
            BookmarkOption.Title = "Bookmark"; BookmarkOption.Image = "bookmark.png";
            TopFoodsOption.Title = "Top Foods"; TopFoodsOption.Image = "trophy.png";
            ProfileOption.Title = "Profile"; ProfileOption.Image = "profile.png";
        }
    }
}
