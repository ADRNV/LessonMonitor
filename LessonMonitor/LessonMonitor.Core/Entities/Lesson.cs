using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
