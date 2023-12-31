USE [Registrarse]
GO
/****** Object:  User [alumno]    Script Date: 4/10/2023 08:17:01 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 4/10/2023 08:17:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Usuario] ([id], [UserName], [Contraseña], [nombre], [email], [telefono]) VALUES (1, N'Ulises7', N'Quintero10', N'Ulises', N'uliseskaltman1@gmail.com', 1123126555)
INSERT [dbo].[Usuario] ([id], [UserName], [Contraseña], [nombre], [email], [telefono]) VALUES (2, N'Nicole4', N'Nicky05-', N'Nicole', N'nickibruns@gmail.com', 1124563791)
GO
