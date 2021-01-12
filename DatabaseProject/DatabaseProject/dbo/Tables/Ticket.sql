CREATE TABLE [dbo].[Ticket] (
    [TicketId]        INT IDENTITY (1, 1) NOT NULL,
    [UserId]          INT NOT NULL,
    [MovieShowtimeId] INT NOT NULL,
    [SeatId]          INT NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([TicketId] ASC),
    CONSTRAINT [FK_Ticket_MovieShowtime] FOREIGN KEY ([MovieShowtimeId]) REFERENCES [dbo].[MovieShowtime] ([MovieShowtimeId]),
    CONSTRAINT [FK_Ticket_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);













