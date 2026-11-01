
using Xunit;

public class StaffManagerTests
{
    [Fact]
    public void SearchStaff_ExistingId_ReturnsTrue()
    {
        StaffManager manager = new StaffManager();

        Doctor doctor = new Doctor(
            "Ali", 101, "Cardiology", "Cardiologist"
        );

        manager.staffList.Add(doctor);

        bool result = manager.SearchStaff(101);

        Assert.True(result);
    }

    [Fact]
    public void SearchStaff_MissingId_ReturnsFalse()
    {
        StaffManager manager = new StaffManager();

        bool result = manager.SearchStaff(999);

        Assert.False(result);
    }
}
