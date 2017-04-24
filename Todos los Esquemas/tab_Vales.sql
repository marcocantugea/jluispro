USE [SARE]
GO

/****** Object:  Table [dbo].[tab_Vales]    Script Date: 3/23/2017 2:09:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tab_Vales](
	[vale_Id] [bigint] NOT NULL,
	[vale_Fecha] [date] NULL,
	[vale_Requirio] [nvarchar](50) NULL,
	[wo_Id] [int] NULL,
	[vale_Estado] [nvarchar](25) NULL,
 CONSTRAINT [PK_tab_OT_Material] PRIMARY KEY CLUSTERED 
(
	[vale_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

