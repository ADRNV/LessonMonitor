using System;

namespace LessonMonitor.Core
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Topic { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan Duration { get; set; }

        public string GroupName { get; set; }
    }
}
