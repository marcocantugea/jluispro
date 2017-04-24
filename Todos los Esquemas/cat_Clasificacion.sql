USE [SARE]
GO

/****** Object:  Table [dbo].[cat_Clasificacion]    Script Date: 3/23/2017 1:31:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_Clasificacion](
	[clasificacion_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[clasificacion_Descripcion] [nvarchar](150) NULL,
	[clasificacion_activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[clasificacion_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[cat_Clasificacion] ADD  DEFAULT ((0)) FOR [clasificacion_activo]
GO

