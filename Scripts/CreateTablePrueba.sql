USE [Efecty]
GO

/****** Object:  Table [dbo].[prueba]    Script Date: 3/6/2025 12:26:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[prueba](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[tipo_documento] [nvarchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[valor_ganar] [numeric](18, 0) NULL,
	[estado_civil] [nvarchar](50) NULL,
 CONSTRAINT [PK_prueba] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


