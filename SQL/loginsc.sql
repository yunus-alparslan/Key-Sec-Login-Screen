USE [loginsc]
GO
/****** Object:  Table [dbo].[LoginTester]    Script Date: 12.04.2023 21:44:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginTester](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[kullaniciadi] [varchar](10) NULL,
	[sifre] [smallint] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoginTester] ON 

INSERT [dbo].[LoginTester] ([id], [kullaniciadi], [sifre]) VALUES (1, N'test', 12345)
SET IDENTITY_INSERT [dbo].[LoginTester] OFF
GO
