using SmartLodowkaAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartLodowkaAPI.Services
{
    public interface IEventsService
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
    }
}