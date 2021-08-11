USE [master]
GO

CREATE DATABASE [TuDien]

USE [TuDien]
GO
/****** Object:  Table [dbo].[TuDien]    Script Date: 8/9/2021 8:37:34 PM ******/
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
