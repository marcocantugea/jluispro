USE [SARE]
GO

/****** Object:  Table [dbo].[cat_Moneda]    Script Date: 3/23/2017 1:32:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_Moneda](
	[mon_Id] [int] NULL,
	[mon_Code] [nchar](10) NULL,
	[mon_Desc] [nchar](25) NULL
) ON [PRIMARY]

GO

