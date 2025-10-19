using System;
using System.Runtime.CompilerServices;

namespace Domain.Models;

public class Students : PersonInfo
{
    public string StudentID { get; set; } = Guid.NewGuid().ToString();

    public override string ToString()
    {
        return $"Student: {FirstName} {LastName}. StudentID: {StudentID}";
    }
}

