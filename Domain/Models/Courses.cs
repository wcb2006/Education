using Domain.Models;

namespace Domain;

public class Courses
{
    public string CourseNumber { get; set; }
    public string Title { get; set; }
    public TimeSpan TimeLength { get; set; } 
    public DateTime StartDate { get; set; } 
    public DateTime EndDate { get; set; } 
    public bool Distance { get; set; }
    public IList<Students> Students { get; set; }
    public Teachers Resposible { get; set; } 

    public override string ToString()
    {
        return $"{CourseNumber}: {Title}, {StartDate:yyyy-MM-dd} - {EndDate:yyyy-MM-dd}, " +
               $"Distance: {Distance}, Students: {Students.Count}";
    }
}
