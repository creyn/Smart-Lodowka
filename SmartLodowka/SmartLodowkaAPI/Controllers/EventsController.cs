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
        
        public IHttpActionResult Get()
        {
            return Ok(_service.GetAllEvents());
        }

        public IHttpActionResult Get(int id)
        {
            var tmp =  _service.GetEvent(id);
            if(tmp == null)
            {
                return NotFound();
            }
            return Ok(tmp);
        }

        public IHttpActionResult Post(CreateEventsRequest request)
        {
            if(ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            return Ok(_service.InsertEvents(request.Events));
        }
    }
}