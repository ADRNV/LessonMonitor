using LessonMonitor.Core;
using System.Threading.Tasks;

namespace LessonMonitor.Core.Services
{
    public interface ILessonService
    {
        Task Create(Lesson lesson);

        Task Update(Lesson lesson);

        Task<Lesson> Find(params object[] serachParams);
    }
}
