CREATE TABLE [dbo].[Ticket] (
    [TicketId]        INT           IDENTITY (1, 1) NOT NULL,
    [MovieName]       NVARCHAR (50) NOT NULL,
    [ScreenNumber]    NVARCHAR (50) NOT NULL,
    [SeatNumber]      INT           NOT NULL,
    [StartHour]       DATETIME      NOT NULL,
    [Price]           INT           NOT NULL,
    [UserId]          INT           NOT NULL,
    [MovieShowtimeId] INT           NOT NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([TicketId] ASC),
    CONSTRAINT [FK_Ticket_MovieShowtime] FOREIGN KEY ([MovieShowtimeId]) REFERENCES [dbo].[MovieShowtime] ([MovieShowtimeId]),
    CONSTRAINT [FK_Ticket_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);











