CREATE TABLE [dbo].[Members]
(
	[MemberId] INT NOT NULL IDENTITY,
	[Name] NCHAR(10),
	[Age] INT,
	[Links] NCHAR(300),
	[Nicknames] NCHAR(300),
	[LessonId] INT NOT NULL CONSTRAINT FkLesson FOREIGN KEY (LessonId) 
        REFERENCES dbo.Lessons(LessonId)
)
