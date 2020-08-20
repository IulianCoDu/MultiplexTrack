CREATE TABLE [dbo].[Theatre] (
    [TheatreId]     INT NOT NULL,
    [RoomNumber]    INT NULL,
    [NumberOfSeats] INT NULL,
    CONSTRAINT [PK_Theatre] PRIMARY KEY CLUSTERED ([TheatreId] ASC)
);

