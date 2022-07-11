using System;
using Moq;
using AutoFixture.AutoMoq;
using Xunit;
using AutoFixture;
using LessonMonitor.Core;
using LessonMonitor.Core.Repositories;
using System.Collections.Generic;

namespace LessonMonitor.DataAccess.Tests
{
    
    public class LessonsRepositoryTests
    {
        
        public LessonsRepositoryTests()
        {

        }

        [Fact]
        public void Get_Lessons_ShouldReturnAllLessons()
        {
            //arange
            var fixture = new Fixture();

            var lesson = fixture.Create<Lesson>();

            var mock = new Mock<IRepository<Lesson>>();

            mock.Setup(r => r.Add(lesson));

            mock.Setup(r => r.Get()).Returns(new List<Lesson>() { lesson }.ToArray());
        }
    }
}
