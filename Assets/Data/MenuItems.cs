using BookHaven.Screens;

namespace BookHaven.Assets.Data
{
    public static class MenuItems
    {
        public static readonly MenuList menu = new MenuList
        {
            CashierMenuList = new List<MenuItem>
            {
                new MenuItem { Icon = "A", Label = "Dashboard", Form = new LoadingScreen() }
            },
            AdminMenuList = new List<MenuItem>
            {
                new MenuItem { Icon = "B", Label = "Dashboard", Form = new LoadingScreen() }
            }
        };
    }
    public class MenuItem
    {
        public string Icon { get; set; }
        public string Label { get; set; }
        public Form Form { get; set; } // Assuming this refers to a Windows Form
    }
    public class MenuList
    {
        public List<MenuItem> CashierMenuList { get; set; }
        public List<MenuItem> AdminMenuList { get; set; }
    }


}