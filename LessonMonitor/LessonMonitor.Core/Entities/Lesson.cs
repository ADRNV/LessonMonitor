using System;

namespace LessonMonitor.Core.Entities
{
    public class Lesson
    {

        public string Name { get; set; }

        public string Topic { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan Duration { get; set; }

        public string GroupName { get; set; }
    }
}
