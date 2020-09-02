CREATE TABLE [dbo].[Theatre] (
    [TheatreId]       INT          NOT NULL,
    [TheatreName]     VARCHAR (50) NOT NULL,
    [TheatreLocation] VARCHAR (50) NOT NULL,
    [MovieShowTime]   INT          NOT NULL,
    CONSTRAINT [PK_Theatre] PRIMARY KEY CLUSTERED ([TheatreId] ASC),
    CONSTRAINT [FK_Theatre_MovieShowtime] FOREIGN KEY ([MovieShowTime]) REFERENCES [dbo].[MovieShowtime] ([MovieShowtimeId])
);



