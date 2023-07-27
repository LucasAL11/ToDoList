using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToDoListAvalonia.Models;
using ToDoListAvalonia.Services;

namespace ToDoListAvalonia.ViewModels;

public class ToDoListViewModel : ViewModelBase
{
    public ToDoListViewModel(IEnumerable<ToDoItemModel> items)
    {
        ListItems = new ObservableCollection<ToDoItemModel>(items);
    }

    public ObservableCollection<ToDoItemModel> ListItems { get; }
}