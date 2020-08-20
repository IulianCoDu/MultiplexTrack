CREATE TABLE [dbo].[MovieShowtime] (
    [MovieShowtimeId] INT      NOT NULL,
    [StartTime]       DATETIME NULL,
    [EndTime]         DATETIME NULL,
    [TicketsSold]     INT      NULL,
    [TicketsUnsold]   INT      NULL,
    [MovieId]         INT      NULL,
    [TheatreId]       INT      NULL,
    CONSTRAINT [PK_MovieShowtime] PRIMARY KEY CLUSTERED ([MovieShowtimeId] ASC),
    CONSTRAINT [FK_MovieShowtime_Movie] FOREIGN KEY ([MovieShowtimeId]) REFERENCES [dbo].[Movie] ([MovieId]),
    CONSTRAINT [FK_MovieShowtime_Theatre] FOREIGN KEY ([MovieShowtimeId]) REFERENCES [dbo].[Theatre] ([TheatreId])
);

