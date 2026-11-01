
using System;

public class Doctor : Staff //inherits from Staff class
{
    public string Specialization { get; set; } // Additional property for Doctor

     public Doctor(string name, int staffId, // Constructor for Doctor class
                  string department, string specialization)
        : base(name, staffId, department)
    {
        Specialization = specialization;
    }

    public override void PerformDuty()
    {
        Console.WriteLine("Doctor is checking patients.");
    }

    public void DisplayDoctor()  // Method to display doctor information , polymorphism
    {
        DisplayInfo();
        Console.WriteLine("Specialization: " + Specialization);
        PerformDuty();
    }
}
