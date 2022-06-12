CREATE TABLE [dbo].[Members]
(
	[MemberId] INT NOT NULL IDENTITY,
	[Name] NCHAR(10),
	[Age] INT,
	[Links] NCHAR(300),
	[Nicknames] NCHAR(300),
	LessonPk INTEGER NOT NULL FOREIGN KEY REFERENCES Lessons(LessonId)
)
