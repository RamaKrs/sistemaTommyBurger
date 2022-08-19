DROP DATABASE IF EXISTS TommyBurger;
CREATE DATABASE TommyBurger;
USE TommyBurger;

create table ingredientes(
codIngre int auto_increment,
nombre varchar(50),
precio_ing int,
CONSTRAINT PK_ingredientes PRIMARY KEY (codIngre)
);

create table almacen(
CodEstanteria int auto_increment,
codIngre int ,
cantidad int,
CONSTRAINT pk_almacen primary key (codEstanteria),
CONSTRAINT fk_ingredientesalma FOREIGN KEY (codIngre) references ingredientes (codIngre)
);

create table proveedores(
nroProv int auto_increment,
telefono varchar(15) ,
nombre varchar(50),
CONSTRAINT pk_proveedores PRIMARY KEY (nroProv)
);

create table detallePedidos(
NumPedido int auto_increment,
cantidad int ,
codIngre int ,
nroProv int,
CONSTRAINT pk_detallePedidos PRIMARY KEY (NumPedido),
CONSTRAINT fk_detallePedidos_a FOREIGN KEY (codIngre) references ingredientes (codIngre),
CONSTRAINT fk_detallePedidos_b FOREIGN KEY (nroProv) REFERENCES  proveedores (nroProv)
);

create table hamburguesa(
CodHamburguesa int auto_increment,
cantidadHamburguesas int,
CONSTRAINT pk_hamburguesa primary key (CodHamburguesa)
);

create table HamburguesaIngredientes(
CodHamburguesa int ,
codIngre int,
cantidad int,
CONSTRAINT pk_HamburguesaIngredientes primary key (CodHamburguesa, CodIngre),
CONSTRAINT fk_hamburguesaIngredientes_b foreign key (codIngre) references ingredientes (codIngre),
CONSTRAINT fk_hamburguesaIngredientes_c foreign key (CodHamburguesa) references hamburguesa (CodHamburguesa)
);

create table recibos(
numrecibo int auto_increment,
fecha date,
cantidadVendida int,
monto int,
CodHamburguesa int,
CONSTRAINT pk_recibos primary key (numrecibo),
CONSTRAINT fk_recibos foreign key (CodHamburguesa) references Hamburguesa(CodHamburguesa)
);


insert into ingredientes values
("", "Hamburguesa", 150),
("", "Lechuga", 20),
("", "Tomate", 30),
("", "Cebolla", 35),
("", "Huevo", 40),
("", "Panceta", 80),
("", "Queso", 60),
("", "Salsa Secreta", 10),
("", "Pan", 85),
("", "Papas", 100),
("", "Bebida", 150),
("", "Aderezos", 0);

insert into hamburguesa values
('',2),
('',3),
('',4),
('',2),
('',3),
('',1),
('',2),
('',1),
('',3),
('',2);

insert into hamburguesaIngredientes values
(1,9,1),
(1,1,3),
(1,7,3),
(1,6,3),
(1,4,1),
(1,8,1),
(1,10,1),
(1,11,1);

insert into recibos values
('', curdate(),3,700,2),
('', curdate(),2,500,1),
('', curdate(),1,200,4),
('', curdate(),1,250,6),
('', curdate(),15,3000,5);

insert into proveedores values
("", "15-6754-5845", "Rey de la carne"),
("", "11-4543-2752", "Verduleria Valda"),
("", "11-3364-7586", "Coca-Cola Company"),
("", "15-6563-6767", "Sancor"),
("", "11-2343-2342", "Verduras Geremias"),
("", "15-2383-3587", "Natura"),
("", "11-4654-4543", "Hellmanns"),
("", "11-4933-2190", "Carniceria Ernesto"),
("", "11-7047-6578", "Bimbo");

insert into detallePedidos values
("", 200, 1, 1),
("", 200, 2, 2),
("", 200, 3, 2),
("", 200, 4, 2),
("", 200, 5, 5),
("", 200, 6, 8),
("", 200, 7, 4),
("", 200, 9, 9),
("", 200, 10, 5),
("", 200, 11, 3),
("", 200, 12, 7);

insert into almacen values
('', 1, 250),
('', 2, 150),
('', 3, 50),
('', 4, 200),
('', 5, 250),
('', 6, 250),
('', 7, 250),
('', 8, 250),
('', 9 , 250),
('', 10, 250),
('', 11, 250),
('', 12, 250);
