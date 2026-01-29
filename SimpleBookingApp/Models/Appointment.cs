using System;

namespace SimpleBookingApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
    }
}