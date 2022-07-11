using System;
using Moq;
using AutoFixture.AutoMoq;
using Xunit;
using AutoFixture;
using LessonMonitor.Core;
using LessonMonitor.Core.Repositories;
using System.Collections.Generic;
using LessonMonitor.DataAccess;

namespace LessonMonitor.DataAccess.Tests
{
    
    public class LessonsRepositoryTests
    {
        private readonly Mock<IRepository<Lesson>> _lessonsRepository;
        
        public LessonsRepositoryTests()
        {
            _lessonsRepository = new Mock<IRepository<Lesson>>();

            _lessonsRepository.Setup(l => l.Get()).Returns(It.IsNotNull<Lesson[]>);
        }

        [Fact]
        public void Get_Lessons_ShouldReturnAllLessons()
        {
            //arange
            var fixture = new Fixture();

            var lesson = fixture.Create<Lesson>();

            var lessons = _lessonsRepository
                .Setup(r => r.Get())//Implement
                .Returns(It.IsNotNull<Lesson[]>);//What return

            //act
            var actual = _lessonsRepository.Object.Get();//Call implementation

            //assert
            _lessonsRepository.Verify(l => l.Get());
        }

        [Fact]
        public void Get_Lesson_ShouldReturnLesson()
        {
            //arrange
            var fixture = new Fixture();

            var lesson = fixture.Create<Lesson>();

            _lessonsRepository.Setup(l => l.Add(It.IsNotNull<Lesson>()));
            
            _lessonsRepository.Setup(l => l.Get(lesson.Id)).Returns(lesson);
            
            //act
            var actual = _lessonsRepository.Object.Get(lesson.Id);

            //assert
            Assert.Equal(lesson, actual);
        }

        [Fact]
        public void Add_Lesson_ShuldReturnLessonId()
        {
            //arrange
            var fixture = new Fixture();

            var lesson = fixture.Create<Lesson>();

            _lessonsRepository.Setup(l => l.Add(lesson)).Returns(lesson.Id);

            _lessonsRepository.Setup(l => l.Get()).Returns(It.IsNotNull<Lesson[]>);

            //act
            var lessonId = _lessonsRepository.Object.Add(lesson);

            var lessonsCount = _lessonsRepository.Object.Get().Length;

            _lessonsRepository.Verify(l => l.Add(lesson));

            //assert
            Assert.Equal(lesson.Id, lessonId);

            Assert.Equal(1, lessonsCount);
        }

        public void Remove_Lesson_ShouldReturnTrue()
        {
            //arrange
            var fixture = new Fixture();

            var lesson = fixture.Create<Lesson>();

            _lessonsRepository.Setup(l => l.Add(lesson)).Returns(lesson.Id);

            _lessonsRepository.Setup(l => l.Remove(lesson.Id));

            //act
            var removed = _lessonsRepository.Object.Remove(lesson.Id);

            var lessonsCount = _lessonsRepository.Object.Get().Length;

            //assert
            _lessonsRepository.Verify(l => l.Remove(lesson.Id));

            Assert.True(removed);

            Assert.Equal(0, lessonsCount);
        }

        [Fact]
        public void Update_Lesson_ShouldReturnLessonId()
        {
            //arrange
            var fixture = new Fixture();

            var lesson = fixture.Create<Lesson>();

            _lessonsRepository.Setup(l => l.Add(It.IsAny<Lesson>()));

            _lessonsRepository.Setup(l => l.Update(It.IsAny<Lesson>(), It.IsAny<int>()));

            //act
            _lessonsRepository.Object.Add(lesson);

            _lessonsRepository.Object.Update(lesson, lesson.Id);

            //assert
            _lessonsRepository.Verify(l => l.Update(lesson, lesson.Id));
        }

    }
}
