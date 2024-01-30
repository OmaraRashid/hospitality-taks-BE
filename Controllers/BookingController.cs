using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOSPITALITY.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hospitality_taks_BE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly BookingService _bookingService;

        public BookingController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("GetReminderEmails")]
        public IActionResult GetReminderEmails(DateTime date, int restaurantId)
        {
            var reminderEmails = _bookingService.GetReminderEmails(date, restaurantId);
            return Ok(reminderEmails);
        }
    }

}
