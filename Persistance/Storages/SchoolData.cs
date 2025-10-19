using System;
using Domain;
using Domain.Models;

namespace Persistance;

public class SchoolData
{
    public List<Courses>? Courses { get; set; }
    public List<Students>? Students { get; set; } 
    public List<Teachers>? Teachers { get; set; }
    public List<EducationLeader>? EducationLeader { get; set; }
    public List<Adminstrator>? Adminstrators { get; set; }
}
