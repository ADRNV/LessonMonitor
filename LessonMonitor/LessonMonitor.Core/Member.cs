using System;
using System.ComponentModel.DataAnnotations;

namespace LessonMonitor.Core
{
    public class Member
    {
        public string Name { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        public string[] Links { get; set; }

    }
}
