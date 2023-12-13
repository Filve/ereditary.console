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
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Surname] [nvarchar](250) NULL,
	[Nikname] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[IndividualCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](250) NOT NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalCodeFamily] [int] NULL, 
	[CreationDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActualGender] [int] NULL,
	[OriginalGender] [int] NULL,
	[OriginallyRelashionshipID] [int] NULL, 
	[Status] [int] NULL,
	[StatusInLife] [int] NULL,
	[ChildrenID] [int] NULL,
	[FatherAndMotherActualID] [int] NULL,
	[FatherAndMotherOriginallyID] [int] NULL,
	[HousbandANdWifeOfFamily] [int] NULL,
	[WifesID] [int] NULL)
GO

/****** Object:  Table [dbo].[FatherAndMotherActual]    Script Date: 08/05/2023 15:01:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FatherAndMotherActual](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[FatherCompleteName] [nvarchar](50) NULL,
	[MotherCompleteName] [nvarchar](50) NULL,
	[Nikname] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[IndividualCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](250) NOT NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalCodeFamily] [int] NULL, 
	[CreationDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActualGender] [int] NULL,
	[OriginalGender] [int] NULL,
	[OriginallyRelashionshipID] [int] NULL, 
	[Status] [int] NULL,
	[StatusInLife] [int] NULL,
	[ChildrenID] [int] NULL,
	[FatherAndMotherActualID] [int] NULL,
	[FatherAndMotherOriginallyID] [int] NULL,
	[HousbandANdWifeOfFamily] [int] NULL,
	[WifesID] [int] NULL)
GO

/****** Object:  Table [dbo].[Children]    Script Date: 08/05/2023 15:02:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Children](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Surname] [nvarchar](250) NULL,
	[Nikname] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[IndividualCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](250) NOT NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalCodeFamily] [int] NULL, 
	[CreationDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActualGender] [int] NULL,
	[OriginalGender] [int] NULL,
	[OriginallyRelashionshipID] [int] NULL, 
	[Status] [int] NULL,
	[StatusInLife] [int] NULL,
	[ChildrenID] [int] NULL,
	[FatherAndMotherActualID] [int] NULL,
	[FatherAndMotherOriginallyID] [int] NULL,
	[HousbandANdWifeOfFamily] [int] NULL,
	[WifesID] [int] NULL) 
GO

/****** Object:  Table [dbo].[Wifes]    Script Date: 08/05/2023 15:03:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Wifes](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Surname] [nvarchar](250) NULL,
	[Nikname] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[IndividualCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](250) NOT NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalCodeFamily] [int] NULL, 
	[CreationDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActualGender] [int] NULL,
	[OriginalGender] [int] NULL,
	[OriginallyRelashionshipID] [int] NULL, 
	[Status] [int] NULL,
	[StatusInLife] [int] NULL,
	[ChildrenID] [int] NULL,
	[FatherAndMotherActualID] [int] NULL,
	[FatherAndMotherOriginallyID] [int] NULL,
	[HousbandANdWifeOfFamily] [int] NULL,
	[WifesID] [int] NULL)
GO

/****** Object:  Table [dbo].[HousbandAndWifeOfFamily]    Script Date: 08/05/2023 15:04:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HousbandAndWifeOfFamily](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Surname] [nvarchar](250) NULL,
	[Nikname] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[IndividualCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](250) NOT NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalCodeFamily] [int] NULL, 
	[CreationDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActualGender] [int] NULL,
	[OriginalGender] [int] NULL,
	[OriginallyRelashionshipID] [int] NULL, 
	[Status] [int] NULL,
	[StatusInLife] [int] NULL,
	[ChildrenID] [int] NULL,
	[FatherAndMotherActualID] [int] NULL,
	[FatherAndMotherOriginallyID] [int] NULL,
	[HousbandANdWifeOfFamily] [int] NULL,
	[WifesID] [int] NULL) 
GO

/****** Object:  Table [dbo].[FamilyMembers]    Script Date: 08/05/2023 15:04:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FamilyMembers](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Surname] [nvarchar](250) NULL,
	[Nikname] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[IndividualCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](250) NOT NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalCodeFamily] [int] NULL, 
	[CreationDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActualGender] [int] NULL,
	[OriginalGender] [int] NULL,
	[OriginallyRelashionshipID] [int] NULL, 
	[Status] [int] NULL,
	[StatusInLife] [int] NULL,
	[ChildrenID] [int] NULL,
	[FatherAndMotherActualID] [int] NULL,
	[FatherAndMotherOriginallyID] [int] NULL,
	[HousbandANdWifeOfFamily] [int] NULL,
	[WifesID] [int] NULL)
	GO

/****** Object:  Table [dbo].[FamilyMember]    Script Date: 08/05/2023 15:05:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FamilyMember](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Surname] [nvarchar](250) NULL,
	[Nikname] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[IndividualCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](250) NOT NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalCodeFamily] [int] NULL, 
	[CreationDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActualGender] [int] NULL,
	[OriginalGender] [int] NULL,
	[OriginallyRelashionshipID] [int] NULL, 
	[Status] [int] NULL,
	[StatusInLife] [int] NULL,
	[ChildrenID] [int] NULL,
	[FatherAndMotherActualID] [int] NULL,
	[FatherAndMotherOriginallyID] [int] NULL,
	[HousbandANdWifeOfFamily] [int] NULL,
	[WifesID] [int] NULL) 
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OriginallyRelashionship](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Surname] [nvarchar](250) NULL,
	[Nikname] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[IndividualCode] [int] NOT NULL,
	[ParentalBond] [nvarchar](250) NOT NULL,
	[ParentalCode] [int] NOT NULL,
	[ParentalCodeFamily] [int] NULL, 
	[CreationDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActualGender] [int] NULL,
	[OriginalGender] [int] NULL,
	[OriginallyRelashionshipID] [int] NULL, 
	[Status] [int] NULL,
	[StatusInLife] [int] NULL)