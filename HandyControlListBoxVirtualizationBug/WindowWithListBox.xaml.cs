using System.Windows;
using System.Windows.Controls;

namespace ListBoxVirtualizationBug;

/// <summary>
/// Interaction logic for WindowWithListBox.xaml
/// </summary>
public partial class WindowWithListBox : Window
{

    public WindowWithListBox(StackPanel[] stackPanels)
    {
        InitializeComponent();
        PopupListBox.ItemsSource = stackPanels;
    }
}
