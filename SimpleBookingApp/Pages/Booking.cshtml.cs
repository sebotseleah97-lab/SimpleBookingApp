using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleBookingApp.Data;
using SimpleBookingApp.Models;
using System.Linq;

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

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            // Prevent double booking
            bool exists = _context.Appointments.Any(a =>
                a.Type == Appointment.Type &&
                a.Date == Appointment.Date
            );

            if (exists)
            {
                ErrorMessage = "This appointment is already booked for the selected date.";
                return Page();
            }

            _context.Appointments.Add(Appointment);
            _context.SaveChanges();

            return RedirectToPage("Confirmation");
        }
    }
}