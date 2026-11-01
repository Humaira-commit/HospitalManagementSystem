

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      //  List<Staff> staffList = new List<Staff>(); //List to store all staff members (data structure)
StaffManager manager = new StaffManager();
List<Staff> staffList = manager.staffList;  // I have created an instance of StaffManager class and then I have accessed the staffList property of that instance to get the list of staff members. This way, I can use the same staffList that is managed by the StaffManager class, which allows for better organization and management of staff data.
        while (true)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("       STAFF MANAGEMENT");
            Console.WriteLine("================================");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Add Nurse");
            Console.WriteLine("3. Add Administrative Staff");
            Console.WriteLine("4. Display All Staff");
            Console.WriteLine("5. Search Staff");
            Console.WriteLine("0. Exit");
            Console.WriteLine("================================");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine() ?? "";

            if (choice == "0")
            {
                Console.WriteLine("Program Closed");
                break;
            }
            else if (choice == "1" || choice == "2" || choice == "3")
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Enter Staff ID: ");
                int id;
                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid Staff ID!");
                    continue;
                }

                bool exists = false;

                foreach (Staff s in staffList)
                {
                    if (s.StaffId == id)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    Console.WriteLine("Staff ID already exists!");
                    continue;
                }

                Console.Write("Enter Department: ");
                string department = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    Console.Write("Enter Specialization: ");
                    string specialization = Console.ReadLine() ?? "";

                    Doctor doctor = new Doctor(name, id, department, specialization);
                    staffList.Add(doctor);

                    Console.WriteLine("Doctor Added Successfully!");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter Shift: ");
                    string shift = Console.ReadLine() ?? "";

                    Nurse nurse = new Nurse(name, id, department, shift);
                    staffList.Add(nurse);

                    Console.WriteLine("Nurse Added Successfully!");
                }
                else
                {
                    Console.Write("Enter Job Role: ");
                    string jobRole = Console.ReadLine() ?? "";

                    AdministrativeStaff admin =
                        new AdministrativeStaff(name, id, department, jobRole);

                    staffList.Add(admin);

                    Console.WriteLine("Administrative Staff Added Successfully!");
                }
            }
            else if (choice == "4")
            {
                if (staffList.Count == 0)
                {
                    Console.WriteLine("No staff available.");
                }
                else
                {
                    foreach (Staff s in staffList)
                    {
                        Console.WriteLine("--------------------");
                        s.DisplayInfo();

                        if (s is Doctor doctor)
                            Console.WriteLine("Specialization: " + doctor.Specialization);
                        else if (s is Nurse nurse)
                            Console.WriteLine("Shift: " + nurse.Shift);
                        else if (s is AdministrativeStaff admin)
                            Console.WriteLine("Job Role: " + admin.JobRole);

                        s.PerformDuty();
                    }
                }
            }
            /*
            else if (choice == "5")
            {
                Console.WriteLine("Search Staff feature will be added next.");
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
            */
            // I have added the search function for staff members based on their ID. The user can enter the staff ID, and the program will check if a staff member with that ID exists in the list. If found, it will display "Staff Found!", otherwise it will display "Staff Not Found!". If the user enters an invalid ID (non-integer), it will display "Invalid Staff ID!".
else if (choice == "5")
{
    Console.Write("Enter Staff ID to search: ");

    int id;

    if (int.TryParse(Console.ReadLine(), out id))
    {
        bool found = manager.SearchStaff(id);

        if (found == true)
        {
            Console.WriteLine("Staff Found!");
        }
        else
        {
            Console.WriteLine("Staff Not Found!");
        }
    }
    else
    {
        Console.WriteLine("Invalid Staff ID!");
    }
}

        }
    }
}

