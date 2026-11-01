
using System;

public class Nurse : Staff
{
    public string Shift { get; set; }

    public Nurse(string name, int staffId,
                 string department, string shift)
        : base(name, staffId, department)
    {
        Shift = shift;
    }

    public override void PerformDuty()
    {
        Console.WriteLine("Nurse is taking care of patients.");
    }

    public void DisplayNurse()
    {
        DisplayInfo();
        Console.WriteLine("Shift: " + Shift);
        PerformDuty();
    }
}
