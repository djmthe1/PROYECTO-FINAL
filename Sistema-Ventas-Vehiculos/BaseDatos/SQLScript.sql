USE [Sistema-Ventas-Vehiculos]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 09/12/2015 08:54:03 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [varchar](30) NULL,
	[Apodo] [varchar](15) NULL,
	[Direccion] [varchar](30) NULL,
	[Cedula] [varchar](20) NULL,
	[Nacionalidad] [varchar](10) NULL,
	[Ocupacion] [varchar](30) NULL,
	[LugarDeNacimiento] [varchar](20) NULL,
	[Sexo] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Colores]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Colores](
	[ColorId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ColorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturaDeVentas]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FacturaDeVentas](
	[FacturaId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [varchar](50) NULL,
	[VehiculoId] [int] NULL,
	[ClienteId] [int] NULL,
	[PagoInicialEnEfectivo] [int] NULL,
	[PagoInicialEnCheque] [int] NULL,
	[PrecioAPagar] [int] NULL,
	[AutorizadoPor] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[FacturaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marcas](
	[MarcaId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MarcaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modelos](
	[ModeloId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ModeloId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Motores]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Motores](
	[MotorId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MotorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NumerosTelefono]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NumerosTelefono](
	[TelefonoId] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NULL,
	[Telefono] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[TelefonoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Telefonos]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Telefonos](
	[TelefonoId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[TelefonoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoDeVehiculos]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDeVehiculos](
	[TipoDeVehiculoId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoDeVehiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Prioridad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 09/12/2015 08:54:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[VehiculoId] [int] IDENTITY(1,1) NOT NULL,
	[EstadoDelVehiculo] [varchar](20) NULL,
	[Modelo] [varchar](20) NULL,
	[Marca] [varchar](20) NULL,
	[Motor] [varchar](20) NULL,
	[Color] [varchar](20) NULL,
	[Año] [int] NULL,
	[NoChasis] [varchar](20) NULL,
	[TipoVehiculo] [varchar](20) NULL,
	[Kilometraje] [int] NULL,
	[Precio] [int] NULL,
	[Placa] [varchar](20) NULL,
	[Matricula] [varchar](20) NULL,
	[EspejoRetrovisorInterno] [bit] NULL,
	[EspejoRetrovisorDerecho] [bit] NULL,
	[EspejoRetrovisorIzquierdo] [bit] NULL,
	[Radio] [bit] NULL,
	[Gato] [bit] NULL,
	[Gomas] [bit] NULL,
	[GomaDeRepuesto] [bit] NULL,
	[Alfombras] [bit] NULL,
	[Botiquin] [bit] NULL,
	[TaponDeGasolina] [bit] NULL,
	[TaponDeRadiador] [bit] NULL,
	[Encendedor] [bit] NULL,
	[ManualDeUsuario] [bit] NULL,
	[DuplicadoDeLlaveDeEncendido] [bit] NULL,
	[LlaveDeRueda] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[VehiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

GO
INSERT [dbo].[Clientes] ([ClienteId], [NombreCompleto], [Apodo], [Direccion], [Cedula], [Nacionalidad], [Ocupacion], [LugarDeNacimiento], [Sexo]) VALUES (1, NULL, N'la yiyi', N'por hay', N'adsad', N'asd', N'asd', N'asd', N'asd')
GO
INSERT [dbo].[Clientes] ([ClienteId], [NombreCompleto], [Apodo], [Direccion], [Cedula], [Nacionalidad], [Ocupacion], [LugarDeNacimiento], [Sexo]) VALUES (2, N'asd', N'asd', N'asd', N'ssaas', N'sad', N'sad', N'asd', N'Masculino')
GO
INSERT [dbo].[Clientes] ([ClienteId], [NombreCompleto], [Apodo], [Direccion], [Cedula], [Nacionalidad], [Ocupacion], [LugarDeNacimiento], [Sexo]) VALUES (3, N'as', N'asd', N'ads', N'asdasd', N'sad', N'asd', N'asd', N'Masculino')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Colores] ON 

GO
INSERT [dbo].[Colores] ([ColorId], [Descripcion]) VALUES (1, N'Rojo')
GO
INSERT [dbo].[Colores] ([ColorId], [Descripcion]) VALUES (2, N'Azul')
GO
INSERT [dbo].[Colores] ([ColorId], [Descripcion]) VALUES (3, N'Blanco')
GO
INSERT [dbo].[Colores] ([ColorId], [Descripcion]) VALUES (4, N'Negro')
GO
SET IDENTITY_INSERT [dbo].[Colores] OFF
GO
SET IDENTITY_INSERT [dbo].[FacturaDeVentas] ON 

GO
INSERT [dbo].[FacturaDeVentas] ([FacturaId], [Fecha], [VehiculoId], [ClienteId], [PagoInicialEnEfectivo], [PagoInicialEnCheque], [PrecioAPagar], [AutorizadoPor]) VALUES (1, N'asd', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDeVentas] ([FacturaId], [Fecha], [VehiculoId], [ClienteId], [PagoInicialEnEfectivo], [PagoInicialEnCheque], [PrecioAPagar], [AutorizadoPor]) VALUES (3, N'ads', 1, 1, 23, 23, 34, N'Tu mama')
GO
INSERT [dbo].[FacturaDeVentas] ([FacturaId], [Fecha], [VehiculoId], [ClienteId], [PagoInicialEnEfectivo], [PagoInicialEnCheque], [PrecioAPagar], [AutorizadoPor]) VALUES (4, N'ads', 15, 1, 23, 23, 34, N'Tu mama')
GO
INSERT [dbo].[FacturaDeVentas] ([FacturaId], [Fecha], [VehiculoId], [ClienteId], [PagoInicialEnEfectivo], [PagoInicialEnCheque], [PrecioAPagar], [AutorizadoPor]) VALUES (5, N'lunes, 30 de noviembre de 2015', 15, 1, 15, 15, 15, N'sdfsdf')
GO
SET IDENTITY_INSERT [dbo].[FacturaDeVentas] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

GO
INSERT [dbo].[Marcas] ([MarcaId], [Descripcion]) VALUES (7, N'Toyota')
GO
INSERT [dbo].[Marcas] ([MarcaId], [Descripcion]) VALUES (8, N'Acura')
GO
INSERT [dbo].[Marcas] ([MarcaId], [Descripcion]) VALUES (9, N'Honda')
GO
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelos] ON 

GO
INSERT [dbo].[Modelos] ([ModeloId], [Descripcion]) VALUES (1, N'ds23')
GO
SET IDENTITY_INSERT [dbo].[Modelos] OFF
GO
SET IDENTITY_INSERT [dbo].[Motores] ON 

GO
INSERT [dbo].[Motores] ([MotorId], [Descripcion]) VALUES (2, N'V8')
GO
INSERT [dbo].[Motores] ([MotorId], [Descripcion]) VALUES (3, N'V4')
GO
INSERT [dbo].[Motores] ([MotorId], [Descripcion]) VALUES (4, N'V6')
GO
SET IDENTITY_INSERT [dbo].[Motores] OFF
GO
SET IDENTITY_INSERT [dbo].[NumerosTelefono] ON 

GO
INSERT [dbo].[NumerosTelefono] ([TelefonoId], [ClienteId], [Telefono]) VALUES (1, 2, N'')
GO
INSERT [dbo].[NumerosTelefono] ([TelefonoId], [ClienteId], [Telefono]) VALUES (2, 2, N'')
GO
INSERT [dbo].[NumerosTelefono] ([TelefonoId], [ClienteId], [Telefono]) VALUES (3, 3, N'123-2323-')
GO
INSERT [dbo].[NumerosTelefono] ([TelefonoId], [ClienteId], [Telefono]) VALUES (4, 3, N'123')
GO
SET IDENTITY_INSERT [dbo].[NumerosTelefono] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDeVehiculos] ON 

GO
INSERT [dbo].[TipoDeVehiculos] ([TipoDeVehiculoId], [Descripcion]) VALUES (1, N'camioneta')
GO
SET IDENTITY_INSERT [dbo].[TipoDeVehiculos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

GO
INSERT [dbo].[Usuarios] ([UsuarioId], [Nombre], [Password], [Prioridad]) VALUES (1, N'hamlet', N'12', 1)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehiculos] ON 

GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (1, N'jh', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (2, N'jh', NULL, NULL, NULL, NULL, 123, N'43', NULL, 234, 23, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (3, N'jh', N'c3', N'as', N'as', N'd', 123, N'43', N'sd', 234, 23, N'24221', N'bnde34', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (4, N'jh', N'c3', N'as', NULL, NULL, 123, N'43', NULL, 234, 23, N'24221', N'bnde34', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (5, N'jh', N'c3', N'as', NULL, NULL, 123, N'43', NULL, 234, 23, N'24221', N'bnde34', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (6, N'jh', N'c3', N'as', NULL, NULL, 123, N'43', NULL, 234, 23, N'24221', N'bnde34', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (7, N'jh', N'c3', N'as', NULL, N'd', 123, N'43', NULL, 234, 23, N'24221', N'bnde34', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (8, N'jh', N'c3', N'as', NULL, N'd', 123, N'43', NULL, 234, 23, N'24221', N'bnde34', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (9, N'jh', N'c3', N'as', N'as', N'd', 123, N'43', N'sd', 234, 23, N'24221', N'bnde34', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (10, N'jh', N'c3', N'as', N'as', N'd', 123, N'43', N'sd', 234, 23, N'24221', N'bnde34', NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (11, N'jh', N'c3', N'as', N'as', N'd', 123, N'43', N'sd', 234, 23, N'24221', N'bnde34', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (12, N'jh', N'c3', N'as', N'as', N'd', 123, N'43', N'sd', 234, 23, N'24221', N'bnde34', 1, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (13, N'jh', N'c3', N'as', N'as', N'd', 123, N'43', N'sd', 234, 23, N'24221', N'bnde34', 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (14, N'jh', N'c3', N'as', N'as', N'd', 123, N'43', N'sd', 234, 23, N'24221', N'bnde34', 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0)
GO
INSERT [dbo].[Vehiculos] ([VehiculoId], [EstadoDelVehiculo], [Modelo], [Marca], [Motor], [Color], [Año], [NoChasis], [TipoVehiculo], [Kilometraje], [Precio], [Placa], [Matricula], [EspejoRetrovisorInterno], [EspejoRetrovisorDerecho], [EspejoRetrovisorIzquierdo], [Radio], [Gato], [Gomas], [GomaDeRepuesto], [Alfombras], [Botiquin], [TaponDeGasolina], [TaponDeRadiador], [Encendedor], [ManualDeUsuario], [DuplicadoDeLlaveDeEncendido], [LlaveDeRueda]) VALUES (15, N'jh', N'c3', N'as', N'as', N'd', 123, N'43', N'sd', 234, 23, N'24221', N'bnde34', 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Vehiculos] OFF
GO
