CREATE TABLE [dbo].[Ticket] (
    [TicketId]        INT          NOT NULL,
    [MovieName]       VARCHAR (50) NOT NULL,
    [ScreenNumber]    VARCHAR (50) NOT NULL,
    [SeatNumber]      INT          NOT NULL,
    [StartHour]       DATETIME     NOT NULL,
    [Price]           INT          NOT NULL,
    [UserId]          INT          NOT NULL,
    [MovieShowtimeId] INT          NOT NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([TicketId] ASC),
    CONSTRAINT [FK_Ticket_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);



