
using System;

public abstract class Staff
{
    public string Name { get; set; }
    public int StaffId { get; set; }
    public string Department { get; set; }

    public Staff(string name, int staffId, string department)
    {
        Name = name;
        StaffId = staffId;
        Department = department;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Staff ID: " + StaffId);
        Console.WriteLine("Department: " + Department);
    }

    public abstract void PerformDuty();
}
