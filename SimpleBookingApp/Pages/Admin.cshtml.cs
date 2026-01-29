using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleBookingApp.Pages.Admin
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            // SIMPLE hard-coded admin credentials
            if (Username == "admin" && Password == "admin123")
            {
                HttpContext.Session.SetString("IsAdminLoggedIn", "true");
                return RedirectToPage("Dashboard");
            }

            ErrorMessage = "Invalid username or password";
            return Page();
        }
    }
}