/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Provides Event Managers with an overview of tee times and
 * the 4-Balls assigned to each scheduled tee time.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 *
 * Note:
 * Tee-time information currently uses prototype data. In the
 * implemented system, this information will be retrieved from
 * the database and linked to the event's 4-Ball allocations.
 */

using CxO_Golf.Models;
using Microsoft.AspNetCore.Mvc;

namespace CxO_Golf.Controllers
{
    public class TeeTimesController : Controller
    {
        public IActionResult Index(int eventId = 1)
        {
            var model = new TeeTimeManagementViewModel
            {
                EventId = eventId,
                EventName = "CxO Johannesburg Golf Day",
                Venue = "Johannesburg Country Club",
                Date = "18 September 2026",

                TeeTimes = new List<TeeTimeManagementItemViewModel>
                {
                    new TeeTimeManagementItemViewModel
                    {
                        Id = 1,
                        Time = "08:30",
                        FourBall = "4-Ball 01",
                        PlayerSummary = "James Anderson · Michael Daniels · David Williams · Robert Taylor",
                        AverageHandicap = 10.8,
                        Tee = "1st Tee",
                        Status = "Confirmed",
                        StatusClass = "confirmed"
                    },

                    new TeeTimeManagementItemViewModel
                    {
                        Id = 2,
                        Time = "08:40",
                        FourBall = "4-Ball 02",
                        PlayerSummary = "Sarah Johnson · Mark Wilson · Peter Morgan · Andrew Smith",
                        AverageHandicap = 11.7,
                        Tee = "1st Tee",
                        Status = "Confirmed",
                        StatusClass = "confirmed"
                    },

                    new TeeTimeManagementItemViewModel
                    {
                        Id = 3,
                        Time = "08:50",
                        FourBall = "4-Ball 03",
                        PlayerSummary = "Richard Brown · Daniel Cooper · Chris Martin · Steven Clark",
                        AverageHandicap = 12.0,
                        Tee = "1st Tee",
                        Status = "Confirmed",
                        StatusClass = "confirmed"
                    },

                    new TeeTimeManagementItemViewModel
                    {
                        Id = 4,
                        Time = "09:00",
                        FourBall = "4-Ball 04",
                        PlayerSummary = "Thomas Evans · William Harris · Matthew King · Jonathan Lee",
                        AverageHandicap = 11.5,
                        Tee = "1st Tee",
                        Status = "Confirmed",
                        StatusClass = "confirmed"
                    },

                    new TeeTimeManagementItemViewModel
                    {
                        Id = 5,
                        Time = "09:10",
                        FourBall = "4-Ball 05",
                        PlayerSummary = "Anthony Wright · George Walker · Charles Hall · Edward Allen",
                        AverageHandicap = 12.3,
                        Tee = "1st Tee",
                        Status = "Review",
                        StatusClass = "review"
                    },

                    new TeeTimeManagementItemViewModel
                    {
                        Id = 6,
                        Time = "09:20",
                        FourBall = "4-Ball 06",
                        PlayerSummary = "Christopher Young · Matthew Scott · Paul Green · Daniel Baker",
                        AverageHandicap = 11.1,
                        Tee = "1st Tee",
                        Status = "Confirmed",
                        StatusClass = "confirmed"
                    }
                }
            };

            return View(model);
        }
    }
}