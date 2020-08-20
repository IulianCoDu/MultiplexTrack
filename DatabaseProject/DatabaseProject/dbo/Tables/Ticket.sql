CREATE TABLE [dbo].[Ticket] (
    [TicketId]        INT          NOT NULL,
    [MovieName]       VARCHAR (50) NULL,
    [ScreenNumber]    VARCHAR (50) NULL,
    [SeatNumber]      INT          NULL,
    [StartHour]       DATETIME     NULL,
    [Price]           INT          NULL,
    [UserId]          INT          NULL,
    [MovieShowtimeId] INT          NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([TicketId] ASC),
    CONSTRAINT [FK_Ticket_Movie] FOREIGN KEY ([MovieShowtimeId]) REFERENCES [dbo].[MovieShowtime] ([MovieShowtimeId]),
    CONSTRAINT [FK_Ticket_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);

