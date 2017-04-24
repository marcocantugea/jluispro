USE [SARE]
GO

/****** Object:  Table [dbo].[cat_StatusOTs]    Script Date: 3/23/2017 2:07:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_StatusOTs](
	[statOT_Id] [int] NOT NULL,
	[statOT_Desc] [nvarchar](50) NULL,
	[statOT_Porciento] [int] NULL
) ON [PRIMARY]

GO

