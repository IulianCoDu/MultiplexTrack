USE [master]
GO
/****** Object:  Database [MultiplexTrack]    Script Date: 13.01.2021 23:26:36 ******/
CREATE DATABASE [MultiplexTrack]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Multiplex Track', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Multiplex Track.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Multiplex Track_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Multiplex Track_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MultiplexTrack] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MultiplexTrack].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MultiplexTrack] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [MultiplexTrack] SET ANSI_NULLS ON 
GO
ALTER DATABASE [MultiplexTrack] SET ANSI_PADDING ON 
GO
ALTER DATABASE [MultiplexTrack] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [MultiplexTrack] SET ARITHABORT ON 
GO
ALTER DATABASE [MultiplexTrack] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MultiplexTrack] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MultiplexTrack] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MultiplexTrack] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MultiplexTrack] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [MultiplexTrack] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [MultiplexTrack] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MultiplexTrack] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [MultiplexTrack] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MultiplexTrack] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MultiplexTrack] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MultiplexTrack] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MultiplexTrack] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MultiplexTrack] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MultiplexTrack] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MultiplexTrack] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MultiplexTrack] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MultiplexTrack] SET RECOVERY FULL 
GO
ALTER DATABASE [MultiplexTrack] SET  MULTI_USER 
GO
ALTER DATABASE [MultiplexTrack] SET PAGE_VERIFY NONE  
GO
ALTER DATABASE [MultiplexTrack] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MultiplexTrack] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MultiplexTrack] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MultiplexTrack] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MultiplexTrack', N'ON'
GO
ALTER DATABASE [MultiplexTrack] SET QUERY_STORE = OFF
GO
USE [MultiplexTrack]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Year] [nvarchar](50) NOT NULL,
	[Duration] [nvarchar](50) NOT NULL,
	[Poster] [varchar](100) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie_Category]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie_Category](
	[MovieId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Movie_Category_1] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieShowtime]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieShowtime](
	[MovieShowtimeId] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
	[TheatreId] [int] NOT NULL,
	[TimeSlotId] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_MovieShowtime] PRIMARY KEY CLUSTERED 
