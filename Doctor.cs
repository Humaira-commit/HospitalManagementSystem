
using System;

public class Doctor : Staff
{
    public string Specialization { get; set; }

    public Doctor(string name, int staffId,
                  string department, string specialization)
        : base(name, staffId, department)
    {
        Specialization = specialization;
    }

    public override void PerformDuty()
    {
        Console.WriteLine("Doctor is checking patients.");
    }

    public void DisplayDoctor()
    {
        DisplayInfo();
        Console.WriteLine("Specialization: " + Specialization);
        PerformDuty();
    }
}
