using LessonMonitor.Core;
using LessonMonitor.Core.Repositories;
using System.Collections.Generic;

namespace LessonMonitor.DataAccess
{
    public class LessonsRepository : IRepository<Lesson>
    {
        private readonly List<Lesson> _lessons = new List<Lesson>() 
        { 
            new Lesson() {Duration = default, 
                GroupName = "Hard", 
                Name = "ASP .NET Core", 
                StartDate = default,
                Topic = "Pagination"
            } 
        };
        public void Add(Lesson entity)
        {
            _lessons.Add(entity);
        }

        public Lesson[] Get()
        {
            return _lessons.ToArray();
        }

        public Lesson Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Lesson entity, int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
