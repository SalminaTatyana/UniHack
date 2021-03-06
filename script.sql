USE [master]
GO
/****** Object:  Database [XakatonBD]    Script Date: 11.12.2021 7:43:35 ******/
CREATE DATABASE [XakatonBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'XakatonBD', FILENAME = N'D:\Moi dokuments\ИНСТИТУТ\3 курс\DataBase\MyDataBase\XakatonBD.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'XakatonBD_log', FILENAME = N'D:\Moi dokuments\ИНСТИТУТ\3 курс\DataBase\MyDataBase\XakatonBD_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [XakatonBD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [XakatonBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [XakatonBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [XakatonBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [XakatonBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [XakatonBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [XakatonBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [XakatonBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [XakatonBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [XakatonBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [XakatonBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [XakatonBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [XakatonBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [XakatonBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [XakatonBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [XakatonBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [XakatonBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [XakatonBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [XakatonBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [XakatonBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [XakatonBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [XakatonBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [XakatonBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [XakatonBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [XakatonBD] SET RECOVERY FULL 
GO
ALTER DATABASE [XakatonBD] SET  MULTI_USER 
GO
ALTER DATABASE [XakatonBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [XakatonBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [XakatonBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [XakatonBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [XakatonBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [XakatonBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'XakatonBD', N'ON'
GO
ALTER DATABASE [XakatonBD] SET QUERY_STORE = OFF
GO
USE [XakatonBD]
GO
/****** Object:  Schema [mifi]    Script Date: 11.12.2021 7:43:35 ******/
CREATE SCHEMA [mifi]
GO
/****** Object:  Schema [util]    Script Date: 11.12.2021 7:43:35 ******/
CREATE SCHEMA [util]
GO
/****** Object:  Table [mifi].[FacultyTeachers]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[FacultyTeachers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[facultyId] [bigint] NOT NULL,
	[teacherId] [bigint] NOT NULL,
 CONSTRAINT [PK_FacultyTeachers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[Faculties]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Faculties](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[Users]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[login] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[isLocked] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[Teachers]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Teachers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](255) NOT NULL,
	[firstName] [varchar](255) NOT NULL,
	[middleName] [varchar](255) NOT NULL,
	[dateOfBirth] [datetime] NULL,
	[email] [varchar](255) NULL,
	[phone] [varchar](20) NULL,
	[userId] [bigint] NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[TeachersView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[TeachersView]
AS
  SELECT t.id
		,t.lastName
		,t.firstName
		,t.middleName
		,t.lastName + ' ' + t.firstName + ' ' + t.middleName as FIO
		,t.dateOfBirth
		,t.email
		,t.userId
		,u.login 
  from mifi.Teachers t
		left JOIN mifi.Users u on u.id = t.userId

GO
/****** Object:  View [mifi].[FacultyTeachersView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE VIEW [mifi].[FacultyTeachersView]
	AS

	  SELECT ft.id,
             ft.facultyId,
             f.name,
             ft.teacherId,
			 tv.FIO
	  FROM mifi.FacultyTeachers ft
			INNER JOIN mifi.Faculties f ON f.id = ft.facultyId
			INNER JOIN mifi.TeachersView tv ON tv.id = ft.teacherId	  
GO
/****** Object:  Table [mifi].[FacultiesGroups]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[FacultiesGroups](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NULL,
 CONSTRAINT [PK_FacultiesGroups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[FacultiesGroupContents]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[FacultiesGroupContents](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[facultyId] [bigint] NOT NULL,
	[facultyGroupId] [bigint] NOT NULL,
 CONSTRAINT [PK_FacultiesGroupContents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[FacultiesGroupContentsView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[FacultiesGroupContentsView]
AS
    SELECT fgc.id,
           fgc.facultyId,
           f.name AS facultyName,
           fgc.facultyGroupId,
           fg.name AS facultyGroupName
	FROM mifi.FacultiesGroupContents fgc
			INNER JOIN mifi.FacultiesGroups fg ON fg.id = fgc.facultyGroupId
			INNER JOIN mifi.Faculties f ON f.id = fgc.facultyId
GO
/****** Object:  Table [mifi].[Rights]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Rights](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Rights] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[UserRights]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[UserRights](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[userId] [bigint] NOT NULL,
	[rightId] [bigint] NOT NULL,
 CONSTRAINT [PK_UserRights] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[UserRightsView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[UserRightsView]
AS
    
	SELECT  ur.id
			,ur.userId
			,u.login
			,ur.rightId
			,r.name
	from mifi.UserRights ur 
			inner join mifi.Users u  on u.id = ur.userId
			inner join mifi.Rights r on r.id = ur.rightId

GO
/****** Object:  Table [mifi].[Specialties]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Specialties](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[shortName] [varchar](255) NULL,
	[number] [varchar](255) NULL,
	[facultyGroupId] [bigint] NULL,
 CONSTRAINT [PK_Specialties] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[SpecialtiesView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[SpecialtiesView]
as
	select s.id
			,s.name
			,s.number
			,s.facultyGroupId
			,fg.name AS facultyGroupName
	from mifi.Specialties s
			INNER JOIN mifi.FacultiesGroups fg ON fg.id = s.facultyGroupId
GO
/****** Object:  Table [mifi].[Courses]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Courses](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[Groups]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Groups](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[specialityId] [bigint] NULL,
	[courseId] [bigint] NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[GroupsView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[GroupsView]
as

	select g.id
			,g.name as groupName
			,g.specialityId 
			,s.name as specialityName
			,s.number as specialityNumber
			,g.courseId
			,c.name as courseName
	from mifi.Groups g
			inner JOIN mifi.Specialties s on s.id =  g.specialityId
			INNER JOIN mifi.Courses c on c.id = g.courseId
    
GO
/****** Object:  Table [mifi].[TimeTable]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[TimeTable](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[weekNumber] [varchar](255) NULL,
	[groupId] [bigint] NULL,
	[dayOfWeekId] [bigint] NULL,
	[paraNumber] [varchar](1) NULL,
	[timeStart_1] [varchar](20) NULL,
	[timeEnd_1] [varchar](20) NULL,
	[timeStart_2] [varchar](20) NULL,
	[timeEnd_2] [varchar](20) NULL,
	[lessonId] [bigint] NULL,
	[lessonTypeId] [bigint] NULL,
	[teacherId] [bigint] NULL,
	[corpsId] [bigint] NULL,
	[classRoomId] [bigint] NULL,
 CONSTRAINT [PK_TimeTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[Lessons]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Lessons](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Lessons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[LessonsTypes]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[LessonsTypes](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[shortName] [varchar](100) NULL,
 CONSTRAINT [PK_LessonsTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[DaysOfWeeks]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[DaysOfWeeks](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NOT NULL,
 CONSTRAINT [PK_DaysOfWeeks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[Corps]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Corps](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Corps] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[ClassRooms]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[ClassRooms](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](10) NULL,
 CONSTRAINT [PK_ClassRooms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[TimeTableView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[TimeTableView]
AS
    
	SELECT TOP 10000
	       tt.weekNumber,
           tt.groupId,
		   g.groupName,
		   g.courseId,
		   g.courseName,
           tt.dayOfWeekId,
		   dow.name AS daysOfWeeks,
           tt.paraNumber,
           tt.timeStart_1,
           tt.timeEnd_1,
           tt.timeStart_2,
           tt.timeEnd_2,
           tt.lessonId,
		   l.name AS lessonName,
           tt.lessonTypeId,
		   lt.shortName AS lessonTypeShortName,
           tt.teacherId,
		   tv.FIO,
           tt.corpsId,
		   c.name AS corpusName,
           tt.classRoomId,
		   cr.name AS classRoomName
	FROM mifi.TimeTable tt
		LEFT JOIN mifi.DaysOfWeeks dow ON dow.id = tt.dayOfWeekId
		LEFT JOIN mifi.GroupsView g ON g.id = tt.groupId
		LEFT JOIN mifi.Lessons l ON l.id = tt.lessonId
		LEFT JOIN mifi.LessonsTypes lt ON lt.id = tt.lessonTypeId
		LEFT JOIN mifi.TeachersView tv ON tv.id = tt.teacherId
		LEFT JOIN mifi.Corps c ON c.id = tt.corpsId
		LEFT JOIN mifi.ClassRooms cr ON cr.id = tt.classRoomId
	ORDER BY g.courseId, g.groupName, weekNumber,dayOfWeekId,paraNumber
GO
/****** Object:  Table [mifi].[Students]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Students](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](255) NOT NULL,
	[firstName] [varchar](255) NOT NULL,
	[middleName] [varchar](255) NOT NULL,
	[dateOfBirth] [datetime] NOT NULL,
	[email] [varchar](255) NOT NULL,
	[specialityId] [bigint] NOT NULL,
	[courseId] [bigint] NOT NULL,
	[groupId] [bigint] NOT NULL,
	[userId] [bigint] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[StudentsView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[StudentsView]
AS
    SELECT stud.id
			,stud.lastName
			,stud.firstName
			,stud.middleName
			,stud.lastName + ' ' + stud.firstName + ' ' + stud.middleName as FIO
			,stud.dateOfBirth
			,stud.email
			,stud.specialityId
			,s.name as specialityName
			,s.number as specialityNumber
			,stud.courseId
			,c.name as courseName
			,stud.groupId
			,g.name as groupName
			,g.shortName as groupShortName			
			,stud.userId
			,u.login as userLogin
	from mifi.Students stud
			inner join mifi.Specialties s on s.id = stud.specialityId
			INNER JOIN mifi.Courses c on c.id = stud.courseId
			INNER JOIN mifi.Groups g on g.id = stud.groupId
			INNER JOIN mifi.Users u on u.id = stud.userId

GO
/****** Object:  Table [mifi].[FacultyLessons]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[FacultyLessons](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[facultyId] [bigint] NOT NULL,
	[lessonId] [bigint] NOT NULL,
 CONSTRAINT [PK_FacultyLessons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[FacultyLessonsView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[FacultyLessonsView]
AS
  SELECT fl.id
		,fl.facultyId
		,f.name as facultyName
		,fl.lessonId
		,l.name as lessonName
  from mifi.FacultyLessons fl
		INNER JOIN mifi.Faculties f on f.id = fl.facultyId
		INNER JOIN mifi.Lessons l on l.id = fl.lessonId
  
GO
/****** Object:  Table [mifi].[TimeTableReesters]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[TimeTableReesters](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created] [datetime] NOT NULL,
	[fileName] [varchar](255) NOT NULL,
	[userId] [bigint] NOT NULL,
	[filePath] [varchar](255) NULL,
	[isCurrent] [bit] NOT NULL,
 CONSTRAINT [PK_TimeTableReesters] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[TimeTableReestersView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[TimeTableReestersView]
AS
  
  SELECT ttr.id,
         ttr.created,
         ttr.fileName,
         ttr.userId,
		 u.login,
         ttr.filePath,
         ttr.isCurrent
  FROM mifi.TimeTableReesters ttr 
		LEFT JOIN  mifi.Users u ON u.id = ttr.userId

GO
/****** Object:  Table [mifi].[TeacherLessons]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[TeacherLessons](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[teacherId] [bigint] NOT NULL,
	[lessonId] [bigint] NOT NULL,
 CONSTRAINT [PK_TeacherLessons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[TeacherLessonsView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[TeacherLessonsView]
as

SELECT  tl.id
		,tl.teacherId
		,tv.FIO as teacherFIO
		,tl.lessonId
		,l.name as lessonName
from  mifi.TeacherLessons  tl
		INNER JOIN mifi.TeachersView tv on tv.id = tl.teacherId
		INNER JOIN mifi.Lessons l on l.id = tl.lessonId
GO
/****** Object:  Table [mifi].[Portfolio]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[Portfolio](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[studentId] [bigint] NOT NULL,
	[achievement] [bigint] NOT NULL,
	[numberMark] [bigint] NOT NULL,
 CONSTRAINT [PK_Portfolio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[PortfolioView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[PortfolioView]
as

SELECT  p.id
		,p.studentId
		,s.FIO
		,p.achievement
		,p.numberMark
from  mifi.Portfolio  p
		INNER JOIN mifi.StudentsView s on s.id = p.studentId

GO
/****** Object:  Table [mifi].[StudentGradeList]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[StudentGradeList](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[studentId] [bigint] NOT NULL,
	[lessonId] [bigint] NOT NULL,
	[teacherId] [bigint] NOT NULL,
	[created] [datetime] NOT NULL,
	[points] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_StudentGradeList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [mifi].[StudentGradeListView]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [mifi].[StudentGradeListView]
as
SELECT  sgl.id
		,sgl.studentId
		,s.FIO AS studentFIO
		,sgl.lessonId
		,l.name
		,sgl.teacherId
		,t.FIO AS teacherFIO
		,sgl.created
		,sgl.points
from  mifi.StudentGradeList  sgl
		INNER JOIN mifi.StudentsView s on s.id = sgl.studentId
		INNER JOIN mifi.Lessons l on l.id = sgl.lessonId
		INNER JOIN mifi.TeachersView t on t.id = sgl.teacherId
GO
/****** Object:  UserDefinedFunction [util].[SplitString]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
	Функция делит строку @line на несколько, разделитель передается в качестве второго параметра
	
	Пример использования:
	select *
	from util.SplitString('Hello;World',';')
	option (maxrecursion 0)
	
	Без option (maxrecursion 0) получает только первые 100 частей
*/
CREATE function [util].[SplitString] (
	@line varchar(max),
	@delimiter char(1)
)
returns table
as
return 
(
	with Pieces(pieceNumber, start, stop) as
	(
		select convert(bigint,1), convert(bigint,1), charindex(@delimiter, @line)
		union all
		select pieceNumber + 1, stop + 1, charindex(@delimiter, @line, stop + 1)
		from Pieces
		where stop > 0
	)
	select pieceNumber,
		   substring(@line, start, case when stop > 0 then stop-start else 2147483647 end) piece
	from Pieces
)

GO
/****** Object:  Table [mifi].[CorpsContent]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[CorpsContent](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[corpsId] [bigint] NOT NULL,
	[classRoomId] [bigint] NOT NULL,
 CONSTRAINT [PK_CorpsContent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mifi].[TimeTableReesterRecords]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mifi].[TimeTableReesterRecords](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[reesterId] [bigint] NOT NULL,
	[created] [datetime] NOT NULL,
	[weekNumber] [varchar](255) NULL,
	[groupId] [bigint] NULL,
	[dayOfWeekId] [bigint] NULL,
	[paraNumber] [varchar](1) NULL,
	[timeStart_1] [varchar](20) NULL,
	[timeEnd_1] [varchar](20) NULL,
	[timeStart_2] [varchar](20) NULL,
	[timeEnd_2] [varchar](20) NULL,
	[lessonId] [bigint] NULL,
	[lessonTypeId] [bigint] NULL,
	[teacherId] [bigint] NULL,
	[corpsId] [bigint] NULL,
	[classRoomId] [bigint] NULL,
	[apx] [varchar](max) NULL,
 CONSTRAINT [PK_TimeTableReesterRecords] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [mifi].[StudentGradeList] ADD  CONSTRAINT [DF_StudentGradeList_created]  DEFAULT (getdate()) FOR [created]
GO
ALTER TABLE [mifi].[StudentGradeList] ADD  CONSTRAINT [DF_StudentGradeList_pints]  DEFAULT ((0)) FOR [points]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] ADD  CONSTRAINT [DF_TimeTableReesterRecords_created]  DEFAULT (getdate()) FOR [created]
GO
ALTER TABLE [mifi].[TimeTableReesters] ADD  CONSTRAINT [DF_TimeTableReesters_created]  DEFAULT (getdate()) FOR [created]
GO
ALTER TABLE [mifi].[TimeTableReesters] ADD  CONSTRAINT [DF_TimeTableReesters_isCurrent]  DEFAULT ((0)) FOR [isCurrent]
GO
ALTER TABLE [mifi].[CorpsContent]  WITH CHECK ADD  CONSTRAINT [FK_CorpsContent_ClassRooms] FOREIGN KEY([corpsId])
REFERENCES [mifi].[ClassRooms] ([id])
GO
ALTER TABLE [mifi].[CorpsContent] CHECK CONSTRAINT [FK_CorpsContent_ClassRooms]
GO
ALTER TABLE [mifi].[CorpsContent]  WITH CHECK ADD  CONSTRAINT [FK_CorpsContent_Corps] FOREIGN KEY([corpsId])
REFERENCES [mifi].[Corps] ([id])
GO
ALTER TABLE [mifi].[CorpsContent] CHECK CONSTRAINT [FK_CorpsContent_Corps]
GO
ALTER TABLE [mifi].[FacultyLessons]  WITH CHECK ADD  CONSTRAINT [FK_FacultyLessons_Faculties] FOREIGN KEY([facultyId])
REFERENCES [mifi].[Faculties] ([id])
GO
ALTER TABLE [mifi].[FacultyLessons] CHECK CONSTRAINT [FK_FacultyLessons_Faculties]
GO
ALTER TABLE [mifi].[FacultyLessons]  WITH CHECK ADD  CONSTRAINT [FK_FacultyLessons_Lessons] FOREIGN KEY([lessonId])
REFERENCES [mifi].[Lessons] ([id])
GO
ALTER TABLE [mifi].[FacultyLessons] CHECK CONSTRAINT [FK_FacultyLessons_Lessons]
GO
ALTER TABLE [mifi].[FacultyTeachers]  WITH CHECK ADD  CONSTRAINT [FK_FacultyTeachers_Faculties] FOREIGN KEY([facultyId])
REFERENCES [mifi].[Faculties] ([id])
GO
ALTER TABLE [mifi].[FacultyTeachers] CHECK CONSTRAINT [FK_FacultyTeachers_Faculties]
GO
ALTER TABLE [mifi].[FacultyTeachers]  WITH CHECK ADD  CONSTRAINT [FK_FacultyTeachers_Teachers] FOREIGN KEY([facultyId])
REFERENCES [mifi].[Teachers] ([id])
GO
ALTER TABLE [mifi].[FacultyTeachers] CHECK CONSTRAINT [FK_FacultyTeachers_Teachers]
GO
ALTER TABLE [mifi].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Courses] FOREIGN KEY([courseId])
REFERENCES [mifi].[Courses] ([id])
GO
ALTER TABLE [mifi].[Groups] CHECK CONSTRAINT [FK_Groups_Courses]
GO
ALTER TABLE [mifi].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Specialties] FOREIGN KEY([specialityId])
REFERENCES [mifi].[Specialties] ([id])
GO
ALTER TABLE [mifi].[Groups] CHECK CONSTRAINT [FK_Groups_Specialties]
GO
ALTER TABLE [mifi].[Portfolio]  WITH CHECK ADD  CONSTRAINT [FK_Portfolio_Students] FOREIGN KEY([studentId])
REFERENCES [mifi].[Students] ([id])
GO
ALTER TABLE [mifi].[Portfolio] CHECK CONSTRAINT [FK_Portfolio_Students]
GO
ALTER TABLE [mifi].[Specialties]  WITH CHECK ADD  CONSTRAINT [FK_Specialties_Faculties] FOREIGN KEY([facultyGroupId])
REFERENCES [mifi].[Faculties] ([id])
GO
ALTER TABLE [mifi].[Specialties] CHECK CONSTRAINT [FK_Specialties_Faculties]
GO
ALTER TABLE [mifi].[StudentGradeList]  WITH CHECK ADD  CONSTRAINT [FK_StudentGradeList_Lessons] FOREIGN KEY([lessonId])
REFERENCES [mifi].[Lessons] ([id])
GO
ALTER TABLE [mifi].[StudentGradeList] CHECK CONSTRAINT [FK_StudentGradeList_Lessons]
GO
ALTER TABLE [mifi].[StudentGradeList]  WITH CHECK ADD  CONSTRAINT [FK_StudentGradeList_Students] FOREIGN KEY([studentId])
REFERENCES [mifi].[Students] ([id])
GO
ALTER TABLE [mifi].[StudentGradeList] CHECK CONSTRAINT [FK_StudentGradeList_Students]
GO
ALTER TABLE [mifi].[StudentGradeList]  WITH CHECK ADD  CONSTRAINT [FK_StudentGradeList_Teachers] FOREIGN KEY([teacherId])
REFERENCES [mifi].[Teachers] ([id])
GO
ALTER TABLE [mifi].[StudentGradeList] CHECK CONSTRAINT [FK_StudentGradeList_Teachers]
GO
ALTER TABLE [mifi].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Courses] FOREIGN KEY([courseId])
REFERENCES [mifi].[Courses] ([id])
GO
ALTER TABLE [mifi].[Students] CHECK CONSTRAINT [FK_Students_Courses]
GO
ALTER TABLE [mifi].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Groups] FOREIGN KEY([groupId])
REFERENCES [mifi].[Groups] ([id])
GO
ALTER TABLE [mifi].[Students] CHECK CONSTRAINT [FK_Students_Groups]
GO
ALTER TABLE [mifi].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Specialties] FOREIGN KEY([specialityId])
REFERENCES [mifi].[Specialties] ([id])
GO
ALTER TABLE [mifi].[Students] CHECK CONSTRAINT [FK_Students_Specialties]
GO
ALTER TABLE [mifi].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Users] FOREIGN KEY([userId])
REFERENCES [mifi].[Users] ([id])
GO
ALTER TABLE [mifi].[Students] CHECK CONSTRAINT [FK_Students_Users]
GO
ALTER TABLE [mifi].[TeacherLessons]  WITH CHECK ADD  CONSTRAINT [FK_TeacherLessons_Lessons] FOREIGN KEY([lessonId])
REFERENCES [mifi].[Lessons] ([id])
GO
ALTER TABLE [mifi].[TeacherLessons] CHECK CONSTRAINT [FK_TeacherLessons_Lessons]
GO
ALTER TABLE [mifi].[TeacherLessons]  WITH CHECK ADD  CONSTRAINT [FK_TeacherLessons_Teachers] FOREIGN KEY([teacherId])
REFERENCES [mifi].[Teachers] ([id])
GO
ALTER TABLE [mifi].[TeacherLessons] CHECK CONSTRAINT [FK_TeacherLessons_Teachers]
GO
ALTER TABLE [mifi].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Users] FOREIGN KEY([userId])
REFERENCES [mifi].[Users] ([id])
GO
ALTER TABLE [mifi].[Teachers] CHECK CONSTRAINT [FK_Teachers_Users]
GO
ALTER TABLE [mifi].[TimeTable]  WITH CHECK ADD  CONSTRAINT [FK_TimeTable_ClassRooms] FOREIGN KEY([classRoomId])
REFERENCES [mifi].[ClassRooms] ([id])
GO
ALTER TABLE [mifi].[TimeTable] CHECK CONSTRAINT [FK_TimeTable_ClassRooms]
GO
ALTER TABLE [mifi].[TimeTable]  WITH CHECK ADD  CONSTRAINT [FK_TimeTable_Corps] FOREIGN KEY([corpsId])
REFERENCES [mifi].[Corps] ([id])
GO
ALTER TABLE [mifi].[TimeTable] CHECK CONSTRAINT [FK_TimeTable_Corps]
GO
ALTER TABLE [mifi].[TimeTable]  WITH CHECK ADD  CONSTRAINT [FK_TimeTable_DaysOfWeeks] FOREIGN KEY([dayOfWeekId])
REFERENCES [mifi].[DaysOfWeeks] ([id])
GO
ALTER TABLE [mifi].[TimeTable] CHECK CONSTRAINT [FK_TimeTable_DaysOfWeeks]
GO
ALTER TABLE [mifi].[TimeTable]  WITH CHECK ADD  CONSTRAINT [FK_TimeTable_Groups] FOREIGN KEY([groupId])
REFERENCES [mifi].[Groups] ([id])
GO
ALTER TABLE [mifi].[TimeTable] CHECK CONSTRAINT [FK_TimeTable_Groups]
GO
ALTER TABLE [mifi].[TimeTable]  WITH CHECK ADD  CONSTRAINT [FK_TimeTable_Lessons] FOREIGN KEY([lessonId])
REFERENCES [mifi].[Lessons] ([id])
GO
ALTER TABLE [mifi].[TimeTable] CHECK CONSTRAINT [FK_TimeTable_Lessons]
GO
ALTER TABLE [mifi].[TimeTable]  WITH CHECK ADD  CONSTRAINT [FK_TimeTable_LessonsTypes] FOREIGN KEY([lessonTypeId])
REFERENCES [mifi].[LessonsTypes] ([id])
GO
ALTER TABLE [mifi].[TimeTable] CHECK CONSTRAINT [FK_TimeTable_LessonsTypes]
GO
ALTER TABLE [mifi].[TimeTable]  WITH CHECK ADD  CONSTRAINT [FK_TimeTable_Teachers] FOREIGN KEY([teacherId])
REFERENCES [mifi].[Teachers] ([id])
GO
ALTER TABLE [mifi].[TimeTable] CHECK CONSTRAINT [FK_TimeTable_Teachers]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesterRecords_ClassRooms] FOREIGN KEY([classRoomId])
REFERENCES [mifi].[ClassRooms] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] CHECK CONSTRAINT [FK_TimeTableReesterRecords_ClassRooms]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesterRecords_Corps] FOREIGN KEY([corpsId])
REFERENCES [mifi].[Corps] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] CHECK CONSTRAINT [FK_TimeTableReesterRecords_Corps]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesterRecords_DaysOfWeeks] FOREIGN KEY([dayOfWeekId])
REFERENCES [mifi].[DaysOfWeeks] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] CHECK CONSTRAINT [FK_TimeTableReesterRecords_DaysOfWeeks]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesterRecords_Groups] FOREIGN KEY([groupId])
REFERENCES [mifi].[Groups] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] CHECK CONSTRAINT [FK_TimeTableReesterRecords_Groups]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesterRecords_Lessons] FOREIGN KEY([lessonId])
REFERENCES [mifi].[Lessons] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] CHECK CONSTRAINT [FK_TimeTableReesterRecords_Lessons]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesterRecords_LessonsTypes] FOREIGN KEY([lessonTypeId])
REFERENCES [mifi].[LessonsTypes] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] CHECK CONSTRAINT [FK_TimeTableReesterRecords_LessonsTypes]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesterRecords_Teachers] FOREIGN KEY([teacherId])
REFERENCES [mifi].[Teachers] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] CHECK CONSTRAINT [FK_TimeTableReesterRecords_Teachers]
GO
ALTER TABLE [mifi].[TimeTableReesterRecords]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesterRecords_TimeTableReesters] FOREIGN KEY([reesterId])
REFERENCES [mifi].[TimeTableReesters] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesterRecords] CHECK CONSTRAINT [FK_TimeTableReesterRecords_TimeTableReesters]
GO
ALTER TABLE [mifi].[TimeTableReesters]  WITH CHECK ADD  CONSTRAINT [FK_TimeTableReesters_Users] FOREIGN KEY([userId])
REFERENCES [mifi].[Users] ([id])
GO
ALTER TABLE [mifi].[TimeTableReesters] CHECK CONSTRAINT [FK_TimeTableReesters_Users]
GO
ALTER TABLE [mifi].[UserRights]  WITH CHECK ADD  CONSTRAINT [FK_UserRights_Rights] FOREIGN KEY([rightId])
REFERENCES [mifi].[Rights] ([id])
GO
ALTER TABLE [mifi].[UserRights] CHECK CONSTRAINT [FK_UserRights_Rights]
GO
ALTER TABLE [mifi].[UserRights]  WITH CHECK ADD  CONSTRAINT [FK_UserRights_Users] FOREIGN KEY([userId])
REFERENCES [mifi].[Users] ([id])
GO
ALTER TABLE [mifi].[UserRights] CHECK CONSTRAINT [FK_UserRights_Users]
GO
/****** Object:  StoredProcedure [mifi].[RegistryProcessingTimeTable]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [mifi].[RegistryProcessingTimeTable]
    @reesterId BIGINT
	,@errorMessage VARCHAR(MAX) OUTPUT
AS
BEGIN
    
	/*
		DECLARE @reesterId BIGINT = 4
	--*/
	
	begin transaction
	BEGIN TRY

		DECLARE @weekNumber varchar(255)
		DECLARE @groupId BIGINT
		DECLARE @groupName varchar(10)
		DECLARE @dayOfWeekId BIGINT
		DECLARE @dayOfWeekName varchar(15)
		DECLARE @paraNumber VARCHAR(1)
		DECLARE @timeStart_1 VARCHAR (20)
		DECLARE @timeEnd_1 VARCHAR (20)
		DECLARE @timeStart_2 VARCHAR (20)
		DECLARE @timeEnd_2 VARCHAR (20)
		DECLARE @lessonId BIGINT
		DECLARE @lessonName VARCHAR(255)
		DECLARE @lessonTypeId BIGINT
		DECLARE @lessonTypeName VARCHAR(255)
		DECLARE @teacherId BIGINT
		DECLARE @teacher VARCHAR(255)
		DECLARE @corpsId BIGINT
		DECLARE @corps VARCHAR(10)
		DECLARE @classRoomId BIGINT
		DECLARE @classRoom VARCHAR(10)

		DECLARE @reesterRecordId bigint;
		DECLARE my_cursor CURSOR FOR SELECT rr.id
									 FROM mifi.TimeTableReesterRecords rr
									 WHERE rr.reesterId = @reesterId
		OPEN my_cursor;

		FETCH NEXT FROM my_cursor
		INTO @reesterRecordId;

		WHILE @@FETCH_STATUS = 0
		BEGIN
		
			/*
				SELECT  @barcode = MAX(CASE WHEN ss.pieceNumber = 3 THEN ss.piece END) 
					   ,@account = MAX(CASE WHEN ss.pieceNumber = 4 THEN ss.piece END)
					   ,@preferredDraw = MAX(CASE WHEN ss.pieceNumber = 5 THEN ss.piece END)
				FROM	util.SplitString(@input,',') ss	
			*/

			--DECLARE @reesterRecordId BIGINT = 1
			DECLARE @apx varchar(max)
			DECLARE @timeStart varchar(20)
			DECLARE @timeEnd varchar(20)
			DECLARE @lessons VARCHAR(255)
			DECLARE @groupSpecialityName VARCHAR(10)
			DECLARE @groupCourseNumber VARCHAR(10)
	
			/*Забираем APX*/
			SELECT @apx = rr.apx 
			FROM mifi.TimeTableReesterRecords rr
			WHERE rr.id = @reesterRecordId;

			/*Делаем выборку из APX*/
			SELECT  @weekNumber = MAX(CASE WHEN ss.pieceNumber = 1 THEN ss.piece END)
					,@groupName = MAX(CASE WHEN ss.pieceNumber = 2 THEN ss.piece END)
					,@dayOfWeekName = MAX(CASE WHEN ss.pieceNumber = 3 THEN ss.piece END)
					,@paraNumber = MAX(CASE WHEN ss.pieceNumber = 4 THEN ss.piece END)
					,@timeStart = MAX(CASE WHEN ss.pieceNumber = 5 THEN ss.piece END)
					,@timeEnd = MAX(CASE WHEN ss.pieceNumber = 6 THEN ss.piece END)
					,@lessons = MAX(CASE WHEN ss.pieceNumber = 7 THEN ss.piece END)
			FROM util.SplitString(@apx,';') ss

			/*Получаем начало и конец первой половины пары*/
			SELECT @timeStart_1 =  MAX(CASE WHEN ss.pieceNumber = 1 THEN ss.piece END)
				  ,@timeEnd_1 =  MAX(CASE WHEN ss.pieceNumber = 2 THEN ss.piece END)
			FROM util.SplitString(@timeStart,'+') ss

			/*Получаем начало и конец второй половины пары*/
			SELECT @timeStart_2 =  MAX(CASE WHEN ss.pieceNumber = 1 THEN ss.piece END)
				  ,@timeEnd_2 =  MAX(CASE WHEN ss.pieceNumber = 2 THEN ss.piece END)
			FROM util.SplitString(@timeEnd,'+') ss

			/*Получаем иноформацию по паре*/
			SELECT   @lessonName = MAX(CASE WHEN ss.pieceNumber = 1 THEN ss.piece END)
					,@lessonTypeName = MAX(CASE WHEN ss.pieceNumber = 2 THEN ss.piece END)
					,@teacher = MAX(CASE WHEN ss.pieceNumber = 3 THEN ss.piece END)
					,@corps = MAX(CASE WHEN ss.pieceNumber = 4 THEN ss.piece END)
					,@classRoom = MAX(CASE WHEN ss.pieceNumber = 5 THEN ss.piece END)
			FROM util.SplitString(@lessons,'+') ss
		
			/*Проверка на существование группы*/
			SELECT @groupSpecialityName =  MAX(CASE WHEN ss.pieceNumber = 1 THEN ss.piece END)
				  ,@groupCourseNumber = MAX(CASE WHEN ss.pieceNumber = 2 THEN SUBSTRING(ss.piece,1,1) END)
			FROM util.SplitString(@groupName,'-') ss


			IF(@groupName IS NOT NULL and NOT EXISTS ( SELECT g.id 
													   FROM mifi.Groups g
													   WHERE g.name = @groupName))
			BEGIN
				INSERT mifi.Groups(name,specialityId,courseId)
				SELECT @groupName,s.id,COALESCE(cours.id,coursMg.id)
				FROM mifi.Specialties s
						OUTER APPLY (SELECT c.id 
									 FROM mifi.Courses c
									 WHERE c.name LIKE @groupCourseNumber+'%') cours
						OUTER APPLY (SELECT c.id 
									 FROM mifi.Courses c
									 WHERE c.name = 'магистратура') coursMg
				WHERE s.shortName = @groupSpecialityName
			END

			/*Проверка на существование пердмета*/
			IF(@lessonName IS NOT NULL and NOT EXISTS (SELECT l.id
													   FROM mifi.Lessons l
													   WHERE l.name = @lessonName))
			BEGIN
				INSERT mifi.Lessons (name)
				VALUES(@lessonName)
			END

			/*Проверка на существование типа предмета*/
			IF(@lessonTypeName IS NOT NULL AND NOT EXISTS (SELECT lt.id 
														   FROM mifi.LessonsTypes lt
														   WHERE lt.shortName = @lessonTypeName))
			BEGIN
				INSERT mifi.LessonsTypes(name,shortName)
				VALUES('',@lessonTypeName)
			END

			/*Проверка на существование корпуса*/
			IF(@corps IS NOT NULL AND NOT EXISTS (SELECT c.id 
												   FROM mifi.Corps c
												   WHERE c.name = @corps))
			BEGIN
				INSERT mifi.Corps(name)
				VALUES(@corps)

				SET @corpsId = scope_identity()
			END
        
			/*Проверка на существование классной комнаты*/
			IF(@classRoom IS NOT NULL AND NOT EXISTS (SELECT cr.id 
													   FROM mifi.ClassRooms cr
													   WHERE cr.name = @classRoom))
			BEGIN
				INSERT mifi.ClassRooms(name)
				VALUES(@classRoom)

				SET @classRoomId = scope_identity()
			END
		

			--/*Проверка на существование связки корпус-классная комната*/
			--IF(@corpsId IS NOT NULL AND 
			--   @classRoomId IS NOT NULL AND 
			--  NOT EXISTS (SELECT cc.id 
			--			   FROM mifi.CorpsContent cc
			--			   WHERE cc.corpsId = @corpsId AND 
			--					 cc.classRoomId = @classRoomId))
			--BEGIN
			--	INSERT mifi.CorpsContent(corpsId,classRoomId)
			--	VALUES(@corpsId,@classRoomId)
			--END
					
			UPDATE rr
			SET rr.weekNumber = @weekNumber
			   ,rr.groupId = g.id
			   ,rr.dayOfWeekId = dayWeek.id
			   ,rr.paraNumber = @paraNumber
			   ,rr.timeStart_1 = @timeStart_1
			   ,rr.timeEnd_1 = @timeEnd_1
			   ,rr.timeStart_2 = @timeStart_2
			   ,rr.timeEnd_2 = @timeEnd_2
			   ,rr.lessonId = l.id
			   ,rr.lessonTypeId = lt.id
			   ,rr.teacherId = tch.id
			   ,rr.corpsId = corp.id
			   ,rr.classRoomId = classR.id
			FROM mifi.TimeTableReesterRecords rr
					OUTER APPLY(SELECT id FROM mifi.Groups WHERE name = @groupName) g
					OUTER APPLY(SELECT id FROM mifi.DaysOfWeeks WHERE name = @dayOfWeekName) dayWeek
					OUTER APPLY(SELECT id FROM mifi.Lessons WHERE name = @lessonName) l
					OUTER APPLY(SELECT id FROM mifi.LessonsTypes WHERE shortName = @lessonTypeName) lt
					OUTER APPLY(SELECT id FROM mifi.Teachers WHERE lastName = @teacher) tch
					OUTER APPLY(SELECT id FROM mifi.Corps WHERE name = @corps) corp
					OUTER APPLY(SELECT id FROM mifi.ClassRooms WHERE name = @classRoom) classR
			WHERE rr.id = @reesterRecordId

		FETCH NEXT FROM my_cursor
				INTO @reesterRecordId;
		end

		CLOSE my_cursor;
		DEALLOCATE my_cursor;

	COMMIT TRANSACTION;
	END TRY  		
	BEGIN CATCH  
				SELECT  @errorMessage = ERROR_MESSAGE() + CHAR(13) + CHAR(10) + 'Ошибка загрузки расписания!';
				ROLLBACK TRANSACTION; 
	END CATCH    

END
GO
/****** Object:  StoredProcedure [mifi].[UpdateTimeTable]    Script Date: 11.12.2021 7:43:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [mifi].[UpdateTimeTable]
    @reesterId AS INT
AS
BEGIN
	--DECLARE @reesterId BIGINT = 5
	
	/*Чистим таблицу*/
	DELETE FROM mifi.TimeTable

	/*Заносим данные*/
	INSERT mifi.TimeTable(weekNumber,groupId,dayOfWeekId,paraNumber,timeStart_1,timeEnd_1,
						  timeStart_2,timeEnd_2,lessonId,lessonTypeId,teacherId,corpsId,classRoomId)
	SELECT ttr.weekNumber,
           ttr.groupId,
           ttr.dayOfWeekId,
           ttr.paraNumber,
           ttr.timeStart_1,
           ttr.timeEnd_1,
           ttr.timeStart_2,
           ttr.timeEnd_2,
           ttr.lessonId,
           ttr.lessonTypeId,
           ttr.teacherId,
           ttr.corpsId,
           ttr.classRoomId 
	FROM mifi.TimeTableReesterRecords ttr
	WHERE ttr.reesterId = @reesterId

END
GO
USE [master]
GO
ALTER DATABASE [XakatonBD] SET  READ_WRITE 
GO
