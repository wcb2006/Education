using Persistance;

namespace Application;

public interface IService
{
    IList<string> FetchSchoolData();
    void SaveSchoolData(SchoolData schooldata);
    SchoolData GetSchoolData();
}
