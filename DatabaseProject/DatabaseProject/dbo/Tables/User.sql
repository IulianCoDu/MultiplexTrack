CREATE TABLE [dbo].[User] (
    [UserId]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]     VARCHAR (50) NOT NULL,
    [LastName]      VARCHAR (50) NOT NULL,
    [UserName]      VARCHAR (50) NOT NULL,
    [Password]      VARCHAR (50) NOT NULL,
    [Email]         VARCHAR (50) NOT NULL,
    [Administrator] BIT          NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);



