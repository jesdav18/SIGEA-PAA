USE [master]
GO
CREATE DATABASE [SIGEA-PAA] ON  PRIMARY 
( NAME = N'SIGEA-PAA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.BART\MSSQL\DATA\SIGEA-PAA.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SIGEA-PAA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.BART\MSSQL\DATA\SIGEA-PAA_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SIGEA-PAA] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SIGEA-PAA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SIGEA-PAA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET ARITHABORT OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SIGEA-PAA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SIGEA-PAA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SIGEA-PAA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SIGEA-PAA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SIGEA-PAA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SIGEA-PAA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SIGEA-PAA] SET  MULTI_USER 
GO
ALTER DATABASE [SIGEA-PAA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SIGEA-PAA] SET DB_CHAINING OFF 
GO
USE [SIGEA-PAA]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carreras](
	[codigoCarrera] [int] IDENTITY(1,1) NOT NULL,
	[nombreCarrera] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigoCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[codigoEmpleado] [int] NOT NULL,
	[nombreEmpleado] [varchar](60) NULL,
	[identidadEmpleado] [varchar](16) NULL,
	[estadoEmpleado] [bit] NULL CONSTRAINT [DF_Empleados_estadoEmpleado]  DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[codigoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[numeroCuenta] [varchar](13) NOT NULL,
	[nombreEstudiante] [varchar](60) NULL,
	[identidadEstudiante] [varchar](16) NULL,
	[codigoCarrera] [int] NULL,
	[codigoTipoEstado] [tinyint] NULL,
	[codigoUsuario] [varchar](60) NULL,
	[fechaRegistro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[numeroCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inscripciones](
	[numeroCuenta] [varchar](13) NULL,
	[codigoPAA] [varchar](9) NULL,
	[fechaInscripcion] [date] NULL,
	[estadoInscripcion] [bit] NULL CONSTRAINT [DF_Inscripciones_estadoInscripcion]  DEFAULT ((1)),
	[estadoAprobacion] [int] NULL CONSTRAINT [DF_Inscripciones_estadoAprobacion]  DEFAULT ((0)),
	[codigoUsuario] [varchar](60) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PruebasDeAptitud](
	[codigoPAA] [varchar](9) NOT NULL,
	[fechaInicioPAA] [date] NULL,
	[fechaFinalPAA] [date] NOT NULL,
	[estadoPAA] [bit] NULL CONSTRAINT [DF_PruebasDeAptitud_estadoPAA]  DEFAULT ((1)),
	[fechaInicioInscripcionPAA] [date] NULL,
	[fechaFinalInscripcionPAA] [date] NULL,
	[cuposPAA] [int] NULL CONSTRAINT [DF_PruebasDeAptitud_cuposPAA]  DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[codigoPAA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoEstado](
	[codigoTipoEstado] [tinyint] NOT NULL,
	[descripcionTipoEstado] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigoTipoEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposAcceso](
	[codigoTipoAcceso] [tinyint] NOT NULL,
	[descripcionTipoAcceso] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigoTipoAcceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[codigoUsuario] [varchar](60) NOT NULL,
	[password] [varchar](60) NULL,
	[codigoEmpleado] [int] NULL,
	[codigoTipoAcceso] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Carreras] ON 

INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (1, N'MEDICINA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (2, N'ENFERMERIA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (3, N'ODONTOLOGIA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (4, N'INFORMATICA ADMINISTRATIVA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (5, N'INGENIERIA EN SISTEMAS')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (6, N'MATEMATICAS')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (7, N'LETRAS')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (8, N'CONTADURIA PUBLICA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (9, N'ADMINISTRACION DE EMPRESAS')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (10, N'ECONOMIA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (11, N'DERECHO')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (12, N'LENGUAS EXTRANJERAS')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (13, N'PSICOLOGIA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (14, N'QUIMICA Y FARMACIA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (15, N'INGENIERIA MECANICA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (16, N'INGENIERIA INDUSTRIAL')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (17, N'INGENIERIA ELECTRICA')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (18, N'INGENIERIA CIVIL')
INSERT [dbo].[Carreras] ([codigoCarrera], [nombreCarrera]) VALUES (19, N'PERIODISMO')
SET IDENTITY_INSERT [dbo].[Carreras] OFF
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado]) VALUES (18714, N'DIEGO ALONSO LOPEZ RAMIREZ', N'1612-1980-00132', 1)
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado]) VALUES (18715, N'EDGARD RENE ORELLANA JUAREZ', N'0501-1992-12132', 1)
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado]) VALUES (18716, N'CINTHYA YOLANI PINEDA SABILLON', N'0508-1994-00536', 1)
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado]) VALUES (18717, N'DAVID RICARDO LANDAVERDE LANDA', N'0501-1990-00234', 1)
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado]) VALUES (18718, N'JESUAR', N'0510-1992-13312', 1)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2003-2002-100', N'PABLO EMILIO ESCOBAR', N'0501-1980-00100', 8, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2003-2002-101', N'PEDRO PABLO LEON JARAMILLO', N'0501-1981-00101', 6, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2003-2002-102', N'ENRIQUE SEBASTIAN LOPEZ HERNANDEZ', N'0501-1981-00102', 2, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2004-2001-103', N'WILLIAM GERARDO DIAZ LOPEZ', N'1613-1986-00103', 10, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2004-2002-104', N'WILLIAM GERARDO DIAZ LOPEZ', N'1614-1986-00103', 12, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2005-2006-105', N'RITA FLOR ANGELY LOPEZ RAMIREZ', N'0421-1970-00104', 17, 2, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2006-3232-111', N'AXEL FRANCISCO ZAVALA VASQUEZ', N'1991-3232-12122', 8, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2007-3111-301', N'MELVIN ALBERTO VANEGAS GOMEZ', N'1985-2333-19212', 10, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2007-3233-323', N'ROBERTO ANTONIO MELGAR MELGAR', N'0501-1990-00102', 7, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2008-2003-999', N'JAIME ENRIQUE SUAZO VELASQUEZ', N'1993-2212-03033', 18, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2008-3232-332', N'CARLOS ALBERTO PAEZ RIBEIRO', N'0501-1992-00201', 4, 3, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2009-2001-106', N'KATIA VALESKA PINEDA SABILLON', N'0501-1994-00202', 15, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2009-2001-107', N'ADA LOURDES HERNANDEZ ARGUETA', N'1994-3232-32323', 13, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2009-2323-232', N'SINDY ELIETH PINEDA HERNANDEZ PINEDA', N'0501-1992-00344', 2, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2010-2004-196', N'GARY EDGARDO PALMA SANTOS', N'0508-1994-00526', 1, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2010-2233-197', N'CARLOS ALBERTO PAVON PLUMER', N'1212-1994-23232', 3, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2011-2000-177', N'JULIO CESAR HERNANDEZ SANTIAGO', N'1993-1989-22323', 6, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2011-2003-808', N'EDGARD RENÉ ORELLANA', N'0501-1992-12132', 4, 1, N'usuario1', CAST(N'2018-04-18' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2012-1993-212', N'ENZO GOMEZ', N'1614-1996-29392', 14, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2012-1993-233', N'MARTIN ENRIQUE GONZALES CHAVEZ', N'1997-3232-19399', 2, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2012-2000-176', N'BELKIS NOELIA PEÑA LOPEZ', N'1345-1994-43843', 8, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2012-2000-212', N'OSCAR RICARDO GUTIERREZ SALAZAR', N'2121-1994-12323', 9, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2013-1993-334', N'VANESSA JULIETTE DIAZ LOPEZ', N'1543-1990-43434', 10, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2013-1994-322', N'ERIC LEONEL ORTIZ VELASQUEZ', N'0421-1986-32323', 11, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2013-1995-345', N'AIDA ISABEL LANDAVERRY ', N'1343-1990-23242', 9, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2014-1992-323', N'CORY DANIELA PONCE PONCE', N'1413-1987-32323', 4, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2014-1994-223', N'TELMA JUDITH LOPEZ RAMIREZ', N'1993-1343-23232', 13, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2014-1994-323', N'MILISEN GERALDINA HERNANDEZ PINEDA', N'1993-1838-32322', 19, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2014-1998-384', N'KEVIN GUSTAVO CANACA JAAR', N'2122-1970-32323', 1, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2015-1993-323', N'MILISEN GERALDINA HERNANDEZ PINEDA', N'0501-1992-12132', 3, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2015-1996-212', N'MILISEN GERALDINA HERNANDEZ PINEDA', N'1234-1990-12111', 16, 1, NULL, NULL)
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [codigoUsuario], [fechaRegistro]) VALUES (N'2018-2000-178', N'ERNESTO GUEVARA', N'1212-1212-12123', 4, 1, N'usuario1', CAST(N'2018-04-18' AS Date))
INSERT [dbo].[Inscripciones] ([numeroCuenta], [codigoPAA], [fechaInscripcion], [estadoInscripcion], [estadoAprobacion], [codigoUsuario]) VALUES (N'2003-2002-100', N'I-2018', CAST(N'2018-04-15' AS Date), 1, 0, N'usuario1')
INSERT [dbo].[Inscripciones] ([numeroCuenta], [codigoPAA], [fechaInscripcion], [estadoInscripcion], [estadoAprobacion], [codigoUsuario]) VALUES (N'2007-3233-323', N'I-2018', CAST(N'2018-04-17' AS Date), 1, 1, N'usuario1')
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA]) VALUES (N'I-2016', CAST(N'2016-03-01' AS Date), CAST(N'2016-03-03' AS Date), 0, CAST(N'2016-02-25' AS Date), CAST(N'2016-02-28' AS Date), 150)
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA]) VALUES (N'I-2017', CAST(N'2017-03-17' AS Date), CAST(N'2017-03-19' AS Date), 0, CAST(N'2017-03-14' AS Date), CAST(N'2017-03-16' AS Date), 150)
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA]) VALUES (N'I-2018', CAST(N'2018-03-15' AS Date), CAST(N'2018-03-18' AS Date), 1, CAST(N'2018-03-01' AS Date), CAST(N'2018-03-14' AS Date), 105)
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA]) VALUES (N'II-2016', CAST(N'2016-06-18' AS Date), CAST(N'2016-06-21' AS Date), 0, CAST(N'2016-06-13' AS Date), CAST(N'2016-06-15' AS Date), 105)
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA]) VALUES (N'II-2017', CAST(N'2017-06-07' AS Date), CAST(N'2017-06-09' AS Date), 0, CAST(N'2017-05-31' AS Date), CAST(N'2017-06-02' AS Date), 110)
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA]) VALUES (N'III-2016', CAST(N'2016-10-21' AS Date), CAST(N'2016-10-23' AS Date), 0, CAST(N'2016-10-15' AS Date), CAST(N'2016-10-18' AS Date), 100)
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA]) VALUES (N'III-2017', CAST(N'2017-10-13' AS Date), CAST(N'2017-10-15' AS Date), 0, CAST(N'2017-10-08' AS Date), CAST(N'2017-10-11' AS Date), 150)
INSERT [dbo].[TipoEstado] ([codigoTipoEstado], [descripcionTipoEstado]) VALUES (1, N'ACTIVO')
INSERT [dbo].[TipoEstado] ([codigoTipoEstado], [descripcionTipoEstado]) VALUES (2, N'INACTIVO')
INSERT [dbo].[TipoEstado] ([codigoTipoEstado], [descripcionTipoEstado]) VALUES (3, N'SUSPENDIDO')
INSERT [dbo].[TipoEstado] ([codigoTipoEstado], [descripcionTipoEstado]) VALUES (4, N'CONDICIONADO')
INSERT [dbo].[TiposAcceso] ([codigoTipoAcceso], [descripcionTipoAcceso]) VALUES (1, N'ADMINISTRADOR')
INSERT [dbo].[TiposAcceso] ([codigoTipoAcceso], [descripcionTipoAcceso]) VALUES (2, N'SUPERVISOR')
INSERT [dbo].[TiposAcceso] ([codigoTipoAcceso], [descripcionTipoAcceso]) VALUES (3, N'NORMAL')
INSERT [dbo].[Usuarios] ([codigoUsuario], [password], [codigoEmpleado], [codigoTipoAcceso]) VALUES (N'admin', N'123456', 18716, 1)
INSERT [dbo].[Usuarios] ([codigoUsuario], [password], [codigoEmpleado], [codigoTipoAcceso]) VALUES (N'usuario1', N'123456', 18715, 2)
INSERT [dbo].[Usuarios] ([codigoUsuario], [password], [codigoEmpleado], [codigoTipoAcceso]) VALUES (N'usuario2', N'123456', 18718, 3)
ALTER TABLE [dbo].[Estudiantes]  WITH CHECK ADD  CONSTRAINT [FK_codigocarrera] FOREIGN KEY([codigoCarrera])
REFERENCES [dbo].[Carreras] ([codigoCarrera])
GO
ALTER TABLE [dbo].[Estudiantes] CHECK CONSTRAINT [FK_codigocarrera]
GO
ALTER TABLE [dbo].[Estudiantes]  WITH CHECK ADD  CONSTRAINT [FK_codigoTipoEstado] FOREIGN KEY([codigoTipoEstado])
REFERENCES [dbo].[TipoEstado] ([codigoTipoEstado])
GO
ALTER TABLE [dbo].[Estudiantes] CHECK CONSTRAINT [FK_codigoTipoEstado]
GO
ALTER TABLE [dbo].[Estudiantes]  WITH CHECK ADD  CONSTRAINT [FK_Estudiantes_Usuarios] FOREIGN KEY([codigoUsuario])
REFERENCES [dbo].[Usuarios] ([codigoUsuario])
GO
ALTER TABLE [dbo].[Estudiantes] CHECK CONSTRAINT [FK_Estudiantes_Usuarios]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_codigoPAA] FOREIGN KEY([codigoPAA])
REFERENCES [dbo].[PruebasDeAptitud] ([codigoPAA])
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_codigoPAA]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_codigoUsuario] FOREIGN KEY([codigoUsuario])
REFERENCES [dbo].[Usuarios] ([codigoUsuario])
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_codigoUsuario]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_numeroCuenta] FOREIGN KEY([numeroCuenta])
REFERENCES [dbo].[Estudiantes] ([numeroCuenta])
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_numeroCuenta]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_codigoEmpleado] FOREIGN KEY([codigoEmpleado])
REFERENCES [dbo].[Empleados] ([codigoEmpleado])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_codigoEmpleado]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_codigoTipoAcceso] FOREIGN KEY([codigoTipoAcceso])
REFERENCES [dbo].[TiposAcceso] ([codigoTipoAcceso])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_codigoTipoAcceso]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spB_ConsultaEstudiante] @Cuenta varchar(13)  
as
	If Exists (SELECT TOP 1 1 from Estudiantes where numeroCuenta=@Cuenta)
