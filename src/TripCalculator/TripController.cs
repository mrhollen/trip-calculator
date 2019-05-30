using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TripCalculator.Models;

namespace TripCalculator 
{
    [Route("api/[controller]")]
    public class TripController : Controller 
    {
        private TripService service;

        public TripController(TripService service)
        {
            this.service = service;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok();
        }

        [EnableCors("AllowAll")]
        [HttpPost("settle-up")]
        public IActionResult SettleUpTrip([FromBody] IEnumerable<Person> people)
        {
            if(people is null || people.Count() < 1)
            {
                return BadRequest();
            }

            return Json(service.SettleUpTrip(people));
        }
    }
}