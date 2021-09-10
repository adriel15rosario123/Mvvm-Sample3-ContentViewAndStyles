using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmSample3.Models
{
    public class MenuOption
    {

        public MenuOption(string image, string title, string detail)
        {
            Image = image;
            Title = title;
            Detail = detail;
        }
        public string Image { get; }
        public string Title { get; }
        public string Detail { get; }

    }
}