BEGIN
			SELECT 1 As Resultado, Estudiantes.nombreEstudiante,Estudiantes.numeroCuenta,Estudiantes.identidadEstudiante, Carreras.nombreCarrera, TipoEstado.descripcionTipoEstado,TipoEstado.codigoTipoEstado
			FROM Estudiantes
			INNER JOIN Carreras
			ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
			INNER JOIN TipoEstado
			ON TipoEstado.codigoTipoEstado = Estudiantes.codigoTipoEstado
			WHERE Estudiantes.numeroCuenta = @Cuenta



END
ELSE
BEGIN 
      SELECT 0 AS Resultado
END



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spB_SiEstudianteInscrito]
	--ESTE PROCEDIMIENTO SIRVE PARA SABER SI UN ESTUDIANTE YA ESTÁ INSCRITO.
	@Cuenta VARCHAR (13)
AS
	IF EXISTS(SELECT Inscripciones.numeroCuenta
			  FROM Inscripciones
			  INNER JOIN PruebasDeAptitud
			  ON PruebasDeAptitud.codigoPAA = Inscripciones.codigoPAA
			  WHERE Inscripciones.numeroCuenta = @Cuenta AND PruebasDeAptitud.estadoPAA = 1)
				
					SELECT 1 AS Resultado
	ELSE
					SELECT 0 AS Resultado
	

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spIns_Asistencia] @Cuenta varchar(13)
as
Begin
Update Inscripciones set
  estadoAprobacion+=1
  where numeroCuenta=@Cuenta AND codigoPAA in (Select codigoPAA from PruebasDeAptitud where estadoPAA=1)
