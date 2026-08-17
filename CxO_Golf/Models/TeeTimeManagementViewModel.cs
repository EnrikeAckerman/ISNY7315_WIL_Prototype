/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * View models used by the Tee Time Management interface.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 */

namespace CxO_Golf.Models
{
    public class TeeTimeManagementViewModel
    {
        public int EventId { get; set; }

        public string EventName { get; set; } = string.Empty;

        public string Venue { get; set; } = string.Empty;

        public string Date { get; set; } = string.Empty;

        public List<TeeTimeManagementItemViewModel> TeeTimes { get; set; } = new();
    }


    public class TeeTimeManagementItemViewModel
    {
        public int Id { get; set; }

        public string Time { get; set; } = string.Empty;

        public string FourBall { get; set; } = string.Empty;

        public string PlayerSummary { get; set; } = string.Empty;

        public double AverageHandicap { get; set; }

        public string Tee { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public string StatusClass { get; set; } = string.Empty;
    }
}