
--Modelos De Vehiculos
Create table Modelos(
	ModeloId int identity primary key,
	Descripcion varchar(30)
);

--Tipos De Vehiculos
create table TipoDeVehiculos(
	TipoDeVehiculoId int identity primary key,
	Descripcion varchar(30)
);

--Estados De Vehiculos
create table EstadosDelVehiculos(
	EstadoDelVehiculoId int identity primary key,
	Descripcion varchar(5)
);

--Marcas De Vehiculos
create table Marcas(
	MarcaId int identity primary key,
	Descripcion varchar(20)
);

--Motores De Vehiculos
create table Motores(
	MotorId int identity primary key,
	Descripcion varchar(10)
);

--Colores De Vehiculos
create table Colores(
	ColorId int identity primary key,
	Descripcion varchar(10), 
);

--Atributos Opcionales del auto
create table Atributos(
	AtributosId int identity primary key,
	EspejoRetrovisorInterno bit,
	EspejoRetrovisorDerecho bit,
	EspejoRetrovisorIzquierdo bit,
	Radio bit,
	Gato bit,
	Gomas bit,
	GomaDeRepuesto bit,
	Alfombras bit,
	Botiquin bit,
	TaponDeGasolina bit,
	TaponDeRadiador bit,
	Encendedor bit,
	ManualDeUsuario bit,
	DuplicadoDeLlaveDeEncendido bit,
	LlaveDeRueda bit,
);

--Telefonos
create table Telefonos(
	TelefonoId int identity primary key,
	Descripcion varchar(12),
);

create table NumerosTelefono(
	NumeroTelefono int References Telefonos(TelefonoId),
	Numero varchar(12)
);

--Clientes
create table Clientes(
	ClienteId int identity primary key,
	NombreCompleto varchar(30),
	Apodo varchar(15),
	TelefonoId int References Telefonos(TelefonoId),
	Direccion varchar(30),
	Cedula varchar(20),
	Nacionalidad varchar(10),
	Ocupacion varchar(30),
	LugarDeNacimiento varchar(20),
	Sexo varchar(10),
	FacturaId int
);

--Vehiculos
create table Vehiculos(
	VehiculoId int identity primary key,
	EstadoDelVehiculoId int References EstadosDelVehiculos(EstadoDelVehiculoId),
	AtributosId int References Atributos(AtributosId),
	ModeloId int References Modelos(ModeloId),
	MarcaId int References Marcas(MarcaId),
	MotorId int References Motores(MotorId),
	ColorId int References Colores(ColorId),
	Año int,
	NoChasis int,
	TipoVehiculoId int References TipoDeVehiculos(TipoDeVehiculoId),
	Kilometraje int,
	Precio int,
	Placa varchar(20),
	Matricula varchar(20),
);

--Factura de ventas
create table FacturaDeVentas(
	FacturaNo int identity primary key,
	Fecha varchar(10),
	Año int References Vehiculos(VehiculoId),
	MarcaId int References Vehiculos(VehiculoId),
	ModeloId int References Vehiculos(VehiculoId),
	MotorId int References Vehiculos(VehiculoId),
	ColorId int References Vehiculos(VehiculoId),
	TipoDeVehiculoId int References Vehiculos(VehiculoId), 
	EstadoDelVehiculoId int References Vehiculos(VehiculoId),
	PrecioVehiculo int References Vehiculos(VehiculoId),
	PagoInicialEnEfectivo int,
	PagoInicialEnCheque int,
	PrecioAPagar int,
	AutorizadoPor varchar(20)
);