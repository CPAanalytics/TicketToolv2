using System.Windows.Controls;

using TicketToolv2.ViewModels;

namespace TicketToolv2.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
