USE [SARE]
GO

/****** Object:  Table [dbo].[cat_Unidades]    Script Date: 3/23/2017 2:07:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_Unidades](
	[unidad_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[unidad_Descripcion] [nvarchar](150) NULL,
	[unidad_activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[unidad_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[cat_Unidades] ADD  DEFAULT ((0)) FOR [unidad_activo]
GO

