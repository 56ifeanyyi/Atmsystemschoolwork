CREATE TABLE [dbo].[ClientTable] (
    [Id]             INT      IDENTITY (1, 1) NOT NULL,
    [mobileNumber]   BIGINT   NULL,
    [pin]            INT      NULL,
    [initialBalance] INT      NULL,
    [lastLoggedIn]   DATETIME NULL,
	[dailyLimit]	 INT      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

