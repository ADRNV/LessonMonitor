﻿using LessonMonitor.Core;
using LessonMonitor.Core.Services;
using System.Threading.Tasks;
using LessonMonitor.Core.Repositories;
using LessonMonitor.DataAccess;

namespace LessonMonitor.BL
{
    public class LessonsService : ILessonsService
    {
        private readonly IRepository<Lesson> _lessonRepository;

        public LessonsService(IRepository<Lesson> lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task Create(Lesson lesson)
        {
            await Task.Run(() => _lessonRepository.Add(lesson));
        }

        public async Task<Lesson> Find(params object[] serachParams)
        {
            return await Task.Run(() => _lessonRepository.Get((int)serachParams[0]));
        }

        public async Task Update(Lesson lesson)
        {
            throw new System.NotImplementedException();
        }
    }
}