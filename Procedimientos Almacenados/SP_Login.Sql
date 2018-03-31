create procedure [dbo].[spLogin] @Empleado varchar(60), @contrasenia  varchar(60)
as
If Exists (Select TOP 1 1 from Usuarios where codigoUsuario= @Empleado and password=@contrasenia)
   BEGIN
   select Empleados.nombreEmpleado, Empleados.codigoEmpleado, TiposAcceso.descripcionTipoAcceso, TiposAcceso.codigoTipoAcceso, 1 as Resultado
	FROM Usuarios
	INNER JOIN TiposAcceso
	ON TiposAcceso.codigoTipoAcceso = Usuarios.codigoTipoAcceso
	Inner Join Empleados 
	ON Empleados.codigoEmpleado=Usuarios.codigoEmpleado
	WHERE Empleados.estadoEmpleado  = 1 AND Usuarios.codigoUsuario = @Empleado AND Usuarios.password = @contrasenia

   END
   ELSE
   BEGIN
   select 0 as Resultado

   END
