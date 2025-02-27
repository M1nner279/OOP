using System.Collections.ObjectModel;
using laboop.Models;

namespace laboop.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public string Welcome { get; } = "Меню ресторана";
        public ObservableCollection<MenuItem> MenuItems { get; } = (Menu.Items);
        
    }
}