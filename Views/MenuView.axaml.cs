using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MenuApp.ViewModels;

namespace MenuApp.Views;

public partial class MenuView : Window
{
    public MenuView()
    {
        InitializeComponent();
        DataContext = new MenuViewModel();
    }
}