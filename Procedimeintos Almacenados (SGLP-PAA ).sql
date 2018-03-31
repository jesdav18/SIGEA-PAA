USE [SGL-PAA]
GO
/****** Object:  StoredProcedure [dbo].[spAgregarEstudiante]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAgregarEstudiante] @numeroCuenta varchar (13),@nombreEstudiante varchar(60), @identidadEstudiante varchar(16),@codigoCarrea int
as
Begin
insert into Estudiantes
 (
 [numeroCuenta],
 [nombreEstudiante],
 [identidadEstudiante],
 [codigoCarrera],
 [codigoTipoEstado]
 )
 values
 (
  @numeroCuenta,
  @nombreEstudiante,
  @identidadEstudiante,
  @codigoCarrea,
  1

 )
End
   select * from Estudiantes


GO
/****** Object:  StoredProcedure [dbo].[spBuscarVerificarInsertarPAA]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spBuscarVerificarInsertarPAA] @CodigoPAA varchar (8),@fechaInicio date,@fechaFinal date,@fechaInicioInscripcionPAA date,@fechaFinalInscripcionPAA date,@cupos int
		as
			If NOT Exists (SELECT TOP 1 1 AS Resultado from PruebasDeAptitud where codigoPAA=@CodigoPAA)
		BEGIN
		Insert Into PruebasDeAptitud
 (
		[codigoPAA],
		[fechaInicioPAA],
		[fechaFinalPAA],
		[estadoPAA],
		[fechaInicioInscripcionPAA],
		[fechaFinalInscripcionPAA],
		[cuposPAA]

 ) 
Values
 (
		 @CodigoPAA,
		 @fechaInicio,
		 @fechaFinal,
		 1,
		 @fechaInicioInscripcionPAA,
		 @fechaFinalInscripcionPAA,
		 @cupos
 )

		END
	  ELSE
		BEGIN 
    
			  SELECT 0 AS Resultado
	
		END


GO
/****** Object:  StoredProcedure [dbo].[spBusquedaAsistencia]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spBusquedaAsistencia] @Estudiante varchar(13)
as 
	If Exists (SELECT TOP 1 1 from Inscripciones where numeroCuenta=@Estudiante)
		BEGIN
			select 1 as Resultado

		END
	  ELSE
		BEGIN 
    
			  SELECT 0 AS Resultado
	
		END



GO
/****** Object:  StoredProcedure [dbo].[spBusquedaEstudianteAsistencia]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[spBusquedaEstudianteAsistencia] @Estudiante varchar(13)
as 
declare @hora date
set @hora=CONVERT(date, getdate())

	BEGIN
			SELECT Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante,Carreras.nombreCarrera,Asistencias.fechaRegistro, COUNT (Asistencias.fechaRegistro) AS NumeroRegistros, 1 AS Resultado
			FROM Estudiantes
			INNER JOIN Carreras
			ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
			INNER JOIN Inscripciones
			ON Inscripciones.numeroCuenta = Estudiantes.numeroCuenta
			INNER JOIN Asistencias
			ON Asistencias.codigoInscripcion = Inscripciones.codigoInscripcion
			WHERE Inscripciones.numeroCuenta = @Estudiante  and Asistencias.fechaRegistro=@hora
			GROUP BY Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera, Asistencias.fechaRegistro

	END

GO
/****** Object:  StoredProcedure [dbo].[spBusquedaEstudianteReportePersonal]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spBusquedaEstudianteReportePersonal] @Estudiante varchar(13)

as
If Exists (SELECT TOP 1 1 from Estudiantes where numeroCuenta=@Estudiante)
BEGIN
Select Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera, 1 AS Resultado
		from Estudiantes
		INNER JOIN Carreras
		ON Carreras.CodigoCarrera=Estudiantes.codigoCarrera
		WHERE Estudiantes.numeroCuenta=@Estudiante
		GROUP BY Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera 
	
END
ELSE
BEGIN 
      SELECT 0 AS Resultado
END


GO
/****** Object:  StoredProcedure [dbo].[spComunicado]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spComunicado] 
as
select CodigoPAA,fechaInicioInscripcionPAA,fechaFinalInscripcionPAA,fechaInicioPAA,fechaFinalPAA,cuposPAA from PruebasDeAptitud where estadoPAA=1


GO
/****** Object:  StoredProcedure [dbo].[spConsulta_Estudiante1]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spConsulta_Estudiante1] @Estudiante varchar(13)
as
If Exists (SELECT TOP 1 1 from Estudiantes where numeroCuenta=@Estudiante)
BEGIN
      SELECT 1 AS Resultado FROM Estudiantes WHERE numeroCuenta=@Estudiante
END
ELSE
BEGIN 
      SELECT 0 AS Resultado
END


GO
/****** Object:  StoredProcedure [dbo].[spEstudianteHorasPersonal]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spEstudianteHorasPersonal] @Estudiante varchar (13)
as
declare @total as int
select @total= count(CodigoPAA) from Inscripciones where numeroCuenta=@Estudiante 
Select @Estudiante as [Numero de Cuenta], @total as [Horas por Estudiante]


GO
/****** Object:  StoredProcedure [dbo].[spHorasGeneral]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spHorasGeneral] 
as
SELECT Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante,Carreras.nombreCarrera,Inscripciones.fechaInscripcion,PruebasDeAptitud.codigoPAA, case Inscripciones.estadoAprobacion when 1 then 'Aprobado' 
End as [Horas Acreditadas]
FROM Estudiantes 
INNER JOIN Carreras
ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
INNER JOIN Inscripciones
ON Inscripciones.numeroCuenta = Estudiantes.numeroCuenta 
INNER JOIN PruebasDeAptitud
ON PruebasDeAptitud.codigoPAA = Inscripciones.codigoPAA
WHERE PruebasDeAptitud.estadoPAA=0 and estadoAprobacion=1 
GROUP BY Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera,Inscripciones.fechaInscripcion,PruebasDeAptitud.codigoPAA, Inscripciones.estadoAprobacion 


GO
/****** Object:  StoredProcedure [dbo].[spHorasGeneralEstudiante]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spHorasGeneralEstudiante]
as
declare @total as int, @Estudiante varchar (13)
select @total= count(codigoPAA)from Inscripciones where @Estudiante=numeroCuenta 



GO
/****** Object:  StoredProcedure [dbo].[spHorasPersonal]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spHorasPersonal]  @Estudiante varchar(13)
as
		SELECT Inscripciones.fechaInscripcion,PruebasDeAptitud.codigoPAA , case Inscripciones.estadoAprobacion when 1 then (10) 
		End as [Horas Acreditadas]
		FROM Estudiantes 
		INNER JOIN Carreras
		ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
		INNER JOIN Inscripciones
		ON Inscripciones.numeroCuenta = Estudiantes.numeroCuenta 
		INNER JOIN PruebasDeAptitud
		ON PruebasDeAptitud.codigoPAA = Inscripciones.codigoPAA
		WHERE  Inscripciones.numeroCuenta=@Estudiante and PruebasDeAptitud.estadoPAA=0 and Inscripciones.estadoAprobacion=1 
		GROUP BY /*Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera,*/Inscripciones.fechaInscripcion,PruebasDeAptitud.codigoPAA, Inscripciones.estadoAprobacion 
		


