using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleBookingApp.Data;
using SimpleBookingApp.Models;
using System;

namespace SimpleBookingApp.Pages
{
    public class BookingModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public BookingModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Appointment Appointment { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Appointments.Add(Appointment);
            _context.SaveChanges();

            return RedirectToPage("Confirmation");
        }
    }
}