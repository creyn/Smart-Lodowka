using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartLodowkaAPI.DTO
{
    public class CreateEventsRequest
    {
        [Required]
        public List<Event> Events { get; set; }
    }
}