using System.Threading.Tasks;

namespace LessonMonitor.Core.Services
{
    public interface IMembersService
    {
        Task<Member[]> Get();

        Task<Member> Get(int id);
    }
}
