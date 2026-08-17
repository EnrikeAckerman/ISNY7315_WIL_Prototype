/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Represents player information displayed to Event Managers.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 */

namespace CxO_Golf.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public double Handicap { get; set; }

        public string RegistrationStatus { get; set; } = string.Empty;

        public string StatusClass { get; set; } = string.Empty;
    }


    public class PlayerDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public double Handicap { get; set; }

        public string RegistrationStatus { get; set; } = string.Empty;

        public string EventName { get; set; } = string.Empty;

        public string FourBall { get; set; } = string.Empty;

        public string TeeTime { get; set; } = string.Empty;
    }
}