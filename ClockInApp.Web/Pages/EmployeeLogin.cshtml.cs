using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClockInApp.Web.Pages
{
    public class EmployeeLoginModel : PageModel
    {
        public string EmployeePin { get; set; }
        public void OnGet()
        {
        }
    }
}
