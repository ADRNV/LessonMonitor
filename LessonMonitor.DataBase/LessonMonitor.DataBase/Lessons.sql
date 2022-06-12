CREATE TABLE [dbo].[Lessons]
(
	[LessonId] INT NOT NULL IDENTITY PRIMARY KEY,
	[Name] NCHAR(10),
	[StartDate] DATETIME,
	[Duration] TIMESTAMP,
	[GroupName] NCHAR(10),
	[TopicId] INT FOREIGN KEY REFERENCES Topics(TopicId)
	
)

