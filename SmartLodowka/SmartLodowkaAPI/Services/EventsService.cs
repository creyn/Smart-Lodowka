using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartLodowkaAPI.DTO;

namespace SmartLodowkaAPI.Services
{
    public class EventsService : IEventsService
    {
        private readonly List<Event> _tmpEvents = new List<Event>
        {
            new Event { Id = 1, Name = "Event 1" },
            new Event { Id = 2, Name = "Event 2" },
            new Event { Id = 3, Name = "Event 3" }
        };

        public List<Event> GetAllEvents()
        {
            return _tmpEvents;
        }

        public Event GetEvent(int id)
        {
            return _tmpEvents.FirstOrDefault(e => e.Id == id);
        }
    }
}