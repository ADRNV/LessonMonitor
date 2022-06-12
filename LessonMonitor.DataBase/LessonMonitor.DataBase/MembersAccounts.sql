CREATE TABLE [dbo].[MembersAccounts]
(
	[GitHub] NCHAR,
	[Youtube] NCHAR,
	[MemberId] INT NOT NULL CONSTRAINT FkMember FOREIGN KEY (MemberId) REFERENCES dbo.Members(MemberId)
)
