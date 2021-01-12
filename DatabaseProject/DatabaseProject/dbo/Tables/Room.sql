CREATE TABLE [dbo].[Room] (
    [RoomId]     INT           IDENTITY (1, 1) NOT NULL,
    [RoomNumber] NVARCHAR (20) NOT NULL,
    [TheatreId]  INT           NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([RoomId] ASC),
    CONSTRAINT [FK_Room_Theatre] FOREIGN KEY ([TheatreId]) REFERENCES [dbo].[Theatre] ([TheatreId])
);







