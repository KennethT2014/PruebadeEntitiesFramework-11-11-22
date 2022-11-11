Create database Cliente
go
use Cliente
go
Create table Clientes
(IdCliente int primary key identity(1,1),
Categoria varchar(50),
Nombre varchar(50),
Apellido varchar(50))

Insert into
Clientes(Categoria, Nombre, Apellido) values
('Super Usuario', 'Kenneth Joan', 'Teller López')

Insert into
Clientes(Categoria, Nombre, Apellido) values
('Super Usuario', 'Diego Alejandro', 'Toruño Dávila')
Insert into
Clientes(Categoria, Nombre, Apellido) values
('Super Usuario', 'Dierish Antonio', 'Rojas Corrales')

Select * from Clientes

Create Login SistemaAdminTarea with password = 'sistemas2022'
go
use Cliente
go
sp_adduser SistemaAdminTarea, SistemaAdminTarea
Grant select, insert, update, delete on Clientes to SistemaAdminTarea