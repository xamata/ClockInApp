using ClockInAppLibrary.Models;

namespace ClockInAppLibrary.Data
{
    public interface IDatabaseData
    {
        EmployeeModel LoginToPortal(string ePin);
        void StartShifTime(int employeeId, DateTime startTime);
        void StopShifTime(int employeeId, DateTime endTime);
    }
}