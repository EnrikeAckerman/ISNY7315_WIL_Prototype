/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Represents information displayed on the player-facing
 * mobile dashboard.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 */

namespace CxO_Golf.Models
{
    public class PlayerDashboardViewModel
    {
        public string PlayerName { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;

        public string EventName { get; set; } = string.Empty;

        public string EventDate { get; set; } = string.Empty;

        public string Venue { get; set; } = string.Empty;

        public string TeeTime { get; set; } = string.Empty;

        public string FourBall { get; set; } = string.Empty;

        public string Tee { get; set; } = string.Empty;

        public double Handicap { get; set; }

        public string WeatherTemperature { get; set; } = string.Empty;

        public string WeatherCondition { get; set; } = string.Empty;

        public string WeatherWind { get; set; } = string.Empty;

        public string WeatherRain { get; set; } = string.Empty;

        public string EventUpdate { get; set; } = string.Empty;

        public List<PlayerGroupMemberViewModel> GroupMembers { get; set; } = new();
    }


    public class PlayerGroupMemberViewModel
    {
        public string Name { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;

        public double Handicap { get; set; }
    }
}