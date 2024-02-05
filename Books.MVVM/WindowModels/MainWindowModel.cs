using System.Collections.ObjectModel;
using Books.MVVM.Models;

namespace Books.MVVM.WindowModels;

public class MainWindowModel : BaseNotify
{
    public ObservableCollection<Book> Books { get; set; }

    private Book _selectedBook;
    public Book SelectedBook
    {
        get => _selectedBook;
        set => SetField(ref _selectedBook, value);
    }

    public MainWindowModel()
    {
        Books = new ObservableCollection<Book>()
        {
            new()
            {
                Guid = Guid.NewGuid(),
                Title = "WPF 4",
                Author = "Adam Natan",
                Path = @"E:\IT\C#\Adam_Natan_-_WPF4_Podrobnoe_rukovodstvo_-_2011.pdf"
            },
            new()
            {
                Guid = Guid.NewGuid(),
                Title = "LINQ",
                Author = "",
                Path = @"E:\IT\C#\LINQ.pdf"
            }
        };
    }
}