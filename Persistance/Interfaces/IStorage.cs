using System;

namespace Persistance.Interfaces;

public interface IStorage
{
    void WriteLine(string path, string data);
    string ReadFile(string path);
}
