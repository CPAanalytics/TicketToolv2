using System.Windows.Controls;

using TicketToolv2.ViewModels;

namespace TicketToolv2.Views;

public partial class ContentPage : Page
{
    public ContentPage(ContentViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
