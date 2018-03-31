CREATE PROCEDURE [dbo].[spLogin] @usuario VARCHAR(60), @contrasenia  VARCHAR(60)
AS
If Exists (SELECT TOP 1 1 FROM Usuarios WHERE codigoUsuario= @usuario AND password=@contrasenia)
	BEGIN
        	SELECT 1 AS Resultado, Empleados.nombreEmpleado, Empleados.codigoEmpleado, TiposAcceso.descripcionTipoAcceso, TiposAcceso.codigoTipoAcceso
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
