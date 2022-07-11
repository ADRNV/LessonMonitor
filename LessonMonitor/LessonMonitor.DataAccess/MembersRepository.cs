using System;
using LessonMonitor.Core;
using LessonMonitor.Core.Repositories;

namespace LessonMonitor.DataAccess
{
    public class MembersRepository : IRepository<Member>
    {
        public int Add(Member entity)
        {
            throw new NotImplementedException();
        }

        public Member[] Get()
        {
            throw new NotImplementedException();
        }

        public Member Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Member entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