(
	[MovieShowtimeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [nvarchar](20) NOT NULL,
	[TheatreId] [int] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seats]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seats](
	[SeatId] [int] IDENTITY(1,1) NOT NULL,
	[SeatNumber] [nvarchar](20) NOT NULL,
	[RoomId] [int] NOT NULL,
 CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED 
(
	[SeatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Theatre]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Theatre](
	[TheatreId] [int] IDENTITY(1,1) NOT NULL,
	[TheatreName] [nvarchar](50) NOT NULL,
	[TheatreLocation] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Theatre] PRIMARY KEY CLUSTERED 
(
	[TheatreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[TicketId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[MovieShowtimeId] [int] NOT NULL,
	[SeatId] [int] NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeSlot]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSlot](
	[TimeSlotId] [int] IDENTITY(1,1) NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
 CONSTRAINT [PK_TimeSlot] PRIMARY KEY CLUSTERED 
(
	[TimeSlotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 13.01.2021 23:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Administrator] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Action')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Adventure')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (3, N'Comedy')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([MovieId], [Title], [Year], [Duration], [Poster], [Description], [UserId]) VALUES (15, N'sdfsdf', N'2000', N'01:00:00', N'D:\ProgrammingProjects\GitHub\source\repos\MultiplexTrack\PosterPictures\Matrix1.jpg', N'sdfsdff', 1)
INSERT [dbo].[Movie] ([MovieId], [Title], [Year], [Duration], [Poster], [Description], [UserId]) VALUES (16, N'sdfsdf', N'2000', N'01:00:00', N'D:\ProgrammingProjects\GitHub\source\repos\MultiplexTrack\PosterPictures\Matrix1.jpg', N'sfdsfsdf', 1)
INSERT [dbo].[Movie] ([MovieId], [Title], [Year], [Duration], [Poster], [Description], [UserId]) VALUES (17, N'sfdsfsdf', N'2000', N'02:00:00', N'D:\ProgrammingProjects\GitHub\source\repos\MultiplexTrack\PosterPictures\Matrix1.jpg', N'sdfsdf', 1)
SET IDENTITY_INSERT [dbo].[Movie] OFF
GO
INSERT [dbo].[Movie_Category] ([MovieId], [CategoryId]) VALUES (16, 1)
INSERT [dbo].[Movie_Category] ([MovieId], [CategoryId]) VALUES (16, 2)
INSERT [dbo].[Movie_Category] ([MovieId], [CategoryId]) VALUES (17, 1)
INSERT [dbo].[Movie_Category] ([MovieId], [CategoryId]) VALUES (17, 2)
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([RoomId], [RoomNumber], [TheatreId]) VALUES (1, N'RoomNumber1', 1)
INSERT [dbo].[Room] ([RoomId], [RoomNumber], [TheatreId]) VALUES (5, N'RoomNumber2', 2)
INSERT [dbo].[Room] ([RoomId], [RoomNumber], [TheatreId]) VALUES (6, N'RoomNumber3', 3)
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Seats] ON 

INSERT [dbo].[Seats] ([SeatId], [SeatNumber], [RoomId]) VALUES (1, N'SeatNumber1', 1)
INSERT [dbo].[Seats] ([SeatId], [SeatNumber], [RoomId]) VALUES (4, N'SeatNumber2', 5)
INSERT [dbo].[Seats] ([SeatId], [SeatNumber], [RoomId]) VALUES (5, N'SeatNumber3', 6)
SET IDENTITY_INSERT [dbo].[Seats] OFF
GO
SET IDENTITY_INSERT [dbo].[Theatre] ON 

INSERT [dbo].[Theatre] ([TheatreId], [TheatreName], [TheatreLocation]) VALUES (1, N'TheatreName1', N'TheatreLocation1')
INSERT [dbo].[Theatre] ([TheatreId], [TheatreName], [TheatreLocation]) VALUES (2, N'TheatreName2', N'TheatreLocation2')
INSERT [dbo].[Theatre] ([TheatreId], [TheatreName], [TheatreLocation]) VALUES (3, N'TheatreName3', N'TheatreLocation3')
SET IDENTITY_INSERT [dbo].[Theatre] OFF
GO
SET IDENTITY_INSERT [dbo].[TimeSlot] ON 

INSERT [dbo].[TimeSlot] ([TimeSlotId], [StartTime], [EndTime], [UserId], [RoomId]) VALUES (1, CAST(N'10:00:00' AS Time), CAST(N'11:00:00' AS Time), 1, 1)
SET IDENTITY_INSERT [dbo].[TimeSlot] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [UserName], [Password], [Email], [Administrator]) VALUES (1, N'Iulian1', N'Duduveche1', N'user1', N'parola1', N'IssHauti@yahoo.com', NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [UserName], [Password], [Email], [Administrator]) VALUES (2, N'Iulian2', N'Duduveche2', N'user2', N'parola2', N'IssHauti@yahoo.com', NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [UserName], [Password], [Email], [Administrator]) VALUES (7, N'Iulian3', N'Duduveche3', N'user3', N'parola3', N'IssHauti@yahoo.com', 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_User]
GO
ALTER TABLE [dbo].[Movie_Category]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Category_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Movie_Category] CHECK CONSTRAINT [FK_Movie_Category_Category]
GO
ALTER TABLE [dbo].[Movie_Category]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Category_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([MovieId])
GO
ALTER TABLE [dbo].[Movie_Category] CHECK CONSTRAINT [FK_Movie_Category_Movie]
GO
ALTER TABLE [dbo].[MovieShowtime]  WITH CHECK ADD  CONSTRAINT [FK_MovieShowtime_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([MovieId])
GO
ALTER TABLE [dbo].[MovieShowtime] CHECK CONSTRAINT [FK_MovieShowtime_Movie]
GO
ALTER TABLE [dbo].[MovieShowtime]  WITH CHECK ADD  CONSTRAINT [FK_MovieShowtime_Room] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
GO
ALTER TABLE [dbo].[MovieShowtime] CHECK CONSTRAINT [FK_MovieShowtime_Room]
GO
ALTER TABLE [dbo].[MovieShowtime]  WITH CHECK ADD  CONSTRAINT [FK_MovieShowtime_Theatre] FOREIGN KEY([TheatreId])
REFERENCES [dbo].[Theatre] ([TheatreId])
GO
ALTER TABLE [dbo].[MovieShowtime] CHECK CONSTRAINT [FK_MovieShowtime_Theatre]
GO
ALTER TABLE [dbo].[MovieShowtime]  WITH CHECK ADD  CONSTRAINT [FK_MovieShowtime_TimeSlot] FOREIGN KEY([TimeSlotId])
REFERENCES [dbo].[TimeSlot] ([TimeSlotId])
GO
ALTER TABLE [dbo].[MovieShowtime] CHECK CONSTRAINT [FK_MovieShowtime_TimeSlot]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Theatre] FOREIGN KEY([TheatreId])
REFERENCES [dbo].[Theatre] ([TheatreId])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Theatre]
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [FK_Seats_Room] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [FK_Seats_Room]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_MovieShowtime] FOREIGN KEY([MovieShowtimeId])
REFERENCES [dbo].[MovieShowtime] ([MovieShowtimeId])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_MovieShowtime]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_User]
GO
ALTER TABLE [dbo].[TimeSlot]  WITH CHECK ADD  CONSTRAINT [FK_TimeSlot_Room] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
GO
ALTER TABLE [dbo].[TimeSlot] CHECK CONSTRAINT [FK_TimeSlot_Room]
GO
ALTER TABLE [dbo].[TimeSlot]  WITH CHECK ADD  CONSTRAINT [FK_TimeSlot_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[TimeSlot] CHECK CONSTRAINT [FK_TimeSlot_User]
GO
USE [master]
GO
ALTER DATABASE [MultiplexTrack] SET  READ_WRITE 
GO
