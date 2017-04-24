USE [SARE]
GO

/****** Object:  Table [dbo].[cat_Divisas]    Script Date: 3/23/2017 1:32:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_Divisas](
	[divisa_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[divisa_DESCRIPCION] [nvarchar](150) NULL,
	[divisa_SIMBOLO_MONEDA] [nvarchar](5) NULL,
	[divisa_FECHA_ULTIMA_COTIZACION] [date] NULL,
	[divisa_COTIZACION_UNITARIA] [decimal](18, 2) NULL,
	[divisa_FUENTE_COTIZACION] [text] NULL,
	[divisa_PREDETERMINADO] [bit] NULL,
	[divisa_ABREVIATURA] [nvarchar](10) NULL,
	[divisa_activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[divisa_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[cat_Divisas] ADD  DEFAULT ((0)) FOR [divisa_activo]
GO

