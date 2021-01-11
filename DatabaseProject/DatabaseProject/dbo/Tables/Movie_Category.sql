CREATE TABLE [dbo].[Movie_Category] (
    [MovieId]    INT NOT NULL,
    [CategoryId] INT NOT NULL,
    CONSTRAINT [FK_Movie_Category_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId]),
    CONSTRAINT [FK_Movie_Category_Movie] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movie] ([MovieId])
);





