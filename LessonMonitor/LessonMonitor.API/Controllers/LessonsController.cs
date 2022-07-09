using Microsoft.AspNetCore.Mvc;
using LessonMonitor.Core.Services;
using LessonMonitor.Core;
using LessonMonitor.BL;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonsController : ControllerBase
    {
        private readonly ILessonsService _lessonService;
        public LessonsController(ILessonsService lessonService)
        {
            _lessonService = lessonService;
        }

       [HttpPost("lessons/{lesson}")]
        public void Lessons(Lesson lesson)
        {
            _lessonService.Create(lesson);
        }
    }
}
