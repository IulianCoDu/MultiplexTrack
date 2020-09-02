CREATE TABLE [dbo].[Room] (
    [RoomId]     INT NOT NULL,
    [RoomNumber] INT NOT NULL,
    [TheatreId]  INT NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([RoomId] ASC),
    CONSTRAINT [FK_Room_Theatre] FOREIGN KEY ([TheatreId]) REFERENCES [dbo].[Theatre] ([TheatreId])
);

