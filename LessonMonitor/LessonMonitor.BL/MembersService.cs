using LessonMonitor.Core;
using LessonMonitor.Core.Services;
using LessonMonitor.Core.Repositories;
using System.Threading.Tasks;

namespace LessonMonitor.BL
{
    public class MembersService : IMembersService
    {
        private readonly IRepository<Member> _membersRepository;
        public MembersService(IRepository<Member> membersRepository)
        {
            _membersRepository = membersRepository;
        }

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
