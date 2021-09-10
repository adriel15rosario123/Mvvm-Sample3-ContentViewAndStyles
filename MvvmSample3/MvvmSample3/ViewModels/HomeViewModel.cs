using MvvmSample3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvvmSample3.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public MenuOption Option1 { get; }
        public MenuOption Option2 { get; }
        public MenuOption Option3 { get; }
        public MenuOption Option4 { get; }
        public MenuOption Option5 { get; }
        public MenuOption Option6 { get; }

        public HomeViewModel()
        {
            Option1 = new MenuOption("bar","Bars and Hotels","42 place");
            Option2 = new MenuOption("dining","Fine dining","15 place");
            Option3 = new MenuOption("coffee","Cafes","28 place");
            Option4 = new MenuOption("nearby","Nearby","34 place");
            Option5 = new MenuOption("fastfood", "Fast Foods", "29 place");
            Option6 = new MenuOption("food", "Featured Food", "25 place");
        }
    }
}
