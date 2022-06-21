using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LessonMonitor.Core.Entities
{
    public class Member
    {
        public string Name { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        public string[] Links { get; set; }

    }
}
