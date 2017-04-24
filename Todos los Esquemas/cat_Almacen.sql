USE [SARE]
GO

/****** Object:  Table [dbo].[cat_Almacen]    Script Date: 3/23/2017 1:26:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_Almacen](
	[alm_Id] [int] NOT NULL,
	[alm_Code] [nchar](10) NULL,
	[alm_Nombre] [nvarchar](100) NULL,
	[alm_UOM] [nchar](10) NULL,
	[alm_Unitario] [numeric](16, 2) NULL,
	[alm_Marca] [nvarchar](50) NULL,
	[alm_StockMinimo] [int] NULL,
	[alm_StockIdeal] [int] NULL,
	[alm_NoParte] [nvarchar](50) NULL,
	[alm_Locacion] [nchar](10) NULL,
 CONSTRAINT [PK_cat_Almacen] PRIMARY KEY CLUSTERED 
(
	[alm_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

