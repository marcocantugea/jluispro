USE [SARE]
GO

/****** Object:  Table [dbo].[tab_Transacciones]    Script Date: 3/23/2017 2:08:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tab_Transacciones](
	[transaccion_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[transaccion_REFERENCIA] [text] NULL,
	[transaccion_TIPO_MOVIMIENTO] [tinyint] NULL,
	[transaccion_FECHA] [datetime] NULL,
	[emp_Id] [bigint] NULL,
	[transaccion_CONCEPTO_MOVTO] [int] NULL,
	[ID_DESTINOS] [bigint] NULL,
	[com_id] [bigint] NULL,
	[transaccion_MONTO] [decimal](18, 2) NULL,
	[divisas_Id] [bigint] NULL,
	[transaccion_TIPO_DE_CAMBIO] [decimal](18, 4) NULL,
	[OC_Id] [bigint] NULL,
	[almacen_Id] [bigint] NULL,
	[transaccion_DOCUMENTO] [text] NULL,
	[almacenTraspaso_Id] [bigint] NULL,
	[transaccion_OBSERVACION] [text] NULL,
	[transaccion_FolioReferencia] [int] NULL,
	[CLAVE_UNICA_DB] [text] NULL,
	[wo_Id] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[transaccion_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[tab_Transacciones] ADD  DEFAULT ((0)) FOR [transaccion_TIPO_MOVIMIENTO]
GO

ALTER TABLE [dbo].[tab_Transacciones] ADD  DEFAULT ((0)) FOR [emp_Id]
GO

ALTER TABLE [dbo].[tab_Transacciones] ADD  DEFAULT ((0)) FOR [transaccion_CONCEPTO_MOVTO]
GO

ALTER TABLE [dbo].[tab_Transacciones] ADD  DEFAULT ((0)) FOR [ID_DESTINOS]
GO

ALTER TABLE [dbo].[tab_Transacciones] ADD  DEFAULT ((0)) FOR [com_id]
GO

ALTER TABLE [dbo].[tab_Transacciones] ADD  DEFAULT ((0)) FOR [divisas_Id]
GO

ALTER TABLE [dbo].[tab_Transacciones]  WITH CHECK ADD FOREIGN KEY([divisas_Id])
REFERENCES [dbo].[cat_Divisas] ([divisa_Id])
GO

