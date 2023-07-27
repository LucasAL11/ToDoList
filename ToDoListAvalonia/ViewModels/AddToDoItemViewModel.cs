using System.Reactive;
using ReactiveUI;
using ToDoListAvalonia.Models;

namespace ToDoListAvalonia.ViewModels;

public class AddItemViewModel : ViewModelBase
{
    private string _title = string.Empty;

    public ReactiveCommand<Unit, ToDoItemModel> AddCommand { get; }
    public ReactiveCommand<Unit, Unit> CancelCommand { get; }

    public AddItemViewModel()
    {
        var isValidObservable  = this.WhenAnyValue(
            x => x.Title,
            x => !string.IsNullOrEmpty(x));

        AddCommand = ReactiveCommand.Create(
            () => new ToDoItemModel {Title = Title}, isValidObservable);
        CancelCommand = ReactiveCommand.Create(() => { });

    }

    public string Title
    {
        get => _title;
        set => this.RaiseAndSetIfChanged(ref _title, value);
    }
}