using ClockInAppLibrary.Database;
using ClockInAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClockInAppLibrary.Data
{
    public class SqlData : IDatabaseData
    {
        private readonly ISqlDataAccess _db;
        private const string connectionStringName = "Default";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }

        public EmployeeModel LoginToPortal(string ePin)
        {
            EmployeeModel employee = _db.LoadData<EmployeeModel, dynamic>("dbo.spEmployees_GetByPin",
                new { pin = ePin },
                connectionStringName,
                true).First();

            return employee;
        }

        public void StartShifTime(int employeeId, DateTime startTime)
        {
            _db.SaveData("dbo.spShiftTimes_StartShift",
                new { employeeId, startTime},
                connectionStringName,
                true);

            _db.SaveData("dbo.spShiftTimes_ClockedIn",
                new { employeeId },
                connectionStringName,
                true);
        }

        public void StopShifTime(int employeeId,DateTime startTime, DateTime stopTime)
        {
            _db.SaveData("dbo.spShiftTimes_StopShift",
                new { employeeId, startTime, stopTime},
                connectionStringName,
                true);

            _db.SaveData("dbo.spShiftTimes_ClockedOut",
               new { employeeId },
               connectionStringName,
               true);
        }

    }
}
