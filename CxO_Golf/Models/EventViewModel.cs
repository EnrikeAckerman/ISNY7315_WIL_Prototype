/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Represents event information displayed by the Event Manager.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 */

namespace CxO_Golf.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }

        public string EventName { get; set; } = string.Empty;

        public string Venue { get; set; } = string.Empty;

        public string Date { get; set; } = string.Empty;

        public int PlayerCount { get; set; }

        public int FourBallCount { get; set; }

        public string Status { get; set; } = string.Empty;

        public string StatusClass { get; set; } = string.Empty;
    }


    public class EventDetailsViewModel
    {
        public int Id { get; set; }

        public string EventName { get; set; } = string.Empty;

        public string Venue { get; set; } = string.Empty;

        public string Date { get; set; } = string.Empty;

        public string StartTime { get; set; } = string.Empty;

        public int PlayerCount { get; set; }

        public int FourBallCount { get; set; }

        public int RegisteredPlayers { get; set; }

        public int PendingRegistrations { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}