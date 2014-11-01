 
/****** Object:  Table [dbo].[DeudasChocolate]    Script Date: 31/10/14 4:47:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeudasChocolate](
	[IdDeuda] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Vence] [datetime] NULL,
	[IdEstudiante] [int] NULL,
	[Cantidad] [int] NULL,
	[Balance] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDeuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 31/10/14 4:47:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[IdEstudiante] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Apellido] [varchar](30) NULL,
	[Matricula] [varchar](10) NULL,
	[Telefono] [varchar](13) NULL,
	[Cedula] [varchar](13) NULL,
	[Direccion] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[FechaNac] [date] NULL,
	[Genero] [int] NULL,
 CONSTRAINT [PK_Estudiantes] PRIMARY KEY CLUSTERED 
(
	[IdEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[PagosDeudas]    Script Date: 31/10/14 4:47:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagosDeudas](
	[IdPago] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[IdEstudiante] [int] NULL,
	[IdDeuda] [int] NULL,
	[CantidadPagada] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[DeudasEstudiantes]    Script Date: 31/10/14 4:47:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DeudasEstudiantes]
AS
SELECT        dbo.DeudasChocolate.IdDeuda, dbo.DeudasChocolate.Fecha, dbo.DeudasChocolate.IdEstudiante, dbo.DeudasChocolate.Cantidad, dbo.Estudiantes.Nombre, dbo.Estudiantes.Matricula
FROM            dbo.DeudasChocolate INNER JOIN
                         dbo.Estudiantes ON dbo.DeudasChocolate.IdEstudiante = dbo.Estudiantes.IdEstudiante

GO
/****** Object:  View [dbo].[EstudiantesPagosDeudas]    Script Date: 31/10/14 4:47:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[EstudiantesPagosDeudas]
AS
SELECT        dbo.Estudiantes.IdEstudiante, dbo.Estudiantes.Nombre, dbo.Estudiantes.Matricula, dbo.PagosDeudas.IdPago, dbo.PagosDeudas.Fecha, dbo.PagosDeudas.IdDeuda, dbo.PagosDeudas.CantidadPagada
FROM            dbo.Estudiantes INNER JOIN
                         dbo.PagosDeudas ON dbo.Estudiantes.IdEstudiante = dbo.PagosDeudas.IdEstudiante

GO
ALTER TABLE [dbo].[DeudasChocolate]  WITH CHECK ADD FOREIGN KEY([IdEstudiante])
REFERENCES [dbo].[Estudiantes] ([IdEstudiante])
GO
ALTER TABLE [dbo].[PagosDeudas]  WITH CHECK ADD FOREIGN KEY([IdDeuda])
REFERENCES [dbo].[DeudasChocolate] ([IdDeuda])
GO
ALTER TABLE [dbo].[PagosDeudas]  WITH CHECK ADD FOREIGN KEY([IdEstudiante])
REFERENCES [dbo].[Estudiantes] ([IdEstudiante])
GO 

 