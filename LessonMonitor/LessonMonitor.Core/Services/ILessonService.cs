using LessonMonitor.Core.Entities;
using System.Threading.Tasks;

namespace LessonMonitor.Services
{
    public interface ILessonService
    {
        Task Create(Lesson lesson);

        Task Update(Lesson lesson);

        Task<Lesson> Find(params object[] serachParams);
    }
}
