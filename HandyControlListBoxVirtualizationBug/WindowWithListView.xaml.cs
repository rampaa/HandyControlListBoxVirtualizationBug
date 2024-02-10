using System.Windows;
using System.Windows.Controls;

namespace ListBoxVirtualizationBug;

/// <summary>
/// Interaction logic for WindowWithListView.xaml
/// </summary>
public partial class WindowWithListView : Window
{
    public WindowWithListView(StackPanel[] stackPanels)
    {
        InitializeComponent();
        PopupListView.ItemsSource = stackPanels;
    }
}
