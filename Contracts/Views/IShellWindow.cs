using System.Windows.Controls;

using MahApps.Metro.Controls;

namespace TicketToolv2.Contracts.Views;

public interface IShellWindow
{
    Frame GetNavigationFrame();

    void ShowWindow();

    void CloseWindow();

    Frame GetRightPaneFrame();

    SplitView GetSplitView();
}
