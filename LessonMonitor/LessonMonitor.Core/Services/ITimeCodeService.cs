using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonMonitor.Core.Entities;

namespace LessonMonitor.Core.Services
{
    public interface ITimeCodeService
    {
        Task<TimeCode[]> Get();

        Task<TimeCode> Get(int id);

        Task<TimeCode> Create(TimeCode timeCode);
    }
}
