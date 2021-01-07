CREATE TABLE [dbo].[Theatre] (
    [TheatreId]       INT            IDENTITY (1, 1) NOT NULL,
    [TheatreName]     NVARCHAR (50)  NOT NULL,
    [TheatreLocation] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Theatre] PRIMARY KEY CLUSTERED ([TheatreId] ASC)
);









