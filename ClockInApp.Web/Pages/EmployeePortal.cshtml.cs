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
        public string EmployeePin { get; set; }
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; } = DateTime.Now;

        public EmployeePortalModel(IDatabaseData db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Employee = _db.LoginToPortal(EmployeePin);
        }

        //public IActionResult OnPostClockIn()
        //{
        //    return RedirectToPage("EmployeePortal", "EmployeePin", new { EmployeePin });
        //}
        public IActionResult OnPost()
        {
            _db.StartShifTime(employeeId: Employee.Id, StartTime);
            //_db.StopShifTime(employeeId: Employee.Id);
            return RedirectToPage(new
            {
                EmployeePin,
                StartTime = StartTime.ToString("YYYY-MM-DD hh:mm:ss"),
                EndTime= EndTime.ToString("YYYY-MM-DD hh:mm:ss")
            });
        }
    }
}
