CREATE TABLE [dbo].[Seats] (
    [SeatId]     INT          NOT NULL,
    [SeatNumber] NVARCHAR (2) NOT NULL,
    [RoomId]     INT          NOT NULL,
    CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED ([SeatId] ASC),
    CONSTRAINT [FK_Seats_Room] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Room] ([RoomId]),
    CONSTRAINT [FK_Seats_Ticket] FOREIGN KEY ([SeatId]) REFERENCES [dbo].[Ticket] ([TicketId])
);





