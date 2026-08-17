/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * View models used by the 4-Ball Management interface.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 */

namespace CxO_Golf.Models
{
    public class FourBallManagementViewModel
    {
        public int EventId { get; set; }

        public string EventName { get; set; } = string.Empty;

        public string Venue { get; set; } = string.Empty;

        public string Date { get; set; } = string.Empty;

        public List<FourBallViewModel> Groups { get; set; } = new();
    }


    public class FourBallViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public double AverageHandicap { get; set; }

        public List<FourBallPlayerViewModel> Players { get; set; } = new();
    }


    public class FourBallPlayerViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;

        public double Handicap { get; set; }
    }
}