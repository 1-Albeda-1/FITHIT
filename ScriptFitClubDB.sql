USE [master]
GO
/****** Object:  Database [FitClubDB]    Script Date: 20.05.2023 19:57:45 ******/
CREATE DATABASE [FitClubDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FitClubDB', FILENAME = N'c:\dzsqls\FitClubDB.mdf' , SIZE = 8192KB , MAXSIZE = 30720KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'FitClubDB_log', FILENAME = N'c:\dzsqls\FitClubDB.ldf' , SIZE = 8192KB , MAXSIZE = 30720KB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FitClubDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FitClubDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FitClubDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FitClubDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FitClubDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FitClubDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FitClubDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FitClubDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FitClubDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FitClubDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FitClubDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FitClubDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FitClubDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FitClubDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FitClubDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FitClubDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FitClubDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FitClubDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FitClubDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FitClubDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FitClubDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FitClubDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FitClubDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FitClubDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FitClubDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FitClubDB] SET  MULTI_USER 
GO
ALTER DATABASE [FitClubDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FitClubDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FitClubDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FitClubDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FitClubDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FitClubDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FitClubDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [FitClubDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FitClubDB]
GO
/****** Object:  User [Albeda1310_SQLLogin_1]    Script Date: 20.05.2023 19:57:47 ******/
CREATE USER [Albeda1310_SQLLogin_1] FOR LOGIN [Albeda1310_SQLLogin_1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Albeda1310_SQLLogin_1]
GO
/****** Object:  Schema [Albeda1310_SQLLogin_1]    Script Date: 20.05.2023 19:57:48 ******/
CREATE SCHEMA [Albeda1310_SQLLogin_1]
GO
/****** Object:  Table [dbo].[ActivityNameTable]    Script Date: 20.05.2023 19:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityNameTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ActivityName] [varchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_ActivityNameTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActivityTable]    Script Date: 20.05.2023 19:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NameT] [nchar](25) NOT NULL,
	[SurnameT] [nchar](35) NOT NULL,
	[FitClub] [nchar](35) NOT NULL,
	[Date] [varchar](50) NOT NULL,
	[Time] [nchar](15) NOT NULL,
	[ActivityNameID] [int] NOT NULL,
	[StartTime] [varchar](50) NOT NULL,
	[ActivityName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ActivityTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomersTable]    Script Date: 20.05.2023 19:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomersTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Phone] [nchar](20) NOT NULL,
	[ActivityId] [int] NOT NULL,
	[SeasonTTF] [nchar](25) NOT NULL,
	[SeasonTicket] [nchar](25) NULL,
 CONSTRAINT [PK_CustomersTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersTable]    Script Date: 20.05.2023 19:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nchar](15) NOT NULL,
	[Password] [nchar](15) NOT NULL,
 CONSTRAINT [PK_UsersTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ActivityNameTable] ON 

INSERT [dbo].[ActivityNameTable] ([ID], [ActivityName], [Cost]) VALUES (1, N'Пилатес', 1200.0000)
INSERT [dbo].[ActivityNameTable] ([ID], [ActivityName], [Cost]) VALUES (2, N'Бокс', 1000.0000)
INSERT [dbo].[ActivityNameTable] ([ID], [ActivityName], [Cost]) VALUES (4, N'Единоборства', 1200.0000)
INSERT [dbo].[ActivityNameTable] ([ID], [ActivityName], [Cost]) VALUES (6, N'Йога', 1300.0000)
INSERT [dbo].[ActivityNameTable] ([ID], [ActivityName], [Cost]) VALUES (8, N'Гимнастика на полотнах', 1600.0000)
INSERT [dbo].[ActivityNameTable] ([ID], [ActivityName], [Cost]) VALUES (10, N'Stretching', 1100.0000)
INSERT [dbo].[ActivityNameTable] ([ID], [ActivityName], [Cost]) VALUES (11, N'Cycling', 1400.0000)
SET IDENTITY_INSERT [dbo].[ActivityNameTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ActivityTable] ON 

INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (1, N'Алина                    ', N'Васильева                          ', N'FITHIT(м. Автово)                  ', N'14 июня 2023 г.', N'2 часа         ', 1, N'12:00', N'Пилатес')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (2, N'Антон                    ', N'Лебедев                            ', N'FITHIT(м. Беговая)                 ', N'13 июня 2023 г.', N'1,5 часа       ', 2, N'16:00', N'Бокс')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (4, N'Ольга                    ', N'Кудапина                           ', N'FITHIT(м. Пионерская)              ', N'12 июня 2023 г.', N'2 часа         ', 1, N'14:00', N'Пилатес')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (6, N'Виктория                 ', N'Булгакова                          ', N'FITHIT(м. Автово)                  ', N'14 июня 2023 г.', N'2 часа         ', 6, N'16:00', N'Йога')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (8, N'Милана                   ', N'Шастун                             ', N'FITHIT(м. Пионерская)              ', N'15 июня 2023 г.', N'1,5 часа       ', 8, N'13:00', N'Гимнастика на полотнах')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (10, N'Валерия                  ', N'Смирнова                           ', N'FITHIT(м. Беговая)                 ', N'13 июня 2023 г.', N'2 часа         ', 10, N'17:00', N'Stretching')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (11, N'Мария                    ', N'Сидорова                           ', N'FITHIT(м. Беговая)                 ', N'15 июня 2023 г.', N'2 часа         ', 11, N'18:00', N'Cycling')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (12, N'Илья                     ', N'Макаров                            ', N'FITHIT(м. Пионерская)              ', N'12 июня 2023 г.', N'1,5 часа       ', 2, N'12:00', N'Бокс')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (13, N'Олеся                    ', N'Форер                              ', N'FITHIT(м. Пионерская)              ', N'13 июня 2023 г.', N'2 часа         ', 8, N'15:00', N'Гимнастика на полотнах')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (14, N'Максим                   ', N'Орлов                              ', N'FITHIT(м. Беговая)                 ', N'14 июня 2023 г.', N'1,5 часа       ', 4, N'14:00', N'Единоборства')
INSERT [dbo].[ActivityTable] ([ID], [NameT], [SurnameT], [FitClub], [Date], [Time], [ActivityNameID], [StartTime], [ActivityName]) VALUES (15, N'Юлия                     ', N'Воробьёва                          ', N'FITHIT(м. Автово)                  ', N'16 июня 2023 г.', N'2 часа         ', 6, N'17:00', N'Йога')
SET IDENTITY_INSERT [dbo].[ActivityTable] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomersTable] ON 

INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (1, N'Алиса', N'Иванова', N'(931) 562-7834      ', 10, N'Да                       ', N'Месяц                    ')
INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (2, N'Наталия', N'Киселевская', N'(921) 426-7821      ', 6, N'Нет                      ', NULL)
INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (3, N'Алина', N'Баженова', N'(931) 452-1187      ', 1, N'Да                       ', N'Месяц                    ')
INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (4, N'Андрей', N'Неганов', N'(931) 425-5632      ', 8, N'Нет                      ', NULL)
INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (5, N'Мария', N'Парушкина', N'(921) 672-2281      ', 15, N'Да                       ', N'Месяц                    ')
INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (6, N'Светлана', N'Птушкина', N'(921) 625-9878      ', 1, N'Да                       ', N'Год                      ')
INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (7, N'Михаил', N'Воробьёв', N'(931) 989-9254      ', 8, N'Нет                      ', NULL)
INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (8, N'Екатерина', N'Киселёва', N'(921) 092-2215      ', 4, N'Нет                      ', NULL)
INSERT [dbo].[CustomersTable] ([ID], [Name], [Surname], [Phone], [ActivityId], [SeasonTTF], [SeasonTicket]) VALUES (9, N'Степан', N'Соловьёв', N'(931) 217-6988      ', 12, N'Да                       ', N'Год                      ')
SET IDENTITY_INSERT [dbo].[CustomersTable] OFF
GO
SET IDENTITY_INSERT [dbo].[UsersTable] ON 

INSERT [dbo].[UsersTable] ([ID], [Login], [Password]) VALUES (1, N'Kristina       ', N'4321           ')
INSERT [dbo].[UsersTable] ([ID], [Login], [Password]) VALUES (2, N'Elena          ', N'4321           ')
INSERT [dbo].[UsersTable] ([ID], [Login], [Password]) VALUES (3, N'Olga           ', N'1234           ')
INSERT [dbo].[UsersTable] ([ID], [Login], [Password]) VALUES (4, N'Maria          ', N'1234           ')
SET IDENTITY_INSERT [dbo].[UsersTable] OFF
GO
ALTER TABLE [dbo].[ActivityNameTable]  WITH CHECK ADD  CONSTRAINT [FK_ActivityNameTable_ActivityNameTable] FOREIGN KEY([ID])
REFERENCES [dbo].[ActivityNameTable] ([ID])
GO
ALTER TABLE [dbo].[ActivityNameTable] CHECK CONSTRAINT [FK_ActivityNameTable_ActivityNameTable]
GO
ALTER TABLE [dbo].[ActivityTable]  WITH CHECK ADD  CONSTRAINT [FK_ActivityTable_ActivityNameTable] FOREIGN KEY([ActivityNameID])
REFERENCES [dbo].[ActivityNameTable] ([ID])
GO
ALTER TABLE [dbo].[ActivityTable] CHECK CONSTRAINT [FK_ActivityTable_ActivityNameTable]
GO
ALTER TABLE [dbo].[CustomersTable]  WITH CHECK ADD  CONSTRAINT [FK_CustomersTable_ActivityTable] FOREIGN KEY([ActivityId])
REFERENCES [dbo].[ActivityTable] ([ID])
GO
ALTER TABLE [dbo].[CustomersTable] CHECK CONSTRAINT [FK_CustomersTable_ActivityTable]
GO
USE [master]
GO
ALTER DATABASE [FitClubDB] SET  READ_WRITE 
GO
