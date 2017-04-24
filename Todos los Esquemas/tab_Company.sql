USE [SARE]
GO

/****** Object:  Table [dbo].[tab_Company]    Script Date: 3/23/2017 2:08:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tab_Company](
	[com_id] [bigint] NOT NULL,
	[com_Code] [nchar](10) NULL,
	[com_Nom] [varchar](128) NULL,
	[com_NomAlias] [varchar](128) NULL,
	[com_Status] [varchar](3) NULL,
	[com_Date] [date] NULL,
	[com_Direccion] [varchar](255) NULL,
	[com_CP] [varchar](25) NULL,
	[com_Ciudad] [varchar](50) NULL,
	[com_Estado] [varchar](50) NULL,
	[com_Pais] [varchar](50) NULL,
	[com_Telefono] [varchar](20) NULL,
	[com_Telefono2] [varchar](20) NULL,
	[com_WebPage] [varchar](20) NULL,
	[com_Email] [varchar](128) NULL,
	[com_RFC] [varchar](128) NULL,
	[clipro_Id] [int] NULL,
	[com_Proveedor] [nchar](3) NULL,
	[com_IVA] [nchar](3) NULL,
	[com_ClienteTipo] [varchar](25) NULL,
	[com_Calle] [nvarchar](50) NULL,
	[com_NoExt] [nvarchar](10) NULL,
	[com_Localidad] [nvarchar](50) NULL,
	[categ_Id] [int] NULL,
	[com_Dolares] [bit] NULL,
	[metP_Id] [int] NULL,
	[com_Limite] [nvarchar](50) NULL,
	[com_Credito] [nvarchar](50) NULL,
	[com_Descuento] [int] NULL,
 CONSTRAINT [PK_tab_Company] PRIMARY KEY CLUSTERED 
(
	[com_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tab_Company]  WITH CHECK ADD  CONSTRAINT [FK_tab_Company_tab_Company] FOREIGN KEY([com_id])
REFERENCES [dbo].[tab_Company] ([com_id])
GO

ALTER TABLE [dbo].[tab_Company] CHECK CONSTRAINT [FK_tab_Company_tab_Company]
GO

