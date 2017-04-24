USE [SARE]
GO

/****** Object:  Table [dbo].[cat_TransaccionTipo]    Script Date: 3/23/2017 2:07:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_TransaccionTipo](
	[tranTip_Id] [int] NOT NULL,
	[tranTip_Desc] [nvarchar](50) NOT NULL,
	[Add_Remove] [int] NULL
) ON [PRIMARY]

GO

