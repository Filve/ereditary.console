CREATE DATABASE [DbEredity]
 CONTAINMENT = NONE

USE [DbEredity]
GO

/****** Object:  Table [dbo].[SupremeEntities]    Script Date: 08/05/2023 15:05:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SupremeEntities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Surname] [nvarchar](250) NULL,
	[ParentalBond] [nvarchar](250) NULL,
	[ParentalCode] [int] NULL,
 CONSTRAINT [PK_SupremeEntities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ChildrenOfGeneration]    Script Date: 08/05/2023 15:01:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ChildrenOfGeneration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Surname] [nvarchar](250) NULL,
	[ParentalBond] [nvarchar](250) NULL,
	[ParentalCode] [int] NOT NULL,
 CONSTRAINT [PK_ChildrenOfGeneration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [DbEredity]
GO

/****** Object:  Table [dbo].[FatherAndMother]    Script Date: 08/05/2023 15:02:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FatherAndMother](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FatherCompleteName] [nvarchar](50) NULL,
	[MotherCompleteName] [nvarchar](50) NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](50) NULL,
 CONSTRAINT [PK_FatherAndMother] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[FatherAndMotherChildren]    Script Date: 08/05/2023 15:03:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FatherAndMotherChildren](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[ParentalBond] [nvarchar](50) NULL,
	[ParentalCode] [int] NULL,
 CONSTRAINT [PK_FatherAndMotherChildren] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[HousbandAndWifeOfFamily]    Script Date: 08/05/2023 15:04:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HousbandAndWifeOfFamily](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[ParentalBond] [nvarchar](50) NULL,
	[ParentalCode] [int] NOT NULL,
 CONSTRAINT [PK_HousbandAndWifeOfFamily] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[HousbandOfGeneration]    Script Date: 08/05/2023 15:04:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HousbandOfGeneration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Surname] [nvarchar](250) NULL,
	[ParentalBond] [nvarchar](250) NULL,
	[ParentalCode] [int] NOT NULL,
 CONSTRAINT [PK_GenerationChildren] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[WifesOfGeneration]    Script Date: 08/05/2023 15:05:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WifesOfGeneration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Surname] [nvarchar](250) NULL,
	[ParentalBond] [nvarchar](250) NULL,
	[ParentalCode] [int] NOT NULL,
 CONSTRAINT [PK_WifesOfGeneration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO