
using System;

public class AdministrativeStaff : Staff
{
    public string JobRole { get; set; }

    public AdministrativeStaff(string name, int staffId,
                               string department, string jobRole)
        : base(name, staffId, department)
    {
        JobRole = jobRole;
    }

    public override void PerformDuty()
    {
        Console.WriteLine("Administrative Staff is managing hospital records.");
    }

    public void DisplayAdmin()
    {
        DisplayInfo();
        Console.WriteLine("Job Role: " + JobRole);
        PerformDuty();
    }
}
