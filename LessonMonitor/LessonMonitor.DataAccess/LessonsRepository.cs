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
        public int Add(Lesson entity)
        {
            _lessons.Add(entity);

            return entity.Id;
        }

        public Lesson[] Get()
        {
            return _lessons.ToArray();
        }

        public Lesson Get(int id)
        {
           return _lessons.Find(l => l.Id == id);
        }

        public bool Remove(int id)
        {
            if (_lessons.Remove(_lessons.Find(l => l.Id == id)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Update(Lesson entity, int id)
        {
           var index = _lessons.FindIndex(l => l.Id == id);

            _lessons[index] = entity;

            return id;
        }
    }
}
