USE [master]
GO
/****** Object:  Database [TuDien]    Script Date: 8/21/2021 5:06:28 PM ******/
CREATE DATABASE [TuDien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TuDien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.PHUONGTAN\MSSQL\DATA\TuDien.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TuDien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.PHUONGTAN\MSSQL\DATA\TuDien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TuDien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TuDien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TuDien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TuDien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TuDien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TuDien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TuDien] SET ARITHABORT OFF 
GO
ALTER DATABASE [TuDien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TuDien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TuDien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TuDien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TuDien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TuDien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TuDien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TuDien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TuDien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TuDien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TuDien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TuDien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TuDien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TuDien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TuDien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TuDien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TuDien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TuDien] SET RECOVERY FULL 
GO
ALTER DATABASE [TuDien] SET  MULTI_USER 
GO
ALTER DATABASE [TuDien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TuDien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TuDien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TuDien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TuDien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TuDien', N'ON'
GO
USE [TuDien]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/21/2021 5:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](30) NOT NULL,
	[Password] [nchar](10) NULL,
	[UserLevel] [varchar](20) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 8/21/2021 5:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[Anh] [varchar](50) NOT NULL,
	[Viet] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[Anh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuDien]    Script Date: 8/21/2021 5:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuDien](
	[MaTu] [int] IDENTITY(1,1) NOT NULL,
	[NghiaTA] [nvarchar](50) NULL,
	[LoaiTu] [nvarchar](50) NULL,
	[NghiaTV] [nvarchar](50) NULL,
	[ViDu] [nvarchar](50) NOT NULL,
	[PhienAm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [Password], [UserLevel]) VALUES (N'Tan', N'123456    ', N'Admin')
INSERT [dbo].[Account] ([UserName], [Password], [UserLevel]) VALUES (N'Tan1', N'123456    ', N'Customer')
GO
SET IDENTITY_INSERT [dbo].[TuDien] ON 

INSERT [dbo].[TuDien] ([MaTu], [NghiaTA], [LoaiTu], [NghiaTV], [ViDu], [PhienAm]) VALUES (1, N'Hello', N'Trạng Từ', N'Xin Chào', N'Dùng để chào hỏi', N'hế lô')
INSERT [dbo].[TuDien] ([MaTu], [NghiaTA], [LoaiTu], [NghiaTV], [ViDu], [PhienAm]) VALUES (2, N'Sleep', N'Động từ', N'Đi ngủ', N'Thể hiện đi ngủ', N'sờ líp')
INSERT [dbo].[TuDien] ([MaTu], [NghiaTA], [LoaiTu], [NghiaTV], [ViDu], [PhienAm]) VALUES (3, N'Good Bye', N'Trạng từ', N'Tạm biệt', N'Dùng để chào tạm biệt', N'gút bai')
INSERT [dbo].[TuDien] ([MaTu], [NghiaTA], [LoaiTu], [NghiaTV], [ViDu], [PhienAm]) VALUES (4, N'Help', N'Động từ', N'Giúp đỡ', N'Dùng để giúp đỡ', N'hếp')
SET IDENTITY_INSERT [dbo].[TuDien] OFF
GO
USE [master]
GO
ALTER DATABASE [TuDien] SET  READ_WRITE 
GO
