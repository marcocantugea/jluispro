USE [SARE]
GO

/****** Object:  Table [dbo].[tab_AlmacenTransacciones]    Script Date: 3/23/2017 2:08:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tab_AlmacenTransacciones](
	[tran_Id] [int] NOT NULL,
	[alm_Id] [int] NULL,
	[tran_Fecha] [date] NULL,
	[tran_Hora] [time](7) NULL,
	[tran_Requirio] [nvarchar](50) NULL,
	[tran_Entrego] [nvarchar](50) NULL,
	[wo_Id] [int] NULL,
	[oc_Id] [int] NULL,
	[tran_Cantidad] [int] NULL,
	[tranTip_Desc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tab_AlmacenTransacciones] PRIMARY KEY CLUSTERED 
(
	[tran_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tab_AlmacenTransacciones]  WITH CHECK ADD  CONSTRAINT [FK_tab_AlmacenTransacciones_cat_Almacen] FOREIGN KEY([alm_Id])
REFERENCES [dbo].[cat_Almacen] ([alm_Id])
GO

ALTER TABLE [dbo].[tab_AlmacenTransacciones] CHECK CONSTRAINT [FK_tab_AlmacenTransacciones_cat_Almacen]
GO

ALTER TABLE [dbo].[tab_AlmacenTransacciones]  WITH CHECK ADD  CONSTRAINT [FK_tab_AlmacenTransacciones_tab_AlmacenTransacciones] FOREIGN KEY([tran_Id])
REFERENCES [dbo].[tab_AlmacenTransacciones] ([tran_Id])
GO

ALTER TABLE [dbo].[tab_AlmacenTransacciones] CHECK CONSTRAINT [FK_tab_AlmacenTransacciones_tab_AlmacenTransacciones]
GO

