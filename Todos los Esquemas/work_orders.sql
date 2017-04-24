USE [SARE]
GO

/****** Object:  Table [dbo].[work_orders]    Script Date: 3/23/2017 2:09:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[work_orders](
	[wo_Id] [bigint] NOT NULL,
	[wo_Code] [nchar](6) NULL,
	[wo_Title] [nchar](150) NULL,
	[proy_Id] [int] NULL,
	[com_Id] [int] NULL,
	[cot_Id] [int] NULL,
	[wo_CreatedDate] [date] NULL,
	[wo_PlanInicio] [date] NULL,
	[wo_PlanTermino] [date] NULL,
	[wo_Description] [nvarchar](max) NULL,
	[wo_Coment] [nvarchar](max) NULL,
	[wo_Status] [int] NULL,
	[wo_MaterialCosto] [numeric](18, 0) NULL,
	[wo_HorasHombre] [int] NULL,
	[wo_HorasCosto] [numeric](18, 0) NULL,
	[wo_Avance] [int] NULL,
	[wo_PorcenProyecto] [int] NULL,
	[emp_Id] [int] NOT NULL,
 CONSTRAINT [PK_work_orders] PRIMARY KEY CLUSTERED 
(
	[wo_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

