USE [SARE]
GO

/****** Object:  Table [dbo].[tbl_OT_Trabajadores]    Script Date: 3/23/2017 2:09:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_OT_Trabajadores](
	[otTrab_Id] [int] NOT NULL,
	[emp_Id] [int] NOT NULL,
	[otTrab_Fecha] [datetime] NOT NULL,
	[otTrab_HorasTotal] [int] NULL,
	[otTrab_HorasCosto] [numeric](18, 0) NULL,
	[wo_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_OT_Trabajadores] PRIMARY KEY CLUSTERED 
(
	[otTrab_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_OT_Trabajadores]  WITH CHECK ADD  CONSTRAINT [FK_tbl_OT_Trabajadores_work_orders] FOREIGN KEY([emp_Id])
REFERENCES [dbo].[tab_Empleados] ([emp_Id])
GO

ALTER TABLE [dbo].[tbl_OT_Trabajadores] CHECK CONSTRAINT [FK_tbl_OT_Trabajadores_work_orders]
GO

