using System;

namespace LessonMonitor.Core.Entities
{
    public class TimeCode
    {
        public int Id { get; set; }
        public string Topic { get; set; }

        public TimeSpan Time { get; set; }

    }
}
