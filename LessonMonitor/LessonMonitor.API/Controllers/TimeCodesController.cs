using Microsoft.AspNetCore.Mvc;
using LessonMonitor.API.Models;
using System.Collections.Generic;
using System;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeCodesController : ControllerBase
    {
        private List<TimeCode> _timeCodes;
        public TimeCodesController()
        {
            _timeCodes = new List<TimeCode>();

            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                _timeCodes.Add(new TimeCode { Id = i, 
                    Topic = $"Topic - {i}",
                    Time = new TimeSpan(random.Next(0, 2), random.Next(1, 59), random.Next(0, 59)) });
            }
        }

        [HttpGet("{id}")]
        public TimeCode TimeCodes(int id)
        {
            return _timeCodes[id];
        }

        [HttpGet]
        public IEnumerable<TimeCode> TimeCodes()
        {
            return _timeCodes;
        }

        [HttpPost("{timeCode}")]
        public void TimeCodes(TimeCode timeCode)
        {
            _timeCodes.Add(timeCode);
        }
    }
}
