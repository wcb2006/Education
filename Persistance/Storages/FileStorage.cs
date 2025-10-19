using System.Formats.Tar;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.VisualBasic;
using Persistance.Interfaces;
namespace Persistance;

public class Storage : IStorage
{
    public string ReadFile(string path)
    {
        throw new NotImplementedException();
    }

    public void WriteLine(string path, string data)
    {
        File.AppendAllText(path, data);
    }
}
