CREATE TABLE [dbo].[TimeSlot] (
    [TimeSlotId]      INT      NOT NULL,
    [StartTime]       TIME (7) NOT NULL,
    [EndTime]         TIME (7) NOT NULL,
    [MovieShowTimeId] INT      NOT NULL,
    [UserId]          INT      NOT NULL,
    [RoomId]          INT      NOT NULL,
    CONSTRAINT [PK_TimeSlot] PRIMARY KEY CLUSTERED ([TimeSlotId] ASC),
    CONSTRAINT [FK_TimeSlot_Room] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Room] ([RoomId]),
    CONSTRAINT [FK_TimeSlot_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);





