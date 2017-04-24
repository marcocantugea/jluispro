USE [SARE]
GO

/****** Object:  Table [dbo].[tab_ValesDetalle]    Script Date: 3/23/2017 2:09:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tab_ValesDetalle](
	[valeD_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[vale_Id] [bigint] NULL,
	[prod_Id] [bigint] NULL,
	[valeD_Cantidad] [decimal](18, 2) NULL,
	[valeD_Entregado] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tab_ValesDetalle] PRIMARY KEY CLUSTERED 
(
	[valeD_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tab_ValesDetalle]  WITH CHECK ADD  CONSTRAINT [FK_tab_ValesDetalle_cat_Productos] FOREIGN KEY([prod_Id])
REFERENCES [dbo].[cat_Productos] ([prod_Id])
GO

ALTER TABLE [dbo].[tab_ValesDetalle] CHECK CONSTRAINT [FK_tab_ValesDetalle_cat_Productos]
GO

