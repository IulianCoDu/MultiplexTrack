CREATE TABLE [dbo].[MovieShowtime] (
    [MovieShowtimeId] INT NOT NULL,
    [TicketId]        INT NOT NULL,
    [MovieId]         INT NOT NULL,
    [RoomId]          INT NOT NULL,
    [TheatreId]       INT NOT NULL,
    [TimeSlotId]      INT NOT NULL,
    CONSTRAINT [PK_MovieShowtime] PRIMARY KEY CLUSTERED ([MovieShowtimeId] ASC),
    CONSTRAINT [FK_MovieShowtime_Movie] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([MovieId]),
    CONSTRAINT [FK_MovieShowtime_Room] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Room] ([RoomId]),
    CONSTRAINT [FK_MovieShowtime_Theatre] FOREIGN KEY ([TheatreId]) REFERENCES [dbo].[Theatre] ([TheatreId]),
    CONSTRAINT [FK_MovieShowtime_TimeSlot] FOREIGN KEY ([TimeSlotId]) REFERENCES [dbo].[TimeSlot] ([TimeSlotId])
);









