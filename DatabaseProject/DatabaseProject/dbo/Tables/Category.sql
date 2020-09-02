CREATE TABLE [dbo].[Category] (
    [CategoryId] INT NOT NULL,
    [Comedy]     BIT NULL,
    [Drama]      BIT NULL,
    [Action]     BIT NULL,
    [Animation]  BIT NULL,
    [SciFi]      BIT NULL,
    [MovieId]    INT NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([CategoryId] ASC),
    CONSTRAINT [FK_Category_Movie] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([MovieId])
);



