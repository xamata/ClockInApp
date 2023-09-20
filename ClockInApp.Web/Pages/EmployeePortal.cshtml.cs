using ClockInAppLibrary.Data;
using ClockInAppLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClockInApp.Web.Pages
{
    public class EmployeePortalModel : PageModel
    {
        private readonly IDatabaseData _db;
        [BindProperty]
        public EmployeeModel Employee { get; set; }

        [BindProperty(SupportsGet = true)]
        public string EmployeePin { get; set; } = "0000";
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime StopTime { get; set; } = DateTime.Now;

        public EmployeePortalModel(IDatabaseData db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Employee = _db.LoginToPortal(EmployeePin);
        }
        public IActionResult OnPost()
        {
            Employee = _db.LoginToPortal(EmployeePin);

            if (Employee.IsClockedIn)
            {
            _db.StopShifTime(employeeId: Employee.Id, StartTime, StopTime);
            }
            else
            {
            _db.StartShifTime(employeeId: Employee.Id, StartTime);
            }
            return RedirectToPage(new
            {
                EmployeePin,
                StartTime = StartTime.ToString("YYYY-MM-DD hh:mm:ss")
            });
        }
        public IActionResult OnPostClockIn()
        {
            Employee = _db.LoginToPortal(EmployeePin);
            _db.StartShifTime(employeeId: Employee.Id, StartTime);
            //_db.StopShifTime(employeeId: Employee.Id);
            return RedirectToPage(new
            {
                EmployeePin,
                StartTime = StartTime.ToString("YYYY-MM-DD hh:mm:ss"),
                StopTime = StopTime.ToString("YYYY-MM-DD hh:mm:ss")
            });
        }
        public IActionResult OnPostClockOut()
        {
            Employee = _db.LoginToPortal(EmployeePin);
            _db.StopShifTime(employeeId: Employee.Id, StartTime, StopTime);
            //_db.StopShifTime(employeeId: Employee.Id);
            return RedirectToPage(new
            {
                EmployeePin,
                StartTime = StartTime.ToString("YYYY-MM-DD hh:mm:ss"),
                EndTime = StopTime.ToString("YYYY-MM-DD hh:mm:ss")
            });
        }
    }
}

