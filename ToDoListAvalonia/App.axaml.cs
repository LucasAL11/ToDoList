using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ToDoListAvalonia.Services;
using ToDoListAvalonia.ViewModels;
using ToDoListAvalonia.Views;

namespace ToDoListAvalonia;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(new ToDoListServices()),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}