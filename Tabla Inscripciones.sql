use [SIGEA-PAA]
GO
alter table [Inscripciones]
alter column  [estadoAprobacion] int not null default (0)
go
