CREATE TABLE [dbo].[User] (
    [UserId]    INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NULL,
    [LastName]  VARCHAR (50) NULL,
    [UserName]  VARCHAR (50) NULL,
    [Password]  VARCHAR (50) NULL,
    [Email]     VARCHAR (50) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

