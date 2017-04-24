USE [SARE]
GO

/****** Object:  Table [dbo].[cat_Productos]    Script Date: 3/23/2017 2:07:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_Productos](
	[prod_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[prod_ClaveFabricante] [nvarchar](100) NULL,
	[prod_ClaveProducto] [nvarchar](100) NULL,
	[prod_Producto] [text] NOT NULL,
	[prod_Especificaciones] [text] NULL,
	[unidad_Id] [bigint] NOT NULL,
	[prod_Maximo] [decimal](18, 2) NULL,
	[prod_Minimo] [decimal](18, 2) NULL,
	[prod_Existencias] [decimal](18, 2) NULL,
	[prod_Precio] [decimal](18, 2) NULL,
	[prod_Locacion] [nvarchar](150) NULL,
	[prod_Fecha] [date] NULL,
	[prod_Activo] [bit] NULL,
	[prod_CantidadPendiente] [decimal](18, 2) NULL,
	[clasificacion_Id] [bigint] NOT NULL,
	[prod_ConMovimientos] [bit] NULL,
	[prod_RutaImagen] [bigint] NULL,
	[prod_DiasparaSurtir] [int] NULL,
	[prod_ULTIMO_PROVEEDOR] [bigint] NULL,
	[prod_ULTIMA_FECHACOMPRA] [date] NULL,
	[prod_COSTOTOTALMOVIMIENTOS] [decimal](18, 2) NULL,
	[prod_OPTIMO] [decimal](18, 2) NULL,
	[prod_TOTALENTRADAS] [decimal](18, 2) NULL,
	[prod_TOTALSALIDAS] [decimal](18, 2) NULL,
	[prod_PROMEDIO] [decimal](18, 2) NULL,
	[prod_Fabricante] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[prod_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [unidad_Id]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_Existencias]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_Precio]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_Activo]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_CantidadPendiente]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [clasificacion_Id]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_ConMovimientos]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_RutaImagen]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_DiasparaSurtir]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_COSTOTOTALMOVIMIENTOS]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_OPTIMO]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_TOTALENTRADAS]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_TOTALSALIDAS]
GO

ALTER TABLE [dbo].[cat_Productos] ADD  DEFAULT ((0)) FOR [prod_PROMEDIO]
GO

ALTER TABLE [dbo].[cat_Productos]  WITH CHECK ADD FOREIGN KEY([clasificacion_Id])
REFERENCES [dbo].[cat_Clasificacion] ([clasificacion_Id])
GO

ALTER TABLE [dbo].[cat_Productos]  WITH CHECK ADD FOREIGN KEY([unidad_Id])
REFERENCES [dbo].[cat_Unidades] ([unidad_Id])
GO

