using System;
using Persistance.Interfaces;

namespace Persistance.Storages;

public class JsonStorage : IStorage
{
    public string ReadFile(string path)
    {
        return File.ReadAllText(path);
    }

    public void WriteLine(string path, string data)
    {
        File.WriteAllText(path, data);
    }
}
