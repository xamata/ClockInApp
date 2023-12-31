using ClockInAppLibrary.Models;
using ClockInAppLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClockInApp.Web.Pages
{
    public class EmployeeLoginModel : PageModel
    {
        private readonly IDatabaseData _db;

        [BindProperty]
        public string EmployeePin { get; set; } = "0000";
        public EmployeeLoginModel(IDatabaseData db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(){
            return RedirectToPage("EmployeePortal", new {EmployeePin});
        }
    }
}
