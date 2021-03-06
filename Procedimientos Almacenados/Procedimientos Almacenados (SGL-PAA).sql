USE [SGL-PAA]
GO
/****** Object:  StoredProcedure [dbo].[spAgregarEstudiante]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[spR_Estudiante] @Cuenta varchar (13),@Estudiante varchar(60), @Identidad varchar(16),@Carrera int,@Telefono varchar(60),@Correo varchar(60),@Usuario varchar(60)
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
/****** Object:  StoredProcedure [dbo].[spBuscarVerificarInsertarPAA]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[spR_CrearPAA] @CodigoPAA varchar (8),@fechaInicio date,@fechaFinal date,@fechaInicioInscripcionPAA date,@fechaFinalInscripcionPAA date,@Cupos int, @codigoUsuario varchar(60)
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
/****** Object:  StoredProcedure [dbo].[spB_ConsultaEstudiante]    Script Date: 01/05/2018 18:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[spB_ConsultaEstudiante] @Cuenta varchar(13)  
as
	If Exists (SELECT TOP 1 1 from Estudiantes where numeroCuenta=@Cuenta)
BEGIN
			SELECT 1 As Resultado, Estudiantes.nombreEstudiante,Estudiantes.numeroCuenta,Estudiantes.identidadEstudiante, Carreras.nombreCarrera, TipoEstado.descripcionTipoEstado,TipoEstado.codigoTipoEstado,Estudiantes.telefono,Estudiantes.correo
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
SELECT Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante,Carreras.nombreCarrera,Inscripciones.fechaRegistro,PruebasDeAptitud.codigoPAA, case Inscripciones.estadoAprobacion when 1 then 'Aprobado' 
End as [Horas Acreditadas]
FROM Estudiantes 
INNER JOIN Carreras
ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
INNER JOIN Inscripciones
ON Inscripciones.numeroCuenta = Estudiantes.numeroCuenta 
INNER JOIN PruebasDeAptitud
ON PruebasDeAptitud.codigoPAA = Inscripciones.codigoPAA
WHERE PruebasDeAptitud.estadoPAA=0 and estadoAprobacion=1 
GROUP BY Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera,Inscripciones.fechaRegistro,PruebasDeAptitud.codigoPAA, Inscripciones.estadoAprobacion 


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
		SELECT Inscripciones.fechaRegistro,PruebasDeAptitud.codigoPAA , case Inscripciones.estadoAprobacion when 1 then (10) 
		End as [Horas Acreditadas]
		FROM Estudiantes 
		INNER JOIN Carreras
		ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
		INNER JOIN Inscripciones
		ON Inscripciones.numeroCuenta = Estudiantes.numeroCuenta 
		INNER JOIN PruebasDeAptitud
		ON PruebasDeAptitud.codigoPAA = Inscripciones.codigoPAA
		WHERE  Inscripciones.numeroCuenta=@Estudiante and PruebasDeAptitud.estadoPAA=0 and Inscripciones.estadoAprobacion=1 
		GROUP BY /*Estudiantes.numeroCuenta, Estudiantes.nombreEstudiante, Carreras.nombreCarrera,*/Inscripciones.fechaRegistro,PruebasDeAptitud.codigoPAA, Inscripciones.estadoAprobacion 
		


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

_
GO
/****** Object:  StoredProcedure [dbo].[spInscribirEstudiante]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter procedure [dbo].[spIns_Estudiante] @Cuenta varchar (13), @Usuario varchar (60)
as
Declare @Cupos int 
Declare @CodigoPAA varchar (9)
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
/****** Object:  StoredProcedure [dbo].[spInsertarAsistencia]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spIns_Asistencia] @Cuenta varchar(13),@CodigoUsuario varchar(60)
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
go
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[spLogin] @usuario varchar(60), @contrasenia  varchar(60)
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
/****** Object:  StoredProcedure [dbo].[spMostrarEstudiante]    Script Date: 27/3/2018 22:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spB_InformacionEstudiante] @Cuenta varchar(13)
as
SELECT Estudiantes.nombreEstudiante,Estudiantes.numeroCuenta,Estudiantes.identidadEstudiante, Carreras.nombreCarrera, TipoEstado.descripcionTipoEstado,TipoEstado.codigoTipoEstado
FROM Estudiantes
INNER JOIN Carreras
ON Carreras.codigoCarrera = Estudiantes.codigoCarrera
INNER JOIN TipoEstado
ON TipoEstado.codigoTipoEstado = Estudiantes.codigoTipoEstado
WHERE Estudiantes.numeroCuenta = @Cuenta


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


CREATE PROCEDURE spB_SiEstudianteInscrito
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

go



alter procedure spU_Estudiante  @Cuenta varchar (13),@Estudiante varchar(60), @Identidad varchar(16),@Carrera int,@Telefono varchar(60),@Correo varchar(60),@Usuario varchar(60)
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

alter procedure [dbo].[spU_PAA] @CodigoPAA varchar (9),@PAAInicio date,@PAAFinal date,@InscripcionInicio date,@InscripcionFinal date,@Cupos int, @codigoUsuario varchar(60)
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


alter procedure spR_Usuario @CodigoUsuario2 varchar(60), @Password varchar(60),@CodigoEmpleado int,@TipoAcceso tinyint,@codigoUsuario varchar(60)
as
If Not Exists (SELECT TOP 1 1 as Resultado from Usuarios
	where Usuarios.codigoUsuario=@CodigoUsuario2  )

		if Not Exists(select top 1 1 as Resulado from Usuarios
		Inner Join Empleados
		On Empleados.codigoEmpleado=Usuarios.codigoEmpleado
		where Empleados.estadoEmpleado=0
		)
		Begin
			If Exists (Select * from Usuarios where Usuarios.codigoEmpleado=@CodigoEmpleado )
				update Usuarios 
				set estadoUsuario=0
				where  Usuarios.codigoEmpleado=@CodigoEmpleado

		Insert into Usuarios
		(
		codigoUsuario,
		password,
		codigoEmpleado,
		codigoTipoAcceso,
		usuarioRegistro,
		fechaRegistro,
		estadoUsuario
		)
		Values
		(
		@CodigoUsuario2,
		@Password,
		@CodigoEmpleado,
		@TipoAcceso,
		@codigoUsuario,
		CONVERT(date, getdate()),
		1
		)
		select 1 as Resultado
		END
		Else
		
		select 0 as Resultado
		


go

Alter procedure [dbo].[spB_Usuario] @codigoUsuario varchar(60)  
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

go

Create Procedure spR_Empleado  @CodigoEmpleado int,@Nombre varchar(60),@Identidad varchar(16),@CodigoUsuario varchar(60)
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
		@CodigoUsuario,
		CONVERT(date, getdate())
		)
		select 1 as Resultado
		END
		Else
		
		select 0 as Resultado
go

alter Procedure spU_Usuario @Password varchar(60),@CodigoUsuario varchar(60),@CodigoUsuario2 varchar(60),@EstadoUsuario bit
as
If Exists(Select top 1 1 as Resultado from Usuarios where estadoUsuario=1)
Begin
		Update Usuarios 
		set
		password=@Password,
		usuarioRegistro=@codigoUsuario,
		fecharegistro=CONVERT(date, getdate()),
		estadoUsuario=@EstadoUsuario
		where codigoUsuario=@CodigoUsuario2
		select 1 as Resultado
End
Else
Select 0 as Resultado
go

alter procedure [dbo].[spB_PAA] @PAA varchar(9)  
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
