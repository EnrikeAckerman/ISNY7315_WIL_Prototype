/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Handles requests for the Event Manager dashboard during the
 * front-end prototype stage.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC overview. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/overview
 * (Accessed: 14 August 2026).
 *
 * Note:
 * The dashboard currently uses prototype data. During later development,
 * this data will be retrieved from application services and the database.
 */

using CxO_Golf.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CxO_Golf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /*
             * Prototype data:
             * These values simulate information that will eventually
             * be retrieved from the application's database.
             */

            var dashboard = new DashboardViewModel
            {
                UpcomingEvents = 4,
                RegisteredPlayers = 128,
                PendingRegistrations = 12,
                EventsRequiringAttention = 2,

                UpcomingEventsList = new List<UpcomingEventViewModel>
                {
                    new UpcomingEventViewModel
                    {
                        Id = 1,
                        EventName = "CxO Johannesburg Golf Day",
                        Venue = "Johannesburg Country Club",
                        Date = "18 September 2026",
                        PlayerCount = 128,
                        Status = "Confirmed",
                        StatusClass = "confirmed"
                    },

                    new UpcomingEventViewModel
                    {
                        Id = 2,
                        EventName = "CxO Pretoria Executive Day",
                        Venue = "Pretoria Country Club",
                        Date = "2 October 2026",
                        PlayerCount = 96,
                        Status = "Registration Open",
                        StatusClass = "open"
                    },

                    new UpcomingEventViewModel
                    {
                        Id = 3,
                        EventName = "CxO Cape Town Invitational",
                        Venue = "Atlantic Golf Club",
                        Date = "16 October 2026",
                        PlayerCount = 72,
                        Status = "Planning",
                        StatusClass = "planning"
                    }
                },

                UpcomingTeeTimes = new List<TeeTimeViewModel>
                {
                    new TeeTimeViewModel
                    {
                        Time = "08:30",
                        EventName = "CxO Johannesburg Golf Day",
                        Group = "4-Ball #12",
                        Venue = "Johannesburg Country Club"
                    },

                    new TeeTimeViewModel
                    {
                        Time = "08:40",
                        EventName = "CxO Johannesburg Golf Day",
                        Group = "4-Ball #13",
                        Venue = "Johannesburg Country Club"
                    },

                    new TeeTimeViewModel
                    {
                        Time = "08:50",
                        EventName = "CxO Johannesburg Golf Day",
                        Group = "4-Ball #14",
                        Venue = "Johannesburg Country Club"
                    }
                }
            };

            return View(dashboard);
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(
            Duration = 0,
            Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id
                        ?? HttpContext.TraceIdentifier
                });
        }
    }
}