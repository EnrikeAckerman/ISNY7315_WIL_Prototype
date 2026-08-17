/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * View model used to provide dashboard information to the Event Manager.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC overview. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/overview
 * (Accessed: 14 August 2026).
 *
 * Note:
 * The properties and sample data requirements were designed specifically
 * for the CxO Series Golf Management System prototype.
 */

namespace CxO_Golf.Models
{
    public class DashboardViewModel
    {
        // Summary statistics
        public int UpcomingEvents { get; set; }

        public int RegisteredPlayers { get; set; }

        public int PendingRegistrations { get; set; }

        public int EventsRequiringAttention { get; set; }

        // Upcoming event information
        public List<UpcomingEventViewModel> UpcomingEventsList { get; set; } = new();

        // Upcoming tee times
        public List<TeeTimeViewModel> UpcomingTeeTimes { get; set; } = new();
    }


    public class UpcomingEventViewModel
    {
        public int Id { get; set; }

        public string EventName { get; set; } = string.Empty;

        public string Venue { get; set; } = string.Empty;

        public string Date { get; set; } = string.Empty;

        public int PlayerCount { get; set; }

        public string Status { get; set; } = string.Empty;

        public string StatusClass { get; set; } = string.Empty;
    }


    public class TeeTimeViewModel
    {
        public string Time { get; set; } = string.Empty;

        public string EventName { get; set; } = string.Empty;

        public string Group { get; set; } = string.Empty;

        public string Venue { get; set; } = string.Empty;
    }
}