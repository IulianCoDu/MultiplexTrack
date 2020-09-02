CREATE TABLE [dbo].[Movie] (
    [MovieId]       INT            NOT NULL,
    [Title]         VARCHAR (50)   NOT NULL,
    [Year]          DATE           NOT NULL,
    [Type]          VARCHAR (2)    NOT NULL,
    [Duration]      TIME (7)       NOT NULL,
    [Poster]        VARBINARY (50) NULL,
    [Description]   VARCHAR (100)  NULL,
    [MovieShowTime] INT            NOT NULL,
    [User]          INT            NOT NULL,
    CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED ([MovieId] ASC),
    CONSTRAINT [FK_Movie_MovieShowtime] FOREIGN KEY ([MovieShowTime]) REFERENCES [dbo].[MovieShowtime] ([MovieShowtimeId]),
    CONSTRAINT [FK_Movie_User] FOREIGN KEY ([User]) REFERENCES [dbo].[User] ([UserId])
);



