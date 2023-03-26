using System.Windows.Controls;

using TicketToolv2.ViewModels;

namespace TicketToolv2.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
