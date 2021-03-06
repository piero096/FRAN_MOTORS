USE [franmotors]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/01/2022 19:30:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](500) NULL,
	[Apellido] [nvarchar](500) NULL,
	[Dni] [int] NULL,
	[Correo] [varchar](50) NULL,
	[Telefono] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial]    Script Date: 17/01/2022 19:30:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Detalle] [nvarchar](200) NULL,
	[IdMoto] [int] NULL,
 CONSTRAINT [PK_Historial] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Motocicleta]    Script Date: 17/01/2022 19:30:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Motocicleta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [nvarchar](50) NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[NumSerie] [nvarchar](50) NOT NULL,
	[Cilindrada] [nvarchar](50) NOT NULL,
	[Año] [date] NOT NULL,
	[IdCliente] [int] NULL,
	[EstadoMoto] [nvarchar](500) NULL,
 CONSTRAINT [PK_Motocicleta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 17/01/2022 19:30:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](500) NULL,
	[Apellidos] [nvarchar](500) NULL,
	[Dni] [int] NULL,
	[Correo] [nvarchar](500) NULL,
	[Telefono] [int] NULL,
	[Tipo] [nvarchar](50) NULL,
	[Username] [nvarchar](500) NULL,
	[Password] [nvarchar](500) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Dni], [Correo], [Telefono]) VALUES (3, N'Juan', N'Perez', 123123123, N'Juan@gmail.com', 123)
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Dni], [Correo], [Telefono]) VALUES (6, N'Benja', N'Rios', 12345678, N'ben@gmail.com', 34561)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Historial] ON 

INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (1, CAST(N'2021-11-11' AS Date), N'hoaladadadadawdawdawdawd', 1)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (2, CAST(N'2021-11-11' AS Date), N'Buena moto en buen estado', 1)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (3, CAST(N'2021-11-11' AS Date), N'Buena moto en buen estado', 1)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (4, CAST(N'2021-11-11' AS Date), N'Mal estado de moto', 1)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (5, CAST(N'2022-01-17' AS Date), N'awdawdawd', 3)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (6, CAST(N'2022-01-17' AS Date), N'awdawdawd', 3)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (7, CAST(N'2022-01-17' AS Date), N'se cambiaron los aceites', 4)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (8, CAST(N'2022-01-17' AS Date), N'se hizo cambio de bugia', 1)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (9, CAST(N'2022-01-17' AS Date), N'yeah', 2)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (10, CAST(N'2022-01-17' AS Date), N'awdawdawdawdawjdkqwjqjejqwejqiowjeiqjwe', 1)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (11, CAST(N'2022-01-17' AS Date), N'el piero es gil', 18)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (12, CAST(N'2022-01-17' AS Date), N'Aprende Bitcoin, BlockChain, seguridad informática ( RSA, 2FA, etc ), negocio cripto-fiat (exchanges, bots, etc) en 2020', 18)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (13, CAST(N'2022-01-17' AS Date), N'hola mundo', 1)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (14, CAST(N'2022-01-17' AS Date), N'uju', 1)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (15, CAST(N'2022-01-17' AS Date), N'awdawdawdawdawdaw', 3)
INSERT [dbo].[Historial] ([Id], [Fecha], [Detalle], [IdMoto]) VALUES (16, CAST(N'2022-01-17' AS Date), N'hola mundo', 3)
SET IDENTITY_INSERT [dbo].[Historial] OFF
GO
SET IDENTITY_INSERT [dbo].[Motocicleta] ON 

INSERT [dbo].[Motocicleta] ([Id], [Placa], [Marca], [NumSerie], [Cilindrada], [Año], [IdCliente], [EstadoMoto]) VALUES (1, N'M102', N'Honda', N'124', N'2 cilindros', CAST(N'2021-11-27' AS Date), 6, N'En Reparación')
INSERT [dbo].[Motocicleta] ([Id], [Placa], [Marca], [NumSerie], [Cilindrada], [Año], [IdCliente], [EstadoMoto]) VALUES (2, N'M103', N'Kawasaki', N'1242', N'4 cilindros', CAST(N'2021-11-27' AS Date), 6, N'En Reparación')
INSERT [dbo].[Motocicleta] ([Id], [Placa], [Marca], [NumSerie], [Cilindrada], [Año], [IdCliente], [EstadoMoto]) VALUES (3, N'M1034', N'Honda', N'124', N'2 cilindros', CAST(N'2021-11-27' AS Date), 3, N'En Ingreso')
INSERT [dbo].[Motocicleta] ([Id], [Placa], [Marca], [NumSerie], [Cilindrada], [Año], [IdCliente], [EstadoMoto]) VALUES (4, N'M500', N'RTM', N'123123123', N'20 cilindros', CAST(N'2022-01-17' AS Date), 3, N'En Reparación')
INSERT [dbo].[Motocicleta] ([Id], [Placa], [Marca], [NumSerie], [Cilindrada], [Año], [IdCliente], [EstadoMoto]) VALUES (15, N'jajajajajajajaj', N'jajajajajjjajajajja', N'123', N'jajajajja', CAST(N'2022-01-17' AS Date), 3, N'En Reparación')
INSERT [dbo].[Motocicleta] ([Id], [Placa], [Marca], [NumSerie], [Cilindrada], [Año], [IdCliente], [EstadoMoto]) VALUES (16, N'piero', N'piero', N'123', N'piero', CAST(N'2022-01-17' AS Date), 3, N'En Reparación')
INSERT [dbo].[Motocicleta] ([Id], [Placa], [Marca], [NumSerie], [Cilindrada], [Año], [IdCliente], [EstadoMoto]) VALUES (18, N'jajajajjajajajajajajajjajajajjajajajajajajaj', N'jajajajjajajajajajajajjajajajjajajajajajajaj', N'123123', N'jajajajjajajajajaj', CAST(N'2022-01-12' AS Date), 6, N'En Reparación')
SET IDENTITY_INSERT [dbo].[Motocicleta] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Nombre], [Apellidos], [Dni], [Correo], [Telefono], [Tipo], [Username], [Password], [Estado]) VALUES (1, N'Angel', N'Rios', 1234567, N'angel@gmail.com', 12345678, N'Mecanico', N'angel', N'angel', 1)
INSERT [dbo].[User] ([Id], [Nombre], [Apellidos], [Dni], [Correo], [Telefono], [Tipo], [Username], [Password], [Estado]) VALUES (4, N'Piero', N'Lavy', 12345678, N'Piero@gmail.com', 598745632, N'Admin', N'Piero', N'piero', 1)
INSERT [dbo].[User] ([Id], [Nombre], [Apellidos], [Dni], [Correo], [Telefono], [Tipo], [Username], [Password], [Estado]) VALUES (5, N'Pablo', N'Sanchez', 12345698, N'Pablo@gmail.com', 789456213, N'Mecanico', N'Pablo', N'pablo', 1)
INSERT [dbo].[User] ([Id], [Nombre], [Apellidos], [Dni], [Correo], [Telefono], [Tipo], [Username], [Password], [Estado]) VALUES (6, N'Luis', N'Carranza', 45678912, N'Ivan@gmail.com', 12346789, N'Mecanico', N'luis', N'luis', 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
