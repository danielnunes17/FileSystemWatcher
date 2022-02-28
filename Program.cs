var path = @"C:\Work\C#\streams\directry_and_directory_info\Globo";
using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine("Pressione [ENTER] para finalizar");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
     Console.WriteLine($"O arquivo foi criado{e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"O arquivo foi excluido{e.Name}");
}


void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}