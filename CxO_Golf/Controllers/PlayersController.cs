/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Provides Event Managers with an overview of registered players
 * and their golf-related information.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 *
 * Note:
 * Player information currently uses prototype data. In the
 * implemented system this information will be retrieved from
 * the application's database and external handicap services.
 */

using CxO_Golf.Models;
using Microsoft.AspNetCore.Mvc;

namespace CxO_Golf.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            var players = new List<PlayerViewModel>
            {
                new PlayerViewModel
                {
                    Id = 1,
                    Name = "James Anderson",
                    Company = "Nexus Group",
                    Email = "james.anderson@example.com",
                    Handicap = 8.4,
                    RegistrationStatus = "Registered",
                    StatusClass = "registered"
                },

                new PlayerViewModel
                {
                    Id = 2,
                    Name = "Sarah Johnson",
                    Company = "BluePeak",
                    Email = "sarah.johnson@example.com",
                    Handicap = 9.1,
                    RegistrationStatus = "Registered",
                    StatusClass = "registered"
                },

                new PlayerViewModel
                {
                    Id = 3,
                    Name = "Michael Daniels",
                    Company = "Acme Holdings",
                    Email = "michael.daniels@example.com",
                    Handicap = 10.2,
                    RegistrationStatus = "Registered",
                    StatusClass = "registered"
                },

                new PlayerViewModel
                {
                    Id = 4,
                    Name = "Mark Wilson",
                    Company = "Oakridge",
                    Email = "mark.wilson@example.com",
                    Handicap = 10.7,
                    RegistrationStatus = "Registered",
                    StatusClass = "registered"
                },

                new PlayerViewModel
                {
                    Id = 5,
                    Name = "David Williams",
                    Company = "Meridian Capital",
                    Email = "david.williams@example.com",
                    Handicap = 11.6,
                    RegistrationStatus = "Registered",
                    StatusClass = "registered"
                },

                new PlayerViewModel
                {
                    Id = 6,
                    Name = "Peter Morgan",
                    Company = "Vertex Group",
                    Email = "peter.morgan@example.com",
                    Handicap = 12.4,
                    RegistrationStatus = "Pending",
                    StatusClass = "pending"
                },

                new PlayerViewModel
                {
                    Id = 7,
                    Name = "Robert Taylor",
                    Company = "Summit Partners",
                    Email = "robert.taylor@example.com",
                    Handicap = 13.0,
                    RegistrationStatus = "Registered",
                    StatusClass = "registered"
                },

                new PlayerViewModel
                {
                    Id = 8,
                    Name = "Andrew Smith",
                    Company = "Nexus Group",
                    Email = "andrew.smith@example.com",
                    Handicap = 14.6,
                    RegistrationStatus = "Pending",
                    StatusClass = "pending"
                }
            };

            return View(players);
        }


        public IActionResult Details(int id)
        {
            var player = new PlayerDetailsViewModel
            {
                Id = id,
                Name = "James Anderson",
                Company = "Nexus Group",
                Email = "james.anderson@example.com",
                Phone = "+27 82 555 0148",
                Handicap = 8.4,
                RegistrationStatus = "Registered",
                EventName = "CxO Johannesburg Golf Day",
                FourBall = "4-Ball 01",
                TeeTime = "08:30"
            };

            return View(player);
        }
    }
}