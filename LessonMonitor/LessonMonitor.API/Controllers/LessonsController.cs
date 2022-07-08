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
        private ILessonService _lessonService;

        public LessonsController()
        {
            _lessonService = new LessonService();
        }

       [HttpPost("lessons/{lesson}")]
        public void Lessons(Lesson lesson)
        {
            _lessonService.Create(lesson);
        }
    }
}
