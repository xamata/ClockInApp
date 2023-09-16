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

        public EmployeePortalModel(IDatabaseData db)
        {
            _db = db;
        }
        public void OnGet()
        {
         }
    }
}
