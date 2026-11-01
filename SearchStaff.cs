
using System;
using System.Collections.Generic;


using System.Collections.Generic;

public class StaffManager
{
    public List<Staff> staffList = new List<Staff>();

    public bool SearchStaff(int id)
    {
        foreach (Staff staff in staffList)
        {
            if (staff.StaffId == id)
            {
                return true;
            }
        }

        return false;
    }
}

