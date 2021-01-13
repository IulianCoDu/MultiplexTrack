CREATE TABLE [dbo].[Movie_Category] (
    [MovieId]    INT NOT NULL,
    [CategoryId] INT NOT NULL,
    CONSTRAINT [PK_Movie_Category_1] PRIMARY KEY CLUSTERED ([MovieId] ASC, [CategoryId] ASC),
    CONSTRAINT [FK_Movie_Category_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId]),
    CONSTRAINT [FK_Movie_Category_Movie] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([MovieId])
);







