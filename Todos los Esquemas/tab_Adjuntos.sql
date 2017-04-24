USE [SARE]
GO

/****** Object:  Table [dbo].[tab_Adjuntos]    Script Date: 3/23/2017 2:07:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tab_Adjuntos](
	[adjunto_Id] [bigint] NOT NULL,
	[adjunto_DocNo] [nvarchar](15) NULL,
	[adjunto_Descripcion] [nvarchar](100) NULL,
	[adjunto_Path] [nvarchar](255) NULL,
 CONSTRAINT [PK_tab_Adjuntos] PRIMARY KEY CLUSTERED 
(
	[adjunto_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

