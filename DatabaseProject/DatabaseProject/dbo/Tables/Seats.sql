CREATE TABLE [dbo].[Seats] (
    [SeatId]     INT         NOT NULL,
    [SeatNumber] VARCHAR (2) NULL,
    [TheatreId]  INT         NULL,
    CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED ([SeatId] ASC),
    CONSTRAINT [FK_Seats_Theatre] FOREIGN KEY ([TheatreId]) REFERENCES [dbo].[Theatre] ([TheatreId])
);

