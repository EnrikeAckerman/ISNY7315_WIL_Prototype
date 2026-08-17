/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Provides event-management functionality for the Event Manager
 * prototype.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 *
 * Note:
 * The event information currently uses prototype data. In later
 * development this will be replaced by data retrieved through
 * application services and Entity Framework Core.
 */

using CxO_Golf.Models;
using Microsoft.AspNetCore.Mvc;

namespace CxO_Golf.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            var events = new List<EventViewModel>
            {
                new EventViewModel
                {
                    Id = 1,
                    EventName = "CxO Johannesburg Golf Day",
                    Venue = "Johannesburg Country Club",
                    Date = "18 September 2026",
                    PlayerCount = 128,
                    FourBallCount = 32,
                    Status = "Confirmed",
                    StatusClass = "confirmed"
                },

                new EventViewModel
                {
                    Id = 2,
                    EventName = "CxO Pretoria Executive Day",
                    Venue = "Pretoria Country Club",
                    Date = "2 October 2026",
                    PlayerCount = 96,
                    FourBallCount = 24,
                    Status = "Registration Open",
                    StatusClass = "open"
                },

                new EventViewModel
                {
                    Id = 3,
                    EventName = "CxO Cape Town Invitational",
                    Venue = "Atlantic Golf Club",
                    Date = "16 October 2026",
                    PlayerCount = 72,
                    FourBallCount = 18,
                    Status = "Planning",
                    StatusClass = "planning"
                },

                new EventViewModel
                {
                    Id = 4,
                    EventName = "CxO Durban Corporate Classic",
                    Venue = "Durban Country Club",
                    Date = "6 November 2026",
                    PlayerCount = 104,
                    FourBallCount = 26,
                    Status = "Planning",
                    StatusClass = "planning"
                },

                new EventViewModel
                {
                    Id = 5,
                    EventName = "CxO Summer Invitational",
                    Venue = "Sun City Golf Estate",
                    Date = "4 December 2026",
                    PlayerCount = 144,
                    FourBallCount = 36,
                    Status = "Planning",
                    StatusClass = "planning"
                }
            };

            return View(events);
        }


        public IActionResult Details(int id)
        {
            /*
             * Prototype event data.
             * In the implemented system, the event will be retrieved
             * using its database identifier.
             */

            var golfEvent = new EventDetailsViewModel
            {
                Id = id,
                EventName = "CxO Johannesburg Golf Day",
                Venue = "Johannesburg Country Club",
                Date = "18 September 2026",
                StartTime = "08:30",

                PlayerCount = 128,
                FourBallCount = 32,

                RegisteredPlayers = 118,
                PendingRegistrations = 10,

                Status = "Confirmed"
            };

            return View(golfEvent);
        }
    }
}