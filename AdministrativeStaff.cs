
using System;

public class AdministrativeStaff : Staff  //inherits from Staff class
{
    public string JobRole { get; set; } //it's a property for AdministrativeStaff class

    public AdministrativeStaff(string name, int staffId,
                               string department, string jobRole)
        : base(name, staffId, department)  // constructor for AdministrativeStaff class, calling base constructor of Staff class
    {
        JobRole = jobRole;
    }

    public override void PerformDuty() //Method overriding to provide specific implementation for AdministrativeStaff class
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
