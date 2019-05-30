USE [taxare]
GO
/****** Object:  Table [dbo].[CambioAceite]    Script Date: 01/04/2019 17:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CambioAceite](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placa_taxi] [char](10) NOT NULL,
	[id_conductor] [bigint] NOT NULL,
	[id_kilometraje] [int] NOT NULL,
	[tipoAceite] [nchar](10) NOT NULL,
 CONSTRAINT [PK_CambioAceite_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conductor]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conductor](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [nchar](10) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Conductor_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConductoresXtaxis]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConductoresXtaxis](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[idConductor] [bigint] NOT NULL,
	[placaTaxi] [char](10) NOT NULL,
 CONSTRAINT [PK_Conductores_taxis] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idConductor] ASC,
	[placaTaxi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gasto_Inventario]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gasto_Inventario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_inventario] [int] NOT NULL,
	[placaTaxi] [char](10) NOT NULL,
	[cant_usada] [int] NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_Gasto_Inventario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GastosVariables]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GastosVariables](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placa] [char](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[fecha] [date] NOT NULL,
	[kilometraje] [float] NOT NULL,
	[valor] [float] NOT NULL,
 CONSTRAINT [PK_GastosVariables] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[item] [varchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[valorUnitario] [float] NOT NULL,
	[valorTotal] [float] NOT NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kilometrajes]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kilometrajes](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[placa] [char](10) NOT NULL,
	[kilometraje] [float] NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_Kilometrajes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Licencias]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Licencias](
	[Numero_pase] [bigint] NOT NULL,
	[id_conductor] [bigint] NOT NULL,
	[id_secretaria] [int] NOT NULL,
	[categoria] [char](5) NOT NULL,
	[expedicon] [date] NOT NULL,
	[vencimiento] [date] NOT NULL,
 CONSTRAINT [PK_Licencias] PRIMARY KEY CLUSTERED 
(
	[Numero_pase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produccion]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produccion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placa] [char](10) NOT NULL,
	[id_taxista] [int] NOT NULL,
	[inicio] [date] NOT NULL,
	[final] [date] NOT NULL,
	[valor] [float] NOT NULL,
 CONSTRAINT [PK_Produccion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Responsabilidades]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Responsabilidades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placa] [char](10) NULL,
	[poliza] [int] NOT NULL,
	[aseguradora] [varchar](30) NOT NULL,
	[vencimiento] [date] NOT NULL,
	[valor] [float] NOT NULL,
 CONSTRAINT [PK_Responsabilidades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Secretarias_transito]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Secretarias_transito](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[localidad] [nchar](10) NULL,
 CONSTRAINT [PK_Secretarias_transito] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SeguridadSocial]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeguridadSocial](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_conductor] [bigint] NOT NULL,
	[pago_anterior] [date] NOT NULL,
	[pago_siguiente] [date] NOT NULL,
	[valor] [float] NOT NULL,
 CONSTRAINT [PK_SeguridadSocial] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Soat]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Soat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [nchar](10) NOT NULL,
	[placa_taxi] [char](10) NOT NULL,
	[expedicion] [nchar](10) NOT NULL,
	[expiracion] [nchar](10) NOT NULL,
	[valor] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Soat] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taxis]    Script Date: 01/04/2019 17:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taxis](
	[placa] [char](10) NOT NULL,
	[id_matricula] [int] NOT NULL,
	[id_transito] [int] NOT NULL,
	[id_marca] [int] NOT NULL,
	[modelo] [int] NOT NULL,
	[cilindraje] [int] NOT NULL,
	[empresa_alfiliadora] [varchar](50) NOT NULL,
	[avaluo] [int] NOT NULL,
 CONSTRAINT [PK_Taxis] PRIMARY KEY CLUSTERED 
(
	[placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnomecanica]    Script Date: 01/04/2019 17:24:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnomecanica](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placa] [char](10) NOT NULL,
	[expedicion] [date] NOT NULL,
	[vencimiento] [date] NOT NULL,
	[valor] [float] NULL,
 CONSTRAINT [PK_Tecnomecanica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Toperacion]    Script Date: 01/04/2019 17:24:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Toperacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placa] [char](10) NOT NULL,
	[vencimiento] [date] NOT NULL,
	[valor] [float] NOT NULL,
 CONSTRAINT [PK_Toperacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 01/04/2019 17:24:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placaTaxi] [char](10) NULL,
	[idConductor] [bigint] NULL,
	[inicio] [date] NULL,
	[fin] [date] NULL,
	[monto] [float] NULL,
 CONSTRAINT [PK_Turnos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CambioAceite]  WITH CHECK ADD  CONSTRAINT [FK_CambioAceite_Conductor] FOREIGN KEY([id_conductor])
REFERENCES [dbo].[Conductor] ([id])
GO
ALTER TABLE [dbo].[CambioAceite] CHECK CONSTRAINT [FK_CambioAceite_Conductor]
GO
ALTER TABLE [dbo].[CambioAceite]  WITH CHECK ADD  CONSTRAINT [FK_CambioAceite_Taxis] FOREIGN KEY([placa_taxi])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[CambioAceite] CHECK CONSTRAINT [FK_CambioAceite_Taxis]
GO
ALTER TABLE [dbo].[ConductoresXtaxis]  WITH CHECK ADD  CONSTRAINT [FK_ConductoresXtaxis_Conductor] FOREIGN KEY([idConductor])
REFERENCES [dbo].[Conductor] ([id])
GO
ALTER TABLE [dbo].[ConductoresXtaxis] CHECK CONSTRAINT [FK_ConductoresXtaxis_Conductor]
GO
ALTER TABLE [dbo].[ConductoresXtaxis]  WITH CHECK ADD  CONSTRAINT [FK_ConductoresXtaxis_Taxis] FOREIGN KEY([placaTaxi])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[ConductoresXtaxis] CHECK CONSTRAINT [FK_ConductoresXtaxis_Taxis]
GO
ALTER TABLE [dbo].[Gasto_Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Inventario_Inventario] FOREIGN KEY([id_inventario])
REFERENCES [dbo].[Inventario] ([id])
GO
ALTER TABLE [dbo].[Gasto_Inventario] CHECK CONSTRAINT [FK_Gasto_Inventario_Inventario]
GO
ALTER TABLE [dbo].[Gasto_Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Inventario_Taxis] FOREIGN KEY([placaTaxi])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[Gasto_Inventario] CHECK CONSTRAINT [FK_Gasto_Inventario_Taxis]
GO
ALTER TABLE [dbo].[GastosVariables]  WITH CHECK ADD  CONSTRAINT [FK_GastosVariables_Taxis] FOREIGN KEY([placa])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[GastosVariables] CHECK CONSTRAINT [FK_GastosVariables_Taxis]
GO
ALTER TABLE [dbo].[Kilometrajes]  WITH CHECK ADD  CONSTRAINT [FK_Kilometrajes_Taxis] FOREIGN KEY([placa])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[Kilometrajes] CHECK CONSTRAINT [FK_Kilometrajes_Taxis]
GO
ALTER TABLE [dbo].[Licencias]  WITH CHECK ADD  CONSTRAINT [FK_Licencias_Conductor] FOREIGN KEY([id_conductor])
REFERENCES [dbo].[Conductor] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Licencias] CHECK CONSTRAINT [FK_Licencias_Conductor]
GO
ALTER TABLE [dbo].[Licencias]  WITH CHECK ADD  CONSTRAINT [FK_Licencias_Secretarias_transito] FOREIGN KEY([id_secretaria])
REFERENCES [dbo].[Secretarias_transito] ([id])
GO
ALTER TABLE [dbo].[Licencias] CHECK CONSTRAINT [FK_Licencias_Secretarias_transito]
GO
ALTER TABLE [dbo].[Produccion]  WITH CHECK ADD  CONSTRAINT [FK_Produccion_Taxis] FOREIGN KEY([placa])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[Produccion] CHECK CONSTRAINT [FK_Produccion_Taxis]
GO
ALTER TABLE [dbo].[Responsabilidades]  WITH CHECK ADD  CONSTRAINT [FK_Responsabilidades_Taxis] FOREIGN KEY([placa])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[Responsabilidades] CHECK CONSTRAINT [FK_Responsabilidades_Taxis]
GO
ALTER TABLE [dbo].[SeguridadSocial]  WITH CHECK ADD  CONSTRAINT [FK_SeguridadSocial_Conductor] FOREIGN KEY([id_conductor])
REFERENCES [dbo].[Conductor] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SeguridadSocial] CHECK CONSTRAINT [FK_SeguridadSocial_Conductor]
GO
ALTER TABLE [dbo].[Soat]  WITH CHECK ADD  CONSTRAINT [FK_Soat_Taxis] FOREIGN KEY([placa_taxi])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[Soat] CHECK CONSTRAINT [FK_Soat_Taxis]
GO
ALTER TABLE [dbo].[Taxis]  WITH CHECK ADD  CONSTRAINT [FK_Taxis_Marcas1] FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marcas] ([id])
GO
ALTER TABLE [dbo].[Taxis] CHECK CONSTRAINT [FK_Taxis_Marcas1]
GO
ALTER TABLE [dbo].[Taxis]  WITH CHECK ADD  CONSTRAINT [FK_Taxis_Secretarias_transito1] FOREIGN KEY([id_transito])
REFERENCES [dbo].[Secretarias_transito] ([id])
GO
ALTER TABLE [dbo].[Taxis] CHECK CONSTRAINT [FK_Taxis_Secretarias_transito1]
GO
ALTER TABLE [dbo].[Tecnomecanica]  WITH CHECK ADD  CONSTRAINT [FK_Tecnomecanica_Taxis] FOREIGN KEY([placa])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[Tecnomecanica] CHECK CONSTRAINT [FK_Tecnomecanica_Taxis]
GO
ALTER TABLE [dbo].[Toperacion]  WITH CHECK ADD  CONSTRAINT [FK_Toperacion_Taxis] FOREIGN KEY([placa])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[Toperacion] CHECK CONSTRAINT [FK_Toperacion_Taxis]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Conductor] FOREIGN KEY([idConductor])
REFERENCES [dbo].[Conductor] ([id])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Conductor]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Taxis] FOREIGN KEY([placaTaxi])
REFERENCES [dbo].[Taxis] ([placa])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Taxis]
GO
