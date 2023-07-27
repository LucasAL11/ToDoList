using System.Collections.Generic;
using ToDoListAvalonia.Models;

namespace ToDoListAvalonia.Services;

public class ToDoListServices
{
    public IEnumerable<ToDoItemModel> GetItems() => new[]
    {
        new ToDoItemModel { Title = "Marcar medico",  IsCompleted = false },
        new ToDoItemModel { Title = "Marcar medico",  IsCompleted = false },
        new ToDoItemModel { Title = "Marcar medico",  IsCompleted = false },
    };
}