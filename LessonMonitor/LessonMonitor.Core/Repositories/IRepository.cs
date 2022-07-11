using System.Collections.Generic;

namespace LessonMonitor.Core.Repositories
{
    public interface IRepository<T>
    {
        T[] Get();

        T Get(int id);

        int Add(T entity);

        int Update(T entity, int id);

        bool Remove(int id);
    }
}
