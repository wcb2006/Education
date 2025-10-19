using System.ComponentModel.Design;
using Domain;
using Domain.Models;
using Application;
using Persistance;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace Client;

class Program
{
    static void Main()
    {
        Service service = new($"{Environment.CurrentDirectory}/Data/Schooldata.json");
        // Skapa exempeldata
        var Hej = new Students
        {
            FirstName = "HGej",
            LastName = "Hej",
            PhoneNumber = "123-125 54 54",
            Address = "Håkan gatan 12",
            ZipCode = "213 53",
            City = "Malmö",
        };

        var Hans = new Teachers
        {
            FirstName = "Hans",
            LastName = "Peterson",
            PhoneNumber = "070-125 24 12",
            Address = "Hans gatan 12",
            ZipCode = "213 53",
            City = "Stockholm",
            Subjects = "Matematik"
        };

        var matematik = new Courses
        {
            CourseNumber = "12411",
            Title = "Matematik",
            StartDate = new DateTime(2025, 8, 20),
            EndDate = new DateTime(2026, 1, 10),
            TimeLength = new TimeSpan(6, 30, 0),
            Distance = false,
            Students = [Hej],
            Resposible = Hans
        };

        var William = new EducationLeader
        {
            FirstName = "William",
            LastName = "Borg",
            PhoneNumber = "070-125 24 12",
            Address = "Hans gatan 12",
            ZipCode = "213 53",
            City = "Stockholm",
            EmploymentDate = new DateTime(2023, 9, 14)

        };

        var Peter = new Adminstrator
        {
            FirstName = "Peter",
            LastName = "Japp",
            PhoneNumber = "076-532 54 12",
            Address = "gatan 12",
            ZipCode = "224 53",
            City = "Örebro"
        };

        var schoolData = new SchoolData
        {
            Teachers = [Hans],
            Adminstrators = [Peter],
            Courses = [matematik],
            Students = [Hej],
            EducationLeader = [William]
        };

        service.SaveSchoolData(schoolData);

        while (true)
        {
            Console.Write("x -> Exit | s -> List Students | c -> List Courses: ");
            string input = Console.ReadLine()!;
            if (input == "s")
            {
                foreach (var item in schoolData.Students)
                {
                    Console.WriteLine(item);
                }
            }
            else if (input == "c")
            {
                foreach (var item in schoolData.Courses)
                {
                    Console.WriteLine(item);
                }
            }
            else if (input == "x")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

    }
}
