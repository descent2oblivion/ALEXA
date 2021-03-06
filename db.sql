USE [master]
GO
/****** Object:  Database [zoo]    Script Date: 18/02/2020 02:40:24 p. m. ******/
CREATE DATABASE [zoo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'zoo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.OBLIVION\MSSQL\DATA\zoo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'zoo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.OBLIVION\MSSQL\DATA\zoo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [zoo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [zoo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [zoo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [zoo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [zoo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [zoo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [zoo] SET ARITHABORT OFF 
GO
ALTER DATABASE [zoo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [zoo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [zoo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [zoo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [zoo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [zoo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [zoo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [zoo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [zoo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [zoo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [zoo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [zoo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [zoo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [zoo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [zoo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [zoo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [zoo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [zoo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [zoo] SET  MULTI_USER 
GO
ALTER DATABASE [zoo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [zoo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [zoo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [zoo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [zoo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [zoo] SET QUERY_STORE = OFF
GO
USE [zoo]
GO
/****** Object:  Table [dbo].[animales]    Script Date: 18/02/2020 02:40:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animales](
	[idAnimal] [int] IDENTITY(1,1) NOT NULL,
	[animal] [varchar](50) NOT NULL,
 CONSTRAINT [PK_animales] PRIMARY KEY CLUSTERED 
(
	[idAnimal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[addAnim]    Script Date: 18/02/2020 02:40:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavz
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[addAnim] 
	-- Add the parameters for the stored procedure here
	@p1 varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO animales (animal) VALUES (@p1)
END
GO
/****** Object:  StoredProcedure [dbo].[verAnimales]    Script Date: 18/02/2020 02:40:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[verAnimales] 
	-- Add the parameters for the stored procedure here
	  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from animales
END
GO
USE [master]
GO
ALTER DATABASE [zoo] SET  READ_WRITE 
GO
