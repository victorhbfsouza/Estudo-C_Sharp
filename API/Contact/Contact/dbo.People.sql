CREATE TABLE [dbo].[People]
(
	[ContactId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(100) NULL, 
    [Company] VARCHAR(100) NULL, 
    [Telephone] VARCHAR(100) NULL, 
    [Email] VARCHAR(100) NULL, 
    [Client] BIT NULL, 
    [LasCall] DATETIME NULL
)
