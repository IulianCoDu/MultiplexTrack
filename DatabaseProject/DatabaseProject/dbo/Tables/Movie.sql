CREATE TABLE [dbo].[Movie] (
    [MovieId]     INT           IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (50) NOT NULL,
    [Year]        NVARCHAR (50) NOT NULL,
    [Duration]    NVARCHAR (50) NOT NULL,
    [Poster]      VARCHAR (100) NOT NULL,
    [Description] VARCHAR (100) NOT NULL,
    [UserId]      INT           NOT NULL,
    [TimeSlotId]  INT           NOT NULL,
    CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED ([MovieId] ASC),
    CONSTRAINT [FK_Movie_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);















