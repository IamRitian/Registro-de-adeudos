create database GPIserver

use GPIserver

create table Empleados(
No_empleado int not null primary key,
Nombre nvarchar(50) not null,
No_departamento int not null,
CONSTRAINT FK_departamento FOREIGN KEY (No_departamento)
REFERENCES Departamentos(No_departamento),
Codigo nvarchar(4) not null
)

create table Articulos(
clave_articulo nvarchar(50) not null primary key,
Descripcion text,
Precio float not null
)

create table Departamentos(
No_departamento int not null primary key,
Departamento nvarchar(50) not null,
)

create table Adeudo(
No_transaccion int identity(1,1),
No_empleado int not null,
CONSTRAINT FK_clvempleado FOREIGN KEY (No_empleado)
REFERENCES Empleados(No_empleado),
clave_articulo nvarchar(50) not null,
CONSTRAINT FK_clvarticulo FOREIGN KEY (clave_articulo)
REFERENCES Articulos(clave_articulo),
Fecha date not null,
Cantidad int not null,
Monto float not null,
Firmado bit not null,
Pendiente bit not null
)

create table lista_nomina(
No_empleado int not null,
CONSTRAINT FK_clvempleadoNomina FOREIGN KEY (No_empleado)
REFERENCES Empleados(No_empleado),
No_departamento int not null,
CONSTRAINT FK_clvdept_listanomina FOREIGN KEY (No_departamento)
REFERENCES Departamentos(No_departamento),
Lunes float,
Martes float,
Miercoles float,
Jueves float,
Viernes float,
Total float
)

create table AdeudoPendiente(
No_empleado int not null,
CONSTRAINT FK_clvempleadopendi FOREIGN KEY (No_empleado)
REFERENCES Empleados(No_empleado),
clave_articulo nvarchar(50) not null,
CONSTRAINT FK_clvarticulopendi FOREIGN KEY (clave_articulo)
REFERENCES Articulos(clave_articulo),
Fecha date not null,
Cantidad int not null,
Monto float not null,
Firmado bit not null,
Pendiente bit not null,
seleccion bit not null
)

create table Usuarios(
IDusuario int not null,
Nombre varchar(50)not null,
clave varchar(50)not null,
Nivel varchar(50)not null
)


insert into Usuarios values(1, 'prueba', '123', 'Configurador')
insert into Usuarios values(2, 'prueba1', '123', 'Administrador')
insert into Usuarios values(3, 'prueba2', '123', 'Operador')

select * from Usuarios where IDusuario=1 and clave='123'

delete from Usuarios

select * from Empleados where Descripcion like '%torta%'

select * from AdeudoPendiente




select Nombre from Empleados where Nombre like'%wilbert davila%'

select * from tabla_articulo order by Precio desc

alter table AdeudoPendiente add seleccion bit not null
select Descripcion from Articulos

create view tabla_ap as select AdeudoPendiente.seleccion, AdeudoPendiente.No_empleado, Empleados.Nombre,Departamentos.Departamento, AdeudoPendiente.clave_articulo, Articulos.Descripcion, Fecha, Cantidad, Monto 
from (((AdeudoPendiente 
inner join Empleados on Empleados.No_empleado=AdeudoPendiente.No_empleado)
inner join Articulos on Articulos.clave_articulo=AdeudoPendiente.clave_articulo)
inner join Departamentos on Empleados.No_departamento=Departamentos.No_departamento)

select * from list_nomina where No_empleado=11111

alter table Adeudo alter column No_empleado int on cascade delete

select * from Empleados where No_empleado=11111 and Codigo=1111

delete from Empleados where No_empleado=35151

UPDATE Empleados SET codigo=5561 where No_empleado=3651

select No_empleado, Nombre from Empleados where Nombre|No_empleado like '%13%'

select No_empleado,Codigo from Empleados where No_empleado=11111 and Codigo=1522

select * from Adeudo

select * from tabla_ap

select * from AdeudoPendiente

update AdeudoPendiente set Pendiente='false' where No_empleado=111 and clave_articulo=111 and Fecha='' and Cantidad=1 and Monto=

select * from Articulos where Descripcion like '%torta' and Descripcion like 'torta%'

select * from Departamentos

select * from lista_nomina

insert into Empleados values(3213, 'ashbdahbsd', 'asdasda', 1222)

insert into Empleados values(3213,'yguygtgt','yuguv',2222)

insert into Adeudo values(5555,1,'6/10/2017',12.5, 1,'')

alter table lista_nomina
delete Lunes, Martes, Miercoles, Jueves, Viernes from lista_nomina where #empleado=12345

insert into Adeudo values(5555,2,'5/06/17',1, 6,'true')
insert into Adeudo values(5555,1,'5/06/17',1, 40,'true')
select * from Adeudo

delete from lista_nomina

delete from Empleados

SELECT lista_nomina.No_empleado, Empleados.Nombre, Departamentos.Departamento, Lunes, Martes, Miercoles, Jueves, Viernes, Total
FROM ((lista_nomina
inner join Empleados ON Empleados.No_empleado = lista_nomina.No_empleado)
inner join Departamentos ON Departamentos.No_departamento = lista_nomina.No_departamento)

select No_empleado, Codigo from Empleados where No_empleado=33333 and Codigo=111 

delete from Empleados where No_empleado=11111

delete from Adeudo

delete from Articulos where clave_articulo=4

select No_empleado, Nombre, Departamentos.Departamento, Codigo from (Empleados 
inner join Departamentos on Departamentos.No_departamento = Empleados.No_departamento) where No_empleado=12345


CREATE VIEW tabla_empleado AS select No_empleado, Nombre, Departamentos.Departamento from (Empleados inner join Departamentos on Departamentos.No_departamento = Empleados.No_departamento);

create view tabla_departamento as select * from Departamentos;

create view tabla_articulo as select * from Articulos;

create view list_nomina as
SELECT lista_nomina.No_empleado, Empleados.Nombre, Departamentos.Departamento, Lunes, Martes, Miercoles, Jueves, Viernes, Total
FROM ((lista_nomina
inner join Empleados ON Empleados.No_empleado = lista_nomina.No_empleado)
inner join Departamentos ON Departamentos.No_departamento = lista_nomina.No_departamento)


select SUM(Monto) from Adeudo where Fecha='2017/10/17' and #empleado=12345

insert into lista_nomina values(,)

UPDATE lista_nomina SET Lunes='', Martes='', Miercoles='', Jueves='', Viernes='',Total='' where #empleado=

select * from list_nomina

select lista_nomina.No_empleado, Empleados.Nombre, Total from (lista_nomina inner join Empleados on Empleados.No_empleado = lista_nomina.No_empleado)

select * from tabla_articulo