CREATE TABLE [dbo].[TimeSlot] (
    [TimeSlotId]    INT      NOT NULL,
    [StartTime]     TIME (7) NOT NULL,
    [EndTime]       TIME (7) NOT NULL,
    [MovieShowTime] INT      NOT NULL,
    [User]          INT      NOT NULL,
    CONSTRAINT [PK_TimeSlot] PRIMARY KEY CLUSTERED ([TimeSlotId] ASC),
    CONSTRAINT [FK_TimeSlot_MovieShowtime] FOREIGN KEY ([MovieShowTime]) REFERENCES [dbo].[User] ([UserId]),
    CONSTRAINT [FK_TimeSlot_MovieShowtime1] FOREIGN KEY ([MovieShowTime]) REFERENCES [dbo].[MovieShowtime] ([MovieShowtimeId])
);

