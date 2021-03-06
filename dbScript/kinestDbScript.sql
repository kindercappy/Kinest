USE [master]
GO
/****** Object:  Database [kinest]    Script Date: 5/12/2018 9:48:41 PM ******/
CREATE DATABASE [kinest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kinest', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\kinest.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'kinest_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\kinest_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [kinest] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kinest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kinest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kinest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kinest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kinest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kinest] SET ARITHABORT OFF 
GO
ALTER DATABASE [kinest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [kinest] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [kinest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kinest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kinest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kinest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kinest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kinest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kinest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kinest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kinest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kinest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kinest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kinest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kinest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kinest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kinest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kinest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kinest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [kinest] SET  MULTI_USER 
GO
ALTER DATABASE [kinest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kinest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kinest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kinest] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [kinest]
GO
/****** Object:  StoredProcedure [dbo].[sitesStoredAddSite]    Script Date: 5/12/2018 9:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sitesStoredAddSite]
	@protocol NVARCHAR(10),
	@url NVARCHAR(100)
AS

SET NOCOUNT ON

INSERT INTO [dbo].[sitesStored] 
			(
			protocol,
			url
			)
	VALUES
		(@protocol,
		@url)


GO
/****** Object:  StoredProcedure [dbo].[sitesStoredSelectSites]    Script Date: 5/12/2018 9:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sitesStoredSelectSites] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM sitesStored
END

GO
/****** Object:  StoredProcedure [dbo].[sitesStoredSelectUrlStartingWith]    Script Date: 5/12/2018 9:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sitesStoredSelectUrlStartingWith]
	@url NVARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT url FROM sitesStored WHERE url LIKE @url+'%'
END

GO
/****** Object:  Table [dbo].[sitesStored]    Script Date: 5/12/2018 9:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sitesStored](
	[siteId] [int] IDENTITY(1,1) NOT NULL,
	[protocol] [nvarchar](10) NOT NULL,
	[url] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_sitesStored_1] PRIMARY KEY CLUSTERED 
(
	[siteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [kinest] SET  READ_WRITE 
GO
