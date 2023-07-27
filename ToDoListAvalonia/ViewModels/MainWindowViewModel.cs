using ReactiveUI;
using System;
using System.Reactive.Linq;
using ToDoListAvalonia.Models;
using ToDoListAvalonia.Services;

namespace ToDoListAvalonia.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;
    private ToDoListServices _services;

    public MainWindowViewModel(ToDoListServices services)
    {
        _services = services;
        ToDoList = new ToDoListViewModel(_services.GetItems());
        _contentViewModel = ToDoList;
    }

    public ToDoListViewModel ToDoList { get; }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public void AddItem()
    {
        AddItemViewModel AddItemViewModel = new();
        Observable.Merge(
                AddItemViewModel.AddCommand,
                AddItemViewModel.CancelCommand.Select(_ => (ToDoItemModel?)null))
            .Take(1)
            .Subscribe(newItem =>
            {
                if (newItem != null)
                {
                    ToDoList.ListItems.Add(newItem);
                }

                ContentViewModel = ToDoList;
            });
        ContentViewModel = AddItemViewModel;

    }
}