Drop database IF EXISTS ClientDatabase;
DROP Table [dbo].[ClientTable];



CREATE TABLE [dbo].[ClientTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[mobileNumber] BIGINT NULL,
    [pin] INT,
	[initialBalance] INT,
	[lastLoggedIn] DATETIME


)
delete from ClientTable;
select * from ClientTable;