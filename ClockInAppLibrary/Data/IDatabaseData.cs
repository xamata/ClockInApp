using ClockInAppLibrary.Models;

namespace ClockInAppLibrary.Data
{
    public interface IDatabaseData
    {
        (EmployeeModel, bool isClockedIn) LoginToPortal(string ePin);
        void StartShifTime(int employeeId);
        void StopShifTime(int employeeId);
    }
}