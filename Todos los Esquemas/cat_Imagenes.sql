USE [SARE]
GO

/****** Object:  Table [dbo].[cat_Imagenes]    Script Date: 3/23/2017 1:32:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_Imagenes](
	[imagenes_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[imagenes_ruta] [nvarchar](255) NULL,
	[imagenes_activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[imagenes_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[cat_Imagenes] ADD  DEFAULT ((1)) FOR [imagenes_activo]
GO

