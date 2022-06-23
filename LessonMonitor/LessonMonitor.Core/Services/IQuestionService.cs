using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonMonitor.Core.Entities;

namespace LessonMonitor.Core.Services
{
    public interface IQuestionService
    {
        Task<Question[]> Get();

        Task<Question> Get(int id);

        Task Create(Question question);
    }
}
