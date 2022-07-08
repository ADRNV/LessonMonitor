using LessonMonitor.Core;
using LessonMonitor.Core.Services;
using System.Threading.Tasks;

namespace LessonMonitor.BL
{
    public class MemberService : IMemberService
    {
        public Task<Member[]> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Member> Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
