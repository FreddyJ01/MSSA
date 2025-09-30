//Dependency Injection Demo
public class FileManager
{
    private readonly IStorage _storage;
    public FileManager(IStorage storage) { _storage = storage; }

    public void SaveDocument(string name, string content)
    {
        Console.WriteLine($"[FileManager] Saving document '{name}'...");
        _storage.WriteFile(name, content);
    }

    public void DeleteDocument(string name)
    {
        Console.WriteLine($"[FileManager] Deleting document '{name}'...");
        _storage.DeleteFile(name);
    }
}

public interface IStorage
{
    public void WriteFile(string filename, string content);
    public void DeleteFile(string filename);
}

public class LocalStorage : IStorage
{
    public void WriteFile(string filename, string content)
    {
        Console.WriteLine($"[LocalStorage] '{filename}' saved with content: {content}");
    }

    public void DeleteFile(string filename)
    {
        Console.WriteLine($"[LocalStorage] '{filename}' deleted from disk.");
    }
}

public class RemoteStorage : IStorage
{
    public void WriteFile(string filename, string content)
    {
        Console.WriteLine($"[RemoteStorage] '{filename}' saved with content: {content}");
    }

    public void DeleteFile(string filename)
    {
        Console.WriteLine($"[RemoteStorage] '{filename}' deleted from disk.");
    }
}

class Program
{
    static void Main()
    {
        var localstorage = new LocalStorage();
        var manager = new FileManager(localstorage);
        manager.SaveDocument("report.txt", "Quarterly data...");
        manager.DeleteDocument("report.txt");

        var remotestorage = new RemoteStorage();
        manager = new FileManager(remotestorage);
        manager.SaveDocument("report.txt", "Quarterly data...");
        manager.DeleteDocument("report.txt");
    }
}