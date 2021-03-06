USE [master]
GO
/****** Object:  Database [SIGEA-PAA]    Script Date: 28/04/2018 15:11:30 ******/
CREATE DATABASE [SIGEA-PAA] 
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
/****** Object:  Table [dbo].[Carreras]    Script Date: 28/04/2018 15:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carreras](
	[codigoCarrera] [int] IDENTITY(1,1) NOT NULL,
	[nombreCarrera] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigoCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[codigoEmpleado] [int] NOT NULL,
	[nombreEmpleado] [nvarchar](60) NOT NULL,
	[identidadEmpleado] [nvarchar](16) NOT NULL,
	[estadoEmpleado] [bit] NOT NULL CONSTRAINT [DF_Empleados_estadoEmpleado]  DEFAULT ((1)),
	[codigoUsuario] [nvarchar](60) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[numeroCuenta] [nvarchar](13) NOT NULL,
	[nombreEstudiante] [nvarchar](60) NOT NULL,
	[identidadEstudiante] [nvarchar](16) NOT NULL,
	[codigoCarrera] [int] NOT NULL,
	[codigoTipoEstado] [tinyint] NOT NULL,
	[telefono] [nvarchar](60) NOT NULL,
	[correo] [nvarchar](60) NOT NULL,
	[codigoUsuario] [nvarchar](60) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
 CONSTRAINT [PK__Estudian__90BFFF6507F6335A] PRIMARY KEY CLUSTERED 
(
	[numeroCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inscripciones]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inscripciones](
	[numeroCuenta] [nvarchar](13) NOT NULL,
	[codigoPAA] [nvarchar](9) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
	[estadoAprobacion] [int] NOT NULL CONSTRAINT [DF_Inscripciones_estadoAprobacion]  DEFAULT ((0)),
	[codigoUsuario] [nvarchar](60) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PruebasDeAptitud]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PruebasDeAptitud](
	[codigoPAA] [nvarchar](9) NOT NULL,
	[fechaInicioPAA] [date] NOT NULL,
	[fechaFinalPAA] [date] NOT NULL,
	[estadoPAA] [bit] NOT NULL CONSTRAINT [DF_PruebasDeAptitud_estadoPAA]  DEFAULT ((1)),
	[fechaInicioInscripcionPAA] [date] NOT NULL,
	[fechaFinalInscripcionPAA] [date] NOT NULL,
	[cuposPAA] [int] NOT NULL CONSTRAINT [DF_PruebasDeAptitud_cuposPAA]  DEFAULT ((0)),
	[codigoUsuario] [nvarchar](60) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
 CONSTRAINT [PK__PruebasD__690EA7550CBAE877] PRIMARY KEY CLUSTERED 
(
	[codigoPAA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoEstado]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoEstado](
	[codigoTipoEstado] [tinyint] NOT NULL,
	[descripcionTipoEstado] [nvarchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigoTipoEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposAcceso]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposAcceso](
	[codigoTipoAcceso] [tinyint] NOT NULL,
	[descripcionTipoAcceso] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigoTipoAcceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[codigoUsuario] [nvarchar](60) NOT NULL,
	[password] [nvarchar](60) NOT NULL,
	[codigoEmpleado] [int] NOT NULL,
	[codigoTipoAcceso] [tinyint] NOT NULL,
	[usuarioRegistro] [nvarchar](60) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
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
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado], [codigoUsuario], [fechaRegistro]) VALUES (18714, N'DIEGO ALONSO LOPEZ RAMIREZ', N'1612-1980-00132', 1, N'admin1',  CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado], [codigoUsuario], [fechaRegistro]) VALUES (18715, N'EDGARD RENE ORELLANA JUAREZ', N'0501-1992-12132', 1, N'admin1',  CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado], [codigoUsuario], [fechaRegistro]) VALUES (18716, N'CINTHYA YOLANI PINEDA SABILLON', N'0508-1994-00536', 1,  N'admin1',  CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado], [codigoUsuario], [fechaRegistro]) VALUES (18717, N'DAVID RICARDO LANDAVERDE LANDA', N'0501-1990-00234', 0, N'admin1', CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Empleados] ([codigoEmpleado], [nombreEmpleado], [identidadEmpleado], [estadoEmpleado], [codigoUsuario], [fechaRegistro]) VALUES (18718, N'JESUAR DAVID LÓPEZ RAMIREZ', N'', 1, N'admin1', CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2003-2002-100', N'PABLO EMILIO ESCOBAR', N'0501-1980-00100', 8, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2003-2002-101', N'PEDRO PABLO LEON JARAMILLO', N'0501-1981-00101', 6, 1,N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2003-2002-102', N'ENRIQUE SEBASTIAN LOPEZ HERNANDEZ', N'0501-1981-00102', 2, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2004-2001-103', N'WILLIAM GERARDO DIAZ LOPEZ', N'1613-1986-00103', 10, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2004-2002-104', N'WILLIAM GERARDO DIAZ LOPEZ', N'1614-1986-00103', 12, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2005-2006-105', N'RITA FLOR ANGELY LOPEZ RAMIREZ', N'0421-1970-00104', 17, 2, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2006-3232-111', N'AXEL FRANCISCO ZAVALA VASQUEZ', N'1991-3232-12122', 8, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2007-3111-301', N'MELVIN ALBERTO VANEGAS GOMEZ', N'1985-2333-19212', 10, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2007-3233-323', N'ROBERTO ANTONIO MELGAR MELGAR', N'0501-1990-00102', 7, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2008-2003-999', N'JAIME ENRIQUE SUAZO VELASQUEZ', N'1993-2212-03033', 18, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2008-3232-332', N'CARLOS ALBERTO PAEZ RIBEIRO', N'0501-1992-00201', 4, 3, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2009-2001-106', N'KATIA VALESKA PINEDA SABILLON', N'0501-1994-00202', 15, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2009-2001-107', N'ADA LOURDES HERNANDEZ ARGUETA', N'1994-3232-32323', 13, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2009-2323-232', N'SINDY ELIETH PINEDA HERNANDEZ PINEDA', N'0501-1992-00344', 2, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2010-2004-196', N'GARY EDGARDO PALMA SANTOS', N'0508-1994-00526', 1, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2010-2233-197', N'CARLOS ALBERTO PAVON PLUMER', N'1212-1994-23232', 3, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2011-2000-177', N'JULIO CESAR HERNANDEZ SANTIAGO', N'1993-1989-22323', 6, 1,N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2011-2003-808', N'EDGARD RENÉ ORELLANA', N'0501-1992-12132', 4, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2012-1993-212', N'ENZO GOMEZ', N'1614-1996-29392', 14, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2012-1993-233', N'MARTIN ENRIQUE GONZALES CHAVEZ', N'1997-3232-19399', 2, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2012-2000-176', N'BELKIS NOELIA PEÑA LOPEZ', N'1345-1994-43843', 8, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2012-2000-212', N'OSCAR RICARDO GUTIERREZ SALAZAR', N'2121-1994-12323', 9, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2013-1993-334', N'VANESSA JULIETTE DIAZ LOPEZ', N'1543-1990-43434', 10, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2013-1994-322', N'ERIC LEONEL ORTIZ VELASQUEZ', N'0421-1986-32323', 11, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2013-1995-345', N'AIDA ISABEL LANDAVERRY ', N'1343-1990-23242', 9, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2014-1992-323', N'CORY DANIELA PONCE PONCE', N'1413-1987-32323', 4, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2014-1994-223', N'TELMA JUDITH LOPEZ RAMIREZ', N'1993-1343-23232', 13, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2014-1994-323', N'MILISEN GERALDINA HERNANDEZ PINEDA', N'1993-1838-32322', 19, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2014-1998-384', N'KEVIN GUSTAVO CANACA JAAR', N'2122-1970-32323', 1, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2015-1993-323', N'MILISEN GERALDINA HERNANDEZ PINEDA', N'0501-1992-12132', 3, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))
INSERT [dbo].[Estudiantes] ([numeroCuenta], [nombreEstudiante], [identidadEstudiante], [codigoCarrera], [codigoTipoEstado], [telefono], [correo], [codigoUsuario], [fechaRegistro]) VALUES (N'2015-1996-212', N'MILISEN GERALDINA HERNANDEZ PINEDA', N'1234-1990-12111', 16, 1, N'3223-2333' ,N're@hotmail.com', N'usuario2',CAST(N'2018-04-19' AS Date))

INSERT [dbo].[Inscripciones] ([numeroCuenta], [codigoPAA], [fechaRegistro], [estadoAprobacion], [codigoUsuario]) VALUES (N'2003-2002-100', N'II-2018', CAST(N'2018-04-19' AS Date), 1, N'usuario1')
INSERT [dbo].[Inscripciones] ([numeroCuenta], [codigoPAA], [fechaRegistro], [estadoAprobacion], [codigoUsuario]) VALUES (N'2007-3233-323', N'II-2018', CAST(N'2018-04-17' AS Date), 0, N'usuario1')
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA], [codigoUsuario], [fechaRegistro]) VALUES (N'I-2016', CAST(N'2016-03-01' AS Date), CAST(N'2016-03-03' AS Date), 0, CAST(N'2016-02-25' AS Date), CAST(N'2016-02-28' AS Date), 150, N'usuario2', CAST(N'2018-04-26' AS Date))
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA], [codigoUsuario], [fechaRegistro]) VALUES (N'I-2017', CAST(N'2017-03-17' AS Date), CAST(N'2017-03-19' AS Date), 0, CAST(N'2017-03-14' AS Date), CAST(N'2017-03-16' AS Date), 150, N'usuario2', CAST(N'2018-04-26' AS Date))
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA], [codigoUsuario], [fechaRegistro]) VALUES (N'I-2018', CAST(N'2018-03-15' AS Date), CAST(N'2018-03-18' AS Date), 0, CAST(N'2018-03-01' AS Date), CAST(N'2018-03-14' AS Date), 105, N'usuario2', CAST(N'2018-04-26' AS Date))
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA], [codigoUsuario], [fechaRegistro]) VALUES (N'II-2016', CAST(N'2016-06-18' AS Date), CAST(N'2016-06-21' AS Date), 0, CAST(N'2016-06-13' AS Date), CAST(N'2016-06-15' AS Date), 105, N'usuario2', CAST(N'2018-04-26' AS Date))
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA], [codigoUsuario], [fechaRegistro]) VALUES (N'II-2017', CAST(N'2017-06-07' AS Date), CAST(N'2017-06-09' AS Date), 0, CAST(N'2017-05-31' AS Date), CAST(N'2017-06-02' AS Date), 110, N'usuario2', CAST(N'2018-04-26' AS Date))
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA], [codigoUsuario], [fechaRegistro]) VALUES (N'II-2018', CAST(N'2018-04-27' AS Date), CAST(N'2018-04-29' AS Date), 1, CAST(N'2018-04-05' AS Date), CAST(N'2018-04-26' AS Date), 100, N'usuario2', CAST(N'2018-04-26' AS Date))
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA], [codigoUsuario], [fechaRegistro]) VALUES (N'III-2016', CAST(N'2016-10-21' AS Date), CAST(N'2016-10-23' AS Date), 0, CAST(N'2016-10-15' AS Date), CAST(N'2016-10-18' AS Date), 100, N'usuario2', CAST(N'2018-04-26' AS Date))
INSERT [dbo].[PruebasDeAptitud] ([codigoPAA], [fechaInicioPAA], [fechaFinalPAA], [estadoPAA], [fechaInicioInscripcionPAA], [fechaFinalInscripcionPAA], [cuposPAA], [codigoUsuario], [fechaRegistro]) VALUES (N'III-2017', CAST(N'2017-10-13' AS Date), CAST(N'2017-10-15' AS Date), 0, CAST(N'2017-10-08' AS Date), CAST(N'2017-10-11' AS Date), 150,N'usuario2', CAST(N'2018-04-26' AS Date))
INSERT [dbo].[TipoEstado] ([codigoTipoEstado], [descripcionTipoEstado]) VALUES (1, N'ACTIVO')
INSERT [dbo].[TipoEstado] ([codigoTipoEstado], [descripcionTipoEstado]) VALUES (2, N'INACTIVO')
INSERT [dbo].[TipoEstado] ([codigoTipoEstado], [descripcionTipoEstado]) VALUES (3, N'SUSPENDIDO')
INSERT [dbo].[TipoEstado] ([codigoTipoEstado], [descripcionTipoEstado]) VALUES (4, N'CONDICIONADO')
INSERT [dbo].[TiposAcceso] ([codigoTipoAcceso], [descripcionTipoAcceso]) VALUES (1, N'ADMINISTRADOR')
INSERT [dbo].[TiposAcceso] ([codigoTipoAcceso], [descripcionTipoAcceso]) VALUES (2, N'SUPERVISOR')
INSERT [dbo].[TiposAcceso] ([codigoTipoAcceso], [descripcionTipoAcceso]) VALUES (3, N'NORMAL')
INSERT [dbo].[Usuarios] ([codigoUsuario], [password], [codigoEmpleado], [codigoTipoAcceso], [usuarioRegistro], [fechaRegistro]) VALUES (N'admin1', N'123456', 18716, 1, N'admin1', CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Usuarios] ([codigoUsuario], [password], [codigoEmpleado], [codigoTipoAcceso], [usuarioRegistro], [fechaRegistro]) VALUES (N'admin2', N'123456', 18717, 1, N'admin1', CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Usuarios] ([codigoUsuario], [password], [codigoEmpleado], [codigoTipoAcceso], [usuarioRegistro], [fechaRegistro]) VALUES (N'usuario1', N'123456', 18715, 3, N'admin1', CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Usuarios] ([codigoUsuario], [password], [codigoEmpleado], [codigoTipoAcceso], [usuarioRegistro], [fechaRegistro]) VALUES (N'usuario2', N'123456', 18718, 2, N'admin1', CAST(N'2018-04-27' AS Date))
INSERT [dbo].[Usuarios] ([codigoUsuario], [password], [codigoEmpleado], [codigoTipoAcceso], [usuarioRegistro], [fechaRegistro]) VALUES (N'usuario3', N'123456', 18717, 3, N'usuario2', CAST(N'2018-04-26' AS Date))
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Usuarios] FOREIGN KEY([codigoUsuario])
REFERENCES [dbo].[Usuarios] ([codigoUsuario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Usuarios]
GO
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
ALTER TABLE [dbo].[PruebasDeAptitud]  WITH CHECK ADD  CONSTRAINT [FK_PruebasDeAptitud_Usuarios] FOREIGN KEY([codigoUsuario])
REFERENCES [dbo].[Usuarios] ([codigoUsuario])
GO
ALTER TABLE [dbo].[PruebasDeAptitud] CHECK CONSTRAINT [FK_PruebasDeAptitud_Usuarios]
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
/****** Object:  StoredProcedure [dbo].[spB_ConsultaEstudiante]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spB_ConsultaEstudiante] @Cuenta nvarchar(13)  
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
/****** Object:  StoredProcedure [dbo].[spB_Empleado]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spB_Empleado]
	@codigo INT
AS
	SELECT Empleados.codigoEmpleado, Empleados.nombreEmpleado, Empleados.identidadEmpleado, Empleados.estadoEmpleado
	FROM Empleados
	WHERE Empleados.codigoEmpleado = @codigo
GO
/****** Object:  StoredProcedure [dbo].[spB_PAA]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spB_PAA] @PAA nvarchar(9)  
as
	If Exists (SELECT TOP 1 1 from PruebasDeAptitud where codigoPAA=@PAA and estadoPAA=1)
BEGIN
			SELECT 1 As Resultado,codigoPAA,fechaInicioPAA,fechaFinalPAA,fechaInicioInscripcionPAA,fechaFinalInscripcionPAA,cuposPAA FROM PruebasDeAptitud
			where codigoPAA=@PAA



END
ELSE
BEGIN 
      SELECT 0 AS Resultado
END

GO
/****** Object:  StoredProcedure [dbo].[spB_SiEstudianteInscrito]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spB_SiEstudianteInscrito]
	--ESTE PROCEDIMIENTO SIRVE PARA SABER SI UN ESTUDIANTE YA ESTÁ INSCRITO.
	@Cuenta nvarchar (13)
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
/****** Object:  StoredProcedure [dbo].[spB_Usuario]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spB_Usuario] @codigoUsuario nvarchar(60)  
as
	If Exists (SELECT TOP 1 1 as Resultado from Usuarios where codigoUsuario=@codigoUsuario)
BEGIN
Select 1 as Resultado,Usuarios.codigoUsuario,Usuarios.password,Empleados.nombreEmpleado,TiposAcceso.descripcionTipoAcceso From Usuarios
Inner Join Empleados
On Empleados.codigoEmpleado=Usuarios.codigoEmpleado
Inner Join TiposAcceso
On TiposAcceso.codigoTipoAcceso=Usuarios.codigoTipoAcceso
where Usuarios.codigoUsuario=@codigoUsuario

END
ELSE
BEGIN 
      SELECT 0 AS Resultado
END


GO
/****** Object:  StoredProcedure [dbo].[spIns_Asistencia]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spIns_Asistencia] @Cuenta nvarchar(13),@CodigoUsuario nvarchar(60)
as

	declare @fecha date
	set @fecha=CONVERT(date, getdate())
	
	if (select DATEDIFF (DAY,Inscripciones.fechaRegistro,@fecha) from Inscripciones where numeroCuenta=@Cuenta)=1
BEGIN
	if (Select estadoAprobacion from Inscripciones where  numeroCuenta=@Cuenta  )<3
	Begin
		update inscripciones
		set estadoaprobacion+=1, fechaRegistro=@fecha, codigoUsuario=@CodigoUsuario where numerocuenta=@cuenta and codigopaa in (select codigopaa from pruebasdeaptitud where estadopaa=1)
		Select 1 as Resultado
	End
		else
		select 0 as Resultado
END
ELSE
BEGIN
	select 2 as Resultado
	
END

GO
/****** Object:  StoredProcedure [dbo].[spIns_Estudiante]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spIns_Estudiante] @Cuenta nvarchar (13), @Usuario nvarchar (60)
as
Declare @Cupos int 
Declare @CodigoPAA nvarchar (9)
Declare @Total int
SET @Cupos = (SELECT cuposPAA from PruebasDeAptitud where estadoPAA=1) 

Begin
Insert Into Inscripciones
 (
    [numeroCuenta],
    [codigoPAA],
	[fechaRegistro],
    
    [estadoAprobacion],
    [codigoUsuario]
	
 ) 
Values
 (
	@Cuenta,
	@codigoPaa,
    CONVERT(date, getdate()),
    
    0,
    @Usuario

 )
 
 End
 Set @Total=(Select count (*) as Total from Inscripciones where codigoPAA in (Select codigoPAA from PruebasDeAptitud where estadoPAA=1))
SET @CodigoPAA= (Select codigoPAA from PruebasDeAptitud where estadoPAA=1) 

if (@Total>@Cupos*0.80)
Begin
select 1 as Resultado,@Total ---Las Inscripcione alcanzaron el 80%
End

If (@Total=@Cupos)
Begin
select 2 as Resultado,@Total ----Las Inscripciones alcanzaron el 100%
End




GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spLogin] @usuario nvarchar(60), @contrasenia  nvarchar(60)
as
If Exists (Select TOP 1 1 from Usuarios where codigoUsuario= @usuario and password=@contrasenia)
   BEGIN
   
		   IF Not Exists (Select Usuarios.codigoUsuario,Empleados.codigoEmpleado from Usuarios 
		   inner join Empleados
		   On Empleados.codigoEmpleado=Usuarios.codigoEmpleado
		   where Empleados.estadoEmpleado=1 and Usuarios.codigoUsuario=@usuario)
		   
		   Select 2 as Resultado
		   
		   else
		   
		   SELECT 1 AS Resultado, Empleados.nombreEmpleado, TiposAcceso.codigoTipoAcceso,Usuarios.codigoUsuario
		FROM Usuarios
		INNER JOIN TiposAcceso
		ON TiposAcceso.codigoTipoAcceso = Usuarios.codigoTipoAcceso
		INNER JOIN Empleados 
		ON Empleados.codigoEmpleado=Usuarios.codigoEmpleado
		WHERE Usuarios.codigoUsuario = @usuario AND Usuarios.password = @contrasenia
END
ELSE
BEGIN
select 0 as Resultado
END
   

GO
/****** Object:  StoredProcedure [dbo].[spR_CrearPAA]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spR_CrearPAA] @CodigoPAA nvarchar (8),@fechaInicio date,@fechaFinal date,@fechaInicioInscripcionPAA date,@fechaFinalInscripcionPAA date,@Cupos int, @codigoUsuario nvarchar(60)
		as
			If NOT Exists (SELECT TOP 1 1 AS Resultado from PruebasDeAptitud where codigoPAA=@CodigoPAA)
		BEGIN
		update PruebasDeAptitud 
		set estadoPAA=0
		Insert Into PruebasDeAptitud
 (
		[codigoPAA],
		[fechaInicioPAA],
		[fechaFinalPAA],
		[estadoPAA],
		[fechaInicioInscripcionPAA],
		[fechaFinalInscripcionPAA],
		[cuposPAA],
		[codigoUsuario],
		[fechaRegistro]

 ) 
Values
 (
		 @CodigoPAA,
		 @fechaInicio,
		 @fechaFinal,
		 1,
		 @fechaInicioInscripcionPAA,
		 @fechaFinalInscripcionPAA,
		 @Cupos,
		 @codigoUsuario,
		 CONVERT(date, getdate())
 )
 
 Select 1 as Resultado
		END
	  ELSE
		BEGIN 
    
			  SELECT 0 AS Resultado
	
		END



GO
/****** Object:  StoredProcedure [dbo].[spR_Empleado]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spR_Empleado]  @CodigoEmpleado int,@Nombre nvarchar(60),@Identidad nvarchar(16),@CodigoUsuario nvarchar(60)
as
If Not Exists (SELECT TOP 1 1 as Resultado from Empleados where codigoEmpleado=@CodigoEmpleado)
		BEGIN
		Insert into Empleados
		(
		codigoEmpleado,
		nombreEmpleado,
		identidadEmpleado,
		estadoEmpleado,
		codigoUsuario,
		fechaRegistro
		)
		Values
		(
		@CodigoEmpleado,
		@Nombre,
		@Identidad,
		1,
		@CodigoEmpleado,
		CONVERT(date, getdate())
		)
		select 1 as Resultado
		END
		Else
		
		select 0 as Resultado
		



GO
/****** Object:  StoredProcedure [dbo].[spR_Estudiante]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spR_Estudiante] @Cuenta nvarchar (13),@Estudiante nvarchar(60), @Identidad nvarchar(16),@Carrera int,@Telefono nvarchar(60),@Correo nvarchar(60),@Usuario nvarchar(60)
as

If Not Exists(Select TOP 1 1 as Resultado From Estudiantes where numeroCuenta=@Estudiante)
Begin
insert into Estudiantes
 (
 [numeroCuenta],
 [nombreEstudiante],
 [identidadEstudiante],
 [codigoCarrera],
 [codigoTipoEstado],
 [telefono],
 [correo],
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
  @Telefono,
  @Correo,
  @Usuario,
  CONVERT(date, getdate())
 )
 Select 1 as Resultado
 End
 ELSE
 Begin
 Select 0 as Resultado  
 END


GO
/****** Object:  StoredProcedure [dbo].[spR_EstudianteInscrito]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spR_EstudianteInscrito]
as
SELECT Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante,Carreras.nombreCarrera,PruebasDeAptitud.codigoPAA,PruebasDeAptitud.fechaInicioPAA, PruebasDeAptitud.fechaFinalPAA
FROM Estudiantes
INNER JOIN Carreras
ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
INNER JOIN Inscripciones
ON Inscripciones.numeroCuenta = Estudiantes.numeroCuenta
INNER JOIN PruebasDeAptitud
ON PruebasDeAptitud.codigoPAA = Inscripciones.codigoPAA
WHERE PruebasDeAptitud.estadoPAA=1
GROUP BY Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera,PruebasDeAptitud.codigoPAA,PruebasDeAptitud.fechaInicioPAA, PruebasDeAptitud.fechaFinalPAA



GO
/****** Object:  StoredProcedure [dbo].[spR_Usuario]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spR_Usuario] @CodigoUsuario2 nvarchar(60), @Password nvarchar(60),@CodigoEmpleado int,@TipoAcceso tinyint,@codigoUsuario nvarchar(60)
as
	If Not Exists (SELECT TOP 1 1 as Resultado from Usuarios where codigoUsuario=@Codigousuario2)
		BEGIN
		Insert into Usuarios
		(
		codigoUsuario,
		password,
		codigoEmpleado,
		codigoTipoAcceso,
		usuarioRegistro,
		fechaRegistro
		)
		Values
		(
		@CodigoUsuario2,
		@Password,
		@CodigoEmpleado,
		@TipoAcceso,
		@codigoUsuario,
		CONVERT(date, getdate())
		)
		select 1 as Resultado
		END
		Else
		
		select 0 as Resultado
		



GO
/****** Object:  StoredProcedure [dbo].[spU_Empleado]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spU_Empleado]
	 @codigo INT,
	 @nombre nvarchar(60),
	 @identidad nvarchar(16),
	 @usuario nvarchar(60),
	 @fecha DATE,
	 @estado BIT
AS 
	UPDATE Empleados
	SET codigoEmpleado = @codigo,
		nombreEmpleado = @nombre,
		identidadEmpleado = @identidad, 
		codigoUsuario = @usuario, 
		fechaRegistro =  @fecha,
		estadoEmpleado = @estado
	WHERE Empleados.codigoEmpleado = @codigo
GO
/****** Object:  StoredProcedure [dbo].[spU_Estudiante]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spU_Estudiante]  @Cuenta nvarchar (13),@Estudiante nvarchar(60), @Identidad nvarchar(16),@Carrera int,@Telefono nvarchar(60),@Correo nvarchar(60),@Usuario nvarchar(60)
as
Begin

Update Estudiantes set
 
 numeroCuenta=@Cuenta,
 nombreEstudiante=@Estudiante,
 identidadEstudiante=@Identidad,
 codigoCarrera=@Carrera,
telefono=@Telefono,
correo=@Correo,
 codigoUsuario=@Usuario,
 fechaRegistro=CONVERT(date, getdate())
  where numeroCuenta=@Cuenta
End
 select 1 as Resultado


GO
/****** Object:  StoredProcedure [dbo].[spU_PAA]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spU_PAA] @CodigoPAA nvarchar (9),@PAAInicio date,@PAAFinal date,@InscripcionInicio date,@InscripcionFinal date,@Cupos int, @codigoUsuario nvarchar(60)
		as
		BEGIN
Update PruebasDeAptitud
 set
		fechaInicioPAA=@PAAInicio,
		fechaFinalPAA= @PAAFinal,
		estadoPAA=1,
		fechaInicioInscripcionPAA= @InscripcionInicio,
		fechaFinalInscripcionPAA=@InscripcionFinal,
		cuposPAA=@Cupos,
		codigoUsuario=@codigoUsuario,
		fechaRegistro=CONVERT(date, getdate())
		where codigoPAA=@CodigoPAA

 Select 1 as Resultado
		END

GO
/****** Object:  StoredProcedure [dbo].[spU_Usuario]    Script Date: 28/04/2018 15:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[spU_Usuario]  @CodigoUsuario2 nvarchar(60),@Password nvarchar(60), @TipoAcceso tinyInt,@CodigoUsuario nvarchar(60),@CodigoUsuario3 nvarchar(60)
as
Update Usuarios 
set
		codigoUsuario=@CodigoUsuario2,
		password=@Password,
		
		codigotipoacceso=@TipoAcceso,
		usuarioregistro=@codigoUsuario,
		fecharegistro=CONVERT(date, getdate())
where codigoUsuario=@CodigoUsuario3
		

GO
/****** Object:  StoredProcedure [dbo].[spV_MostrarCarrera]    Script Date: 28/04/2018 15:11:31 ******/
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
