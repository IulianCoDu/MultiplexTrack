CREATE TABLE [dbo].[Movie] (
    [MovieId]     INT            NOT NULL,
    [Title]       VARCHAR (50)   NULL,
    [Year]        DATE           NULL,
    [Type]        VARCHAR (2)    NULL,
    [Duration]    TIME (7)       NULL,
    [Category]    VARCHAR (50)   NULL,
    [Poster]      VARBINARY (50) NULL,
    [Description] VARCHAR (100)  NULL,
    CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED ([MovieId] ASC)
);

