using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonMonitor.Core;

namespace LessonMonitor.Core.Services
{
    public interface IMemberService
    {
        Task<Member[]> Get();

        Task<Member> Get(int id);
    }
}