GO
/****** Object:  StoredProcedure [dbo].[spInformacionPAA]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[spInformacionPAA] 
as

declare @Total int 
Select codigoPAA as PAA, fechaInicioPAA as  [Fecha de Inicio] ,fechaFinalPAA as [Fecha de Final], fechaInicioInscripcionPAA as [Fecha de Inicio Inscripciones], fechaFinalInscripcionPAA as [Fecha Final de Inscripciones], cuposPAA as [Cupos Totales] into #PruebasDeAptitud from PruebasDeAptitud 
where estadoPAA=1
ALTER TABLE #PruebasDeAptitud  add [Cupos Restantes] int
UPDATE #PruebasDeAptitud SET [Cupos Restantes] = [Cupos Totales]- (Select count (*) as Total from Inscripciones where codigoPAA in (Select codigoPAA from PruebasDeAptitud where estadoPAA=1) and estadoInscripcion=1 )

Select * from #PruebasDeAptitud 


GO
/****** Object:  StoredProcedure [dbo].[spInscribirEstudiante]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spInscribirEstudiante] @Estudiante varchar (50), @Empleado varchar (50)
as
Declare @EstadoInscripcion bit
Declare @Total int 
Declare @CodigoPAA varchar (9)

 SET @Total = (SELECT cuposPAA from PruebasDeAptitud where estadoPAA=1)- (Select count (*) as Total from Inscripciones where codigoPAA in (Select codigoPAA from PruebasDeAptitud where estadoPAA=1) and estadoInscripcion=1 )
 set @CodigoPAA= (Select codigoPAA from PruebasDeAptitud where estadoPAA=1) 
If @Total>=1

   Set @EstadoInscripcion=1
  
ELSE

   Set @EstadoInscripcion=0


Insert Into Inscripciones
 (
    [fechaInscripcion],
    [estadoInscripcion],
    [codigoPAA],
    [numeroCuenta],
    [codigoEmpleado],
	[estadoAprobacion]
 ) 
Values
 (
    CONVERT(date, getdate()),
    @EstadoInscripcion,
    @codigoPaa,
    @Estudiante,
    @empleado,
	0
 )
select * from Inscripciones
select @EstadoInscripcion



GO
/****** Object:  StoredProcedure [dbo].[spInsertarAsistencia]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertarAsistencia] @Estudiante varchar(13)
as
	Begin
insert into Asistencias
 (
 codigoInscripcion,
 fechaRegistro
 )
 values
 (
 (select codigoInscripcion from Inscripciones where numeroCuenta=@Estudiante),
 CONVERT(date, getdate())
 )
	End


GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spLogin] @Empleado int, @contrasenia  varchar(60)
as

If Exists (Select TOP 1 1 from Empleados where codigoEmpleado= @Empleado and contrasenia=@contrasenia and estadoEmpleado=1)
   BEGIN
   select Empleados.nombreEmpleado, Empleados.codigoEmpleado, TiposAcceso.descripcionTipoAcceso, TiposAcceso.codigoTipoAcceso, 1 as Resultado
	FROM Empleados
	INNER JOIN TiposAcceso
	ON TiposAcceso.codigoTipoAcceso = Empleados.codigoTipoAcceso
	WHERE Empleados.estadoEmpleado  = 1 AND Empleados.codigoEmpleado = @Empleado AND Empleados.contrasenia = @contrasenia

   END
   ELSE
   BEGIN
   select 0 as Resultado

   END



GO
/****** Object:  StoredProcedure [dbo].[spMostrarEstudiante]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spMostrarEstudiante] @Estudiante varchar(13)
as
SELECT Estudiantes.nombreEstudiante,Estudiantes.numeroCuenta,Estudiantes.identidadEstudiante, Carreras.nombreCarrera, TipoEstado.descripcionTipoEstado,TipoEstado.codigoTipoEstado
FROM Estudiantes
INNER JOIN Carreras
ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
INNER JOIN TipoEstado
ON TipoEstado.codigoTipoEstado = Estudiantes.codigoTipoEstado
WHERE Estudiantes.numeroCuenta = @Estudiante


GO
/****** Object:  StoredProcedure [dbo].[spRegistrarPAA]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		create procedure [dbo].[spRegistrarPAA]
		as
	


GO
/****** Object:  StoredProcedure [dbo].[spReporteBusquedaPAA]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spReporteBusquedaPAA] 
as
select codigoPAA, fechaInicioPAA, fechaFinalPAA From PruebasDeAptitud
where estadoPAA=1


GO
/****** Object:  StoredProcedure [dbo].[spReporteEstudianteInscrito]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spReporteEstudianteInscrito]
as
SELECT Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante,Carreras.nombreCarrera,PruebasDeAptitud.codigoPAA,PruebasDeAptitud.fechaInicioPAA, PruebasDeAptitud.fechaFinalPAA, Inscripciones.codigoInscripcion
FROM Estudiantes
INNER JOIN Carreras
ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
INNER JOIN Inscripciones
ON Inscripciones.numeroCuenta = Estudiantes.numeroCuenta
INNER JOIN PruebasDeAptitud
ON PruebasDeAptitud.codigoPAA = Inscripciones.codigoPAA
WHERE PruebasDeAptitud.estadoPAA=1
GROUP BY Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera,PruebasDeAptitud.codigoPAA,PruebasDeAptitud.fechaInicioPAA, PruebasDeAptitud.fechaFinalPAA,Inscripciones.codigoInscripcion


GO
/****** Object:  StoredProcedure [dbo].[spReporteHorasGeneral]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spReporteHorasGeneral] 
as

	SELECT Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante,Carreras.nombreCarrera,PruebasDeAptitud.codigoPAA, PruebasDeAptitud.fechaInicioPAA, PruebasDeAptitud.fechaFinalPAA,
	    case (Count(Asistencias.codigoInscripcion))  when 6 then 'Completo'
	    else 'Incompleto'
	END as [Asistencia] ----case Inscripciones.estadoAprobacion when 1 then 'Aprobado' 
		---End as [Horas Acreditadas]
		From Asistencias
		Inner Join Inscripciones
		On Inscripciones.codigoInscripcion=Asistencias.codigoInscripcion
		Inner Join PruebasDeAptitud
		On PruebasDeAptitud.codigoPAA=Inscripciones.codigoPAA
		Inner Join Estudiantes
		On Estudiantes.numeroCuenta=Inscripciones.numeroCuenta
		Inner Join Carreras
		On Carreras.codigoCarrera=Estudiantes.codigoCarrera
		Where PruebasDeAptitud.estadoPAA=1
		GROUP BY Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera,PruebasDeAptitud.codigoPAA, PruebasDeAptitud.fechaInicioPAA, PruebasDeAptitud.fechaFinalPAA


GO
/****** Object:  StoredProcedure [dbo].[spReporteMemorandum]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spReporteMemorandum] 
as
		SELECT Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante,Carreras.nombreCarrera,--Count(Inscripciones.numeroCuenta )as TOtal
	    Count(Inscripciones.numeroCuenta)
	 
	    
		---End as [Horas Acreditadas]
		From Estudiantes
			Inner Join Inscripciones
		On Inscripciones.numeroCuenta=Estudiantes.numeroCuenta
		--Inner Join Estudiantes
	--	On Estudiantes.numeroCuenta=Inscripciones.numeroCuenta
		INNER JOIN Carreras
		ON Carreras.codigoCarrera = Estudiantes.codigoCarrera

		Where Inscripciones.estadoAprobacion=1
		GROUP BY Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera
		HAVING Count(Inscripciones.numeroCuenta)  = 4


GO
/****** Object:  StoredProcedure [dbo].[spReporteSUDECAD]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Reporte Aparte
CREATE procedure [dbo].[spReporteSUDECAD] 
as
SELECT Estudiantes.nombreEstudiante, Estudiantes.numeroCuenta,Carreras.nombreCarrera,COUNT(Asistencias.codigoInscripcion)AS TotalAsistencias, PruebasDeAptitud.codigoPAA,  PruebasDeAptitud.fechaInicioPAA, PruebasDeAptitud.fechaFinalPAA
FROM Asistencias
INNER JOIN Inscripciones
ON Inscripciones.codigoInscripcion = Asistencias.codigoInscripcion
INNER JOIN PruebasDeAptitud
ON PruebasDeAptitud.codigoPAA = Inscripciones.codigoPAA
INNER JOIN Estudiantes
ON Estudiantes.numeroCuenta = Inscripciones.numeroCuenta
INNER JOIN Carreras
ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
WHERE PruebasDeAptitud.estadoPAA = 1
GROUP BY Estudiantes.nombreEstudiante, Estudiantes.numeroCuenta,Carreras.nombreCarrera,PruebasDeAptitud.codigoPAA,  PruebasDeAptitud.fechaInicioPAA, PruebasDeAptitud.fechaFinalPAA
HAVING COUNT(Asistencias.codigoInscripcion)  = 6



GO
/****** Object:  StoredProcedure [dbo].[spTestInscripcion]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spTestInscripcion]
as
Declare @EstadoInscripcion bit
declare @Total int 
select cuposPAA as [Cupos Totales] into #PruebasDeAptitud from PruebasDeAptitud 
where estadoPAA=1
ALTER TABLE #PruebasDeAptitud  add [Cupos Restantes] int
UPDATE #PruebasDeAptitud SET @Total = [Cupos Totales]- (Select count (*) as Total from Inscripciones where codigoPAA in (Select codigoPAA from PruebasDeAptitud where estadoPAA=1) and estadoInscripcion=1 )

If @Total>=0
BEGIN
   Set @EstadoInscripcion=1
END
ELSE
BEGIN 
      set @EstadoInscripcion=0
END

select @EstadoInscripcion


GO
