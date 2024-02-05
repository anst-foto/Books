namespace Books.MVVM.Models;

public class Book : BaseNotify
{
    private Guid _guid;
    public Guid Guid
    {
        get => _guid; 
        set => SetField(ref _guid, value);
    }
    
    private string? _title;
    public string? Title
    {
        get => _title;
        set => SetField(ref _title, value);
    }
    
    private string? _author;
    public string? Author
    {
        get => _author;
        set => SetField(ref _author, value);
    }
    
    private string? _path;
    public string? Path
    {
        get => _path;
        set => SetField(ref _path, value);
    }
}