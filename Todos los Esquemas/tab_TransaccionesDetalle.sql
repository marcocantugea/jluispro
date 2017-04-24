USE [SARE]
GO

/****** Object:  Table [dbo].[tab_TransaccionesDetalle]    Script Date: 3/23/2017 2:09:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tab_TransaccionesDetalle](
	[traDetalle_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[transaccion_Id] [bigint] NULL,
	[traDetalle_TIPO_MOVIMIENTO] [tinyint] NULL,
	[traDetalle_CONCEPTO_MOVTO] [int] NULL,
	[traDetalle_FECHA] [datetime] NULL,
	[traDetalle_PARTIDA] [int] NULL,
	[prod_Id] [bigint] NULL,
	[traDetalle_COSTO] [decimal](18, 4) NULL,
	[traDetalle_COSTO_UNITARIO] [decimal](18, 4) NULL,
	[almacen_Id] [bigint] NULL,
	[traDetalle_CANTIDAD_ENT] [decimal](18, 2) NULL,
	[traDetalle_CANTIDAD_SAL] [decimal](18, 2) NULL,
	[traDetalle_STATUS] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[traDetalle_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle] ADD  DEFAULT ((0)) FOR [traDetalle_TIPO_MOVIMIENTO]
GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle] ADD  DEFAULT ((0)) FOR [traDetalle_CONCEPTO_MOVTO]
GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle] ADD  DEFAULT ((0)) FOR [traDetalle_PARTIDA]
GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle] ADD  DEFAULT ((0)) FOR [traDetalle_COSTO]
GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle] ADD  DEFAULT ((0)) FOR [traDetalle_COSTO_UNITARIO]
GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle] ADD  DEFAULT ((0)) FOR [traDetalle_CANTIDAD_ENT]
GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle] ADD  DEFAULT ((0)) FOR [traDetalle_CANTIDAD_SAL]
GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle]  WITH CHECK ADD  CONSTRAINT [FK__tab_Trans__trans__7720AD13] FOREIGN KEY([prod_Id])
REFERENCES [dbo].[cat_Productos] ([prod_Id])
GO

ALTER TABLE [dbo].[tab_TransaccionesDetalle] CHECK CONSTRAINT [FK__tab_Trans__trans__7720AD13]
GO

