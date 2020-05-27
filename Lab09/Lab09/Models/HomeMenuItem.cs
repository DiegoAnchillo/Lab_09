using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        TapDemo,
        PinchDemo,
        PanDemo,
        SwipeDemo,
        SwipeBinding
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