End


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spIns_Estudiante] @Cuenta varchar (13), @Usuario varchar (60)
as
Declare @EstadoInscripcion bit
Declare @Total int 
Declare @CodigoPAA varchar (9)

 SET @Total = (SELECT cuposPAA from PruebasDeAptitud where estadoPAA=1) - (Select count (*) as Total from Inscripciones where codigoPAA in (Select codigoPAA from PruebasDeAptitud where estadoPAA=1) and estadoInscripcion=1 )
 set @CodigoPAA= (Select codigoPAA from PruebasDeAptitud where estadoPAA=1) 
If @Total>=1

   Set @EstadoInscripcion=1
  
ELSE

   Set @EstadoInscripcion=0


Insert Into Inscripciones
 (
    [numeroCuenta],
    [codigoPAA],
	[fechaInscripcion],
    [estadoInscripcion],
    [estadoAprobacion],
    [codigoUsuario]
	
 ) 
Values
 (
	@Cuenta,
	@codigoPaa,
    CONVERT(date, getdate()),
    @EstadoInscripcion,
    0,
    @Usuario
	
 )
select * from Inscripciones
select @EstadoInscripcion




GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLogin] @usuario VARCHAR(60), @contrasenia  VARCHAR(60)
AS
If Exists (SELECT TOP 1 1 FROM Usuarios WHERE codigoUsuario= @usuario AND password=@contrasenia)
	BEGIN
        	SELECT 1 AS Resultado, Empleados.nombreEmpleado,TiposAcceso.codigoTipoAcceso, Usuarios.codigoUsuario
		FROM Usuarios
		INNER JOIN TiposAcceso
		ON TiposAcceso.codigoTipoAcceso = Usuarios.codigoTipoAcceso
		INNER JOIN Empleados 
		ON Empleados.codigoEmpleado=Usuarios.codigoEmpleado
		WHERE Empleados.estadoEmpleado  = 1 AND Usuarios.codigoUsuario = @usuario AND Usuarios.password = @contrasenia

   	END
