using ListBoxVirtualizationBug;
using System.Windows;
using System.Windows.Controls;

namespace HandyControlListBoxVirtualizationBug;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly StackPanel[] _stackPanels;

    public MainWindow()
    {
        InitializeComponent();
        _stackPanels = CreateStackPanels();
    }

    private void ShowListBoxButton_Click(object sender, RoutedEventArgs e)
    {
        new WindowWithListBox(_stackPanels).Show();
    }

    private void ShowListViewButton_Click(object sender, RoutedEventArgs e)
    {
        new WindowWithListView(_stackPanels).Show();
    }

    private static StackPanel[] CreateStackPanels()
    {
        StackPanel[] stackPanels = new StackPanel[1000];

        for (int i = 0; i < stackPanels.Length; i++)
        {
            StackPanel stackPanel = new();

            stackPanel.Children.Add(new TextBox()
            {
                Text = $"TextBox Item: {i}"
            });

            stackPanel.Children.Add(new Separator());

            stackPanels[i] = stackPanel;
        }

        return stackPanels;
    }
}