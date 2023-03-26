using System.Windows.Controls;

using Microsoft.Web.WebView2.Core;

using TicketToolv2.ViewModels;

namespace TicketToolv2.Views;

public partial class HTMLPage : Page
{
    private readonly HTMLViewModel _viewModel;

    public HTMLPage(HTMLViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        _viewModel = viewModel;
        _viewModel.Initialize(webView);
    }

    private void OnNavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        => _viewModel.OnNavigationCompleted(sender, e);
}
