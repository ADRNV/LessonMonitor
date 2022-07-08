using System.Collections.Generic;

namespace LessonMonitor.Core.Repositories
{
    public interface IRepository<T>
    {
        T[] Get();

        T Get(int id);

        void Add(T entity);

        void Update(T entity, int id);

        void Remove(int id);
    }
}
