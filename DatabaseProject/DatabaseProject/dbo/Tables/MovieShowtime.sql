CREATE TABLE [dbo].[MovieShowtime] (
    [MovieShowtimeId] INT NOT NULL,
    [Ticket]          INT NOT NULL,
    CONSTRAINT [PK_MovieShowtime] PRIMARY KEY CLUSTERED ([MovieShowtimeId] ASC),
    CONSTRAINT [FK_MovieShowtime_Ticket] FOREIGN KEY ([Ticket]) REFERENCES [dbo].[Ticket] ([TicketId])
);



