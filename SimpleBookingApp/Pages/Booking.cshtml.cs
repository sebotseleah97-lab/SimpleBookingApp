using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

public class BookingModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }

    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public string Type { get; set; }

    [BindProperty]
    public DateTime Date { get; set; }

    public IActionResult OnPost()
    {
        return RedirectToPage("Confirmation");
    }
}