using System;

namespace Domain.Models;

public class Teachers : PersonInfo
{
    public string? Subjects { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}. Subject: {Subjects}";
    }
}
