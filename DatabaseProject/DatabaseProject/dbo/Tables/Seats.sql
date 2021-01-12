CREATE TABLE [dbo].[Seats] (
    [SeatId]     INT           IDENTITY (1, 1) NOT NULL,
    [SeatNumber] NVARCHAR (20) NOT NULL,
    [RoomId]     INT           NOT NULL,
    CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED ([SeatId] ASC),
    CONSTRAINT [FK_Seats_Room] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Room] ([RoomId])
);









