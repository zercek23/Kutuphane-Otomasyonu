USE [master]
GO
/****** Object:  Database [Kutuphane_Veritabani]    Script Date: 16.12.2019 08:20:40 ******/
CREATE DATABASE [Kutuphane_Veritabani]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kutuphane_Veritabani', FILENAME = N'C:\Users\DELL\Kutuphane_Veritabani.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kutuphane_Veritabani_log', FILENAME = N'C:\Users\DELL\Kutuphane_Veritabani_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Kutuphane_Veritabani] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kutuphane_Veritabani].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kutuphane_Veritabani] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET  MULTI_USER 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kutuphane_Veritabani] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kutuphane_Veritabani] SET QUERY_STORE = OFF
GO
USE [Kutuphane_Veritabani]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Kutuphane_Veritabani]
GO
/****** Object:  Table [dbo].[Bilgisayar]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilgisayar](
	[bilgisayarNo] [int] IDENTITY(1,1) NOT NULL,
	[marka] [varchar](30) NOT NULL,
	[model] [varchar](30) NOT NULL,
	[stokSayisi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bilgisayarNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BilgisayarKayit]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BilgisayarKayit](
	[bilgisayarKayitNo] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciNo] [int] NOT NULL,
	[bilgisayarNo] [int] NOT NULL,
	[alisTarih] [date] NOT NULL,
	[verisTarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[bilgisayarKayitNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Il]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Il](
	[ilNo] [int] NOT NULL,
	[ilAdi] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilce]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilce](
	[ilceNo] [int] NOT NULL,
	[ilceAdi] [varchar](20) NOT NULL,
	[ilNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ilceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IletisimBilgileri]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IletisimBilgileri](
	[iletisimNo] [int] IDENTITY(1,1) NOT NULL,
	[telefon] [varchar](15) NOT NULL,
	[adres] [varchar](100) NOT NULL,
	[eposta] [varchar](30) NOT NULL,
	[ilNo] [int] NOT NULL,
	[ilceNo] [int] NULL,
	[okulNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[iletisimNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[kategoriNo] [int] NOT NULL,
	[kategoriAdi] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[kategoriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[kitapNo] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
	[kitapAdi] [varchar](50) NOT NULL,
	[yayinEviAdi] [varchar](50) NOT NULL,
	[yazarAdiSoyad] [varchar](50) NOT NULL,
	[stokSayisi] [int] NOT NULL,
	[basimTarih] [date] NOT NULL,
	[ciltNo] [int] NOT NULL,
	[kategoriNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[kitapNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KitapKayit]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KitapKayit](
	[kitapKayitNo] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciNo] [int] NOT NULL,
	[kitapNo] [int] NOT NULL,
	[alisTarih] [date] NOT NULL,
	[verisTarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[kitapKayitNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciNo] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [varchar](16) NOT NULL,
	[sifre] [varchar](16) NOT NULL,
	[tcNo] [varchar](50) NOT NULL,
	[adSoyad] [varchar](50) NOT NULL,
	[cinsiyet] [varchar](50) NOT NULL,
	[dogumTarih] [date] NOT NULL,
	[iletisimNo] [int] NOT NULL,
	[kullaniciTur] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[kullaniciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Okul]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Okul](
	[okulNo] [int] NOT NULL,
	[okulAdi] [varchar](50) NOT NULL,
	[ilceNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[okulNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[kullaniciNo] [int] NOT NULL,
	[yetki] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[kullaniciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uye]    Script Date: 16.12.2019 08:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uye](
	[kullaniciNo] [int] NOT NULL,
	[kayitTarih] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[kullaniciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BilgisayarKayit]  WITH CHECK ADD  CONSTRAINT [FK_BilgisayarKayit_Bilgisayar] FOREIGN KEY([bilgisayarNo])
REFERENCES [dbo].[Bilgisayar] ([bilgisayarNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BilgisayarKayit] CHECK CONSTRAINT [FK_BilgisayarKayit_Bilgisayar]
GO
ALTER TABLE [dbo].[BilgisayarKayit]  WITH CHECK ADD  CONSTRAINT [FK_BilgisayarKayit_Kullanici] FOREIGN KEY([kullaniciNo])
REFERENCES [dbo].[Kullanici] ([kullaniciNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BilgisayarKayit] CHECK CONSTRAINT [FK_BilgisayarKayit_Kullanici]
GO
ALTER TABLE [dbo].[Ilce]  WITH CHECK ADD  CONSTRAINT [FK_Ilce_Il] FOREIGN KEY([ilNo])
REFERENCES [dbo].[Il] ([ilNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ilce] CHECK CONSTRAINT [FK_Ilce_Il]
GO
ALTER TABLE [dbo].[IletisimBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_IletisimBilgileri_Il] FOREIGN KEY([ilNo])
REFERENCES [dbo].[Il] ([ilNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IletisimBilgileri] CHECK CONSTRAINT [FK_IletisimBilgileri_Il]
GO
ALTER TABLE [dbo].[IletisimBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_IletisimBilgileri_Ilce] FOREIGN KEY([ilceNo])
REFERENCES [dbo].[Ilce] ([ilceNo])
GO
ALTER TABLE [dbo].[IletisimBilgileri] CHECK CONSTRAINT [FK_IletisimBilgileri_Ilce]
GO
ALTER TABLE [dbo].[IletisimBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_IletisimBilgileri_Okul] FOREIGN KEY([okulNo])
REFERENCES [dbo].[Okul] ([okulNo])
GO
ALTER TABLE [dbo].[IletisimBilgileri] CHECK CONSTRAINT [FK_IletisimBilgileri_Okul]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Kategori] FOREIGN KEY([kategoriNo])
REFERENCES [dbo].[Kategori] ([kategoriNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Kategori]
GO
ALTER TABLE [dbo].[KitapKayit]  WITH CHECK ADD  CONSTRAINT [FK_KitapKayit_Kitap] FOREIGN KEY([kitapNo])
REFERENCES [dbo].[Kitap] ([kitapNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KitapKayit] CHECK CONSTRAINT [FK_KitapKayit_Kitap]
GO
ALTER TABLE [dbo].[KitapKayit]  WITH CHECK ADD  CONSTRAINT [FK_KitapKayit_Kullanici] FOREIGN KEY([kullaniciNo])
REFERENCES [dbo].[Kullanici] ([kullaniciNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KitapKayit] CHECK CONSTRAINT [FK_KitapKayit_Kullanici]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_IletisimBilgileri] FOREIGN KEY([iletisimNo])
REFERENCES [dbo].[IletisimBilgileri] ([iletisimNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_IletisimBilgileri]
GO
ALTER TABLE [dbo].[Okul]  WITH CHECK ADD  CONSTRAINT [FK_Okul_Ilce] FOREIGN KEY([ilceNo])
REFERENCES [dbo].[Ilce] ([ilceNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Okul] CHECK CONSTRAINT [FK_Okul_Ilce]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Kullanici] FOREIGN KEY([kullaniciNo])
REFERENCES [dbo].[Kullanici] ([kullaniciNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Kullanici]
GO
ALTER TABLE [dbo].[Uye]  WITH CHECK ADD  CONSTRAINT [FK_Uye_Kullanici] FOREIGN KEY([kullaniciNo])
REFERENCES [dbo].[Kullanici] ([kullaniciNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uye] CHECK CONSTRAINT [FK_Uye_Kullanici]
GO
USE [master]
GO
ALTER DATABASE [Kutuphane_Veritabani] SET  READ_WRITE 
GO