ELSE
       BEGIN
        SELECT 0 AS Resultado

       END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spR_Estudiante] @Cuenta varchar (13),@Estudiante varchar(60), @Identidad varchar(16),@Carrera int,@Usuario varchar(60)
as
Begin
insert into Estudiantes
 (
 [numeroCuenta],
 [nombreEstudiante],
 [identidadEstudiante],
 [codigoCarrera],
 [codigoTipoEstado],
 [codigoUsuario],
 [fechaRegistro]
 )
 values
 (
  @Cuenta,
  @Estudiante,
  @Identidad,
  @Carrera,
  1,
  @Usuario,
  CONVERT(date, getdate())
 )
End
   




GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spU_Estudiante]  @Cuenta varchar (13),@Estudiante varchar(60), @Identidad varchar(16),@Carrera int,@Usuario varchar(60)
as
Begin
Update Estudiantes set
 
 numeroCuenta=@Cuenta,
 nombreEstudiante=@Estudiante,
 identidadEstudiante=@Identidad,
 codigoCarrera=@Carrera,
 codigoUsuario=@Usuario,
 fechaRegistro=CONVERT(date, getdate())
  where numeroCuenta=@Cuenta
End
 


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spV_MostrarCarrera]
AS
	SELECT * FROM Carreras
	
GO
USE [master]
GO
ALTER DATABASE [SIGEA-PAA] SET  READ_WRITE 
GO
