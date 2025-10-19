using System.Text.Encodings.Web;
using System.Text.Json;

using Persistance;
using Domain;
using Persistance.Storages;
using Domain.Models;

namespace Application;

public class Service(string path) : IService
{
    private readonly string _path = path;
    private readonly JsonStorage _jsonstorage = new();
    private JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true
    };



    public IList<string> FetchSchoolData()
    {
        FileStorage filestorage = new();
        string file = filestorage.ReadFile(_path);
        return [];
    }

    public SchoolData GetSchoolData()
    {
        throw new NotImplementedException();
    }

    public void SaveSchoolData(SchoolData schooldata)
    {
        var json = JsonSerializer.Serialize(schooldata, _options);
        _jsonstorage.WriteLine(_path, json);
    }

    public void SaveSchoolData(Teachers teacher)
    {
        throw new NotImplementedException();
    }
}
