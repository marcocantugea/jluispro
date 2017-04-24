USE [SARE]
GO

/****** Object:  Table [dbo].[tab_Empleados]    Script Date: 3/23/2017 2:08:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tab_Empleados](
	[emp_Id] [int] IDENTITY(1,1) NOT NULL,
	[emp_Nombre] [nvarchar](100) NULL,
	[emp_Cargo] [nvarchar](50) NULL,
	[emp_Salario] [decimal](18, 2) NULL,
	[emp_SalarioHora] [decimal](18, 2) NULL,
	[emp_NodeEmp] [nvarchar](50) NULL,
	[emp_Direccion] [nvarchar](100) NULL,
	[emp_Celular] [nvarchar](50) NULL,
	[emp_Telefono] [nvarchar](50) NULL,
	[emp_Correo] [nvarchar](50) NULL,
	[emp_Departamento] [bigint] NULL,
 CONSTRAINT [PK_tab_Empleados] PRIMARY KEY CLUSTERED 
(
	[emp_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

