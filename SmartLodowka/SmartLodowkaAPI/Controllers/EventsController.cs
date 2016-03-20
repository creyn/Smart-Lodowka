using SmartLodowkaAPI.DTO;
using SmartLodowkaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SmartLodowkaAPI.Controllers
{
    public class EventsController : ApiController
    {
        private readonly IEventsService _service;

        public EventsController()
        {
            _service = new EventsService();
        }

        public List<Event> Get()
        {
            return _service.GetAllEvents();
        }

        public Event Get(int id)
        {
            return _service.GetEvent(id);
        }
    }
}