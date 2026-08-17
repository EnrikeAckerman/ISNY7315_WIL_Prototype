/*
 * CxO Series Golf Management System
 * INSY7315 WIL - Task 1 Prototype
 *
 * Purpose:
 * Provides the Event Manager with an interface for viewing and
 * manually adjusting automatically generated 4-Ball groups.
 *
 * References:
 * Microsoft (n.d.) ASP.NET Core MVC documentation. Available at:
 * https://learn.microsoft.com/aspnet/core/mvc/
 * (Accessed: 14 August 2026).
 *
 * Note:
 * Player and grouping information currently uses prototype data.
 * The completed system will retrieve this information from the
 * database and grouping service.
 */

using CxO_Golf.Models;
using Microsoft.AspNetCore.Mvc;

namespace CxO_Golf.Controllers
{
    public class FourBallsController : Controller
    {
        public IActionResult Index(int eventId = 1)
        {
            var model = new FourBallManagementViewModel
            {
                EventId = eventId,
                EventName = "CxO Johannesburg Golf Day",
                Venue = "Johannesburg Country Club",
                Date = "18 September 2026",

                Groups = new List<FourBallViewModel>
                {
                    new FourBallViewModel
                    {
                        Id = 1,
                        Name = "4-Ball 01",
                        AverageHandicap = 10.8,

                        Players = new List<FourBallPlayerViewModel>
                        {
                            new FourBallPlayerViewModel
                            {
                                Id = 1,
                                Name = "James Anderson",
                                Company = "Nexus Group",
                                Handicap = 8.4
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 2,
                                Name = "Michael Daniels",
                                Company = "Acme Holdings",
                                Handicap = 10.2
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 3,
                                Name = "David Williams",
                                Company = "Meridian Capital",
                                Handicap = 11.6
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 4,
                                Name = "Robert Taylor",
                                Company = "Summit Partners",
                                Handicap = 13.0
                            }
                        }
                    },

                    new FourBallViewModel
                    {
                        Id = 2,
                        Name = "4-Ball 02",
                        AverageHandicap = 11.7,

                        Players = new List<FourBallPlayerViewModel>
                        {
                            new FourBallPlayerViewModel
                            {
                                Id = 5,
                                Name = "Sarah Johnson",
                                Company = "BluePeak",
                                Handicap = 9.1
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 6,
                                Name = "Mark Wilson",
                                Company = "Oakridge",
                                Handicap = 10.7
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 7,
                                Name = "Peter Morgan",
                                Company = "Vertex Group",
                                Handicap = 12.4
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 8,
                                Name = "Andrew Smith",
                                Company = "Nexus Group",
                                Handicap = 14.6
                            }
                        }
                    },

                    new FourBallViewModel
                    {
                        Id = 3,
                        Name = "4-Ball 03",
                        AverageHandicap = 12.0,

                        Players = new List<FourBallPlayerViewModel>
                        {
                            new FourBallPlayerViewModel
                            {
                                Id = 9,
                                Name = "Richard Brown",
                                Company = "Atlas Financial",
                                Handicap = 7.9
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 10,
                                Name = "Daniel Cooper",
                                Company = "Summit Partners",
                                Handicap = 11.8
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 11,
                                Name = "Chris Martin",
                                Company = "BluePeak",
                                Handicap = 12.9
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 12,
                                Name = "Steven Clark",
                                Company = "Meridian Capital",
                                Handicap = 15.4
                            }
                        }
                    },

                    new FourBallViewModel
                    {
                        Id = 4,
                        Name = "4-Ball 04",
                        AverageHandicap = 11.5,

                        Players = new List<FourBallPlayerViewModel>
                        {
                            new FourBallPlayerViewModel
                            {
                                Id = 13,
                                Name = "Thomas Evans",
                                Company = "Oakridge",
                                Handicap = 8.8
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 14,
                                Name = "William Harris",
                                Company = "Vertex Group",
                                Handicap = 10.9
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 15,
                                Name = "Matthew King",
                                Company = "Atlas Financial",
                                Handicap = 12.1
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 16,
                                Name = "Jonathan Lee",
                                Company = "Acme Holdings",
                                Handicap = 14.2
                            }
                        }
                    },

                    new FourBallViewModel
                    {
                        Id = 5,
                        Name = "4-Ball 05",
                        AverageHandicap = 12.3,

                        Players = new List<FourBallPlayerViewModel>
                        {
                            new FourBallPlayerViewModel
                            {
                                Id = 17,
                                Name = "Anthony Wright",
                                Company = "Nexus Group",
                                Handicap = 9.7
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 18,
                                Name = "George Walker",
                                Company = "BluePeak",
                                Handicap = 11.3
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 19,
                                Name = "Charles Hall",
                                Company = "Summit Partners",
                                Handicap = 13.5
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 20,
                                Name = "Edward Allen",
                                Company = "Oakridge",
                                Handicap = 14.7
                            }
                        }
                    },

                    new FourBallViewModel
                    {
                        Id = 6,
                        Name = "4-Ball 06",
                        AverageHandicap = 11.1,

                        Players = new List<FourBallPlayerViewModel>
                        {
                            new FourBallPlayerViewModel
                            {
                                Id = 21,
                                Name = "Christopher Young",
                                Company = "Meridian Capital",
                                Handicap = 8.2
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 22,
                                Name = "Matthew Scott",
                                Company = "Atlas Financial",
                                Handicap = 10.5
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 23,
                                Name = "Paul Green",
                                Company = "Acme Holdings",
                                Handicap = 11.9
                            },

                            new FourBallPlayerViewModel
                            {
                                Id = 24,
                                Name = "Daniel Baker",
                                Company = "Vertex Group",
                                Handicap = 13.8
                            }
                        }
                    }
                }
            };

            return View(model);
        }
    }
}