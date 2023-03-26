using System.Windows.Controls;

using TicketToolv2.ViewModels;

namespace TicketToolv2.Views;

public partial class DataPage : Page
{
    public DataPage(DataViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
