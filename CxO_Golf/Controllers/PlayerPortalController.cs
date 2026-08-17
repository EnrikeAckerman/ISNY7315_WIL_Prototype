/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Provides the player-facing dashboard used by executives
 * attending a CxO Series golf event.
 *
 * The interface is designed primarily for mobile use so that
 * players can quickly access their tee time, 4-Ball allocation,
 * venue information and event updates while on the course.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 *
 * W3C (n.d.) Web Content Accessibility Guidelines (WCAG) 2.2.
 * Available at:
 * https://www.w3.org/TR/WCAG22/
 * (Accessed: 14 August 2026).
 *
 * Note:
 * Prototype data is used for Task 1. The implemented system
 * will retrieve player and event information from the database
 * and external services.
 */

using CxO_Golf.Models;
using Microsoft.AspNetCore.Mvc;

namespace CxO_Golf.Controllers
{
    public class PlayerPortalController : Controller
    {
        public IActionResult Index()
        {
            var model = new PlayerDashboardViewModel
            {
                PlayerName = "James Anderson",
                Company = "Nexus Group",

                EventName = "CxO Johannesburg Golf Day",
                EventDate = "18 September 2026",
                Venue = "Johannesburg Country Club",

                TeeTime = "08:30",
                FourBall = "4-Ball 01",
                Tee = "1st Tee",

                Handicap = 8.4,

                WeatherTemperature = "22°C",
                WeatherCondition = "Partly Cloudy",
                WeatherWind = "12 km/h",
                WeatherRain = "10%",

                EventUpdate =
                    "Registration opens at 07:30. Please arrive at least 30 minutes before your tee time.",

                GroupMembers = new List<PlayerGroupMemberViewModel>
                {
                    new PlayerGroupMemberViewModel
                    {
                        Name = "Michael Daniels",
                        Company = "Acme Holdings",
                        Handicap = 10.2
                    },

                    new PlayerGroupMemberViewModel
                    {
                        Name = "David Williams",
                        Company = "Meridian Capital",
                        Handicap = 11.6
                    },

                    new PlayerGroupMemberViewModel
                    {
                        Name = "Robert Taylor",
                        Company = "Summit Partners",
                        Handicap = 13.0
                    }
                }
            };

            return View(model);
        }
    }
}