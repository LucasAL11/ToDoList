using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ToDoListAvalonia.Views;

public partial class ToDoListView : UserControl
{
    public ToDoListView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}