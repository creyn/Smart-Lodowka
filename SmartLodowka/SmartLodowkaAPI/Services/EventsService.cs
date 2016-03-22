using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartLodowkaAPI.DTO;
using Simple.Data;
using SmartLodowkaAPI.Config;

namespace SmartLodowkaAPI.Services
{
    public class EventsService : IEventsService
    {
        private dynamic OpenDatabase()
        {
            return Database.OpenNamedConnection(Constants.Config.WebioDatabaseConnectionString);
        }

        public List<Event> GetAllEvents()
        {
            return OpenDatabase().SmartLodowka_Events.All();
        }

        public Event GetEvent(int id)
        {
            return OpenDatabase().SmartLodowka_Events.FindById(Id: id);
        }

        public List<Event> InsertEvents(List<Event> newEvents)
        {
            return OpenDatabase().SmartLodowka_Events.Insert(newEvents);
        }
    }
}