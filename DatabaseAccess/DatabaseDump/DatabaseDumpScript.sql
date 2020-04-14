USE [master]
GO
/****** Object:  Database [MultiplexTrack]    Script Date: 15/04/2020 00:25:18 ******/
CREATE DATABASE [MultiplexTrack]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Multiplex Track', FILENAME = N'D:\Programs\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Multiplex Track.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Multiplex Track_log', FILENAME = N'D:\Programs\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Multiplex Track_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Users]    Script Date: 15/04/2020 00:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[User] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [User], [Password], [Email]) VALUES (1, N'Iulian', N'Duduveche', N'IssHauti', N'P@r0la!', N'IssHauti@yahoo.com')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [User], [Password], [Email]) VALUES (2, N'Iulian2', N'Duduveche2', N'IssHauti2', N'P@r0la!', N'IssHauti@yahoo.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
USE [master]
GO
ALTER DATABASE [MultiplexTrack] SET  READ_WRITE 
GO
