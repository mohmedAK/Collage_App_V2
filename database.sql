USE [master]
GO
/****** Object:  Database [collage]    Script Date: 5/11/2021 1:04:32 AM ******/
CREATE DATABASE [collage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'collage', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SALES_DEV\MSSQL\DATA\collage.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'collage_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SALES_DEV\MSSQL\DATA\collage_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [collage] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [collage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [collage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [collage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [collage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [collage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [collage] SET ARITHABORT OFF 
GO
ALTER DATABASE [collage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [collage] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [collage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [collage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [collage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [collage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [collage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [collage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [collage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [collage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [collage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [collage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [collage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [collage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [collage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [collage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [collage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [collage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [collage] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [collage] SET  MULTI_USER 
GO
ALTER DATABASE [collage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [collage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [collage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [collage] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [collage]
GO
/****** Object:  StoredProcedure [dbo].[SP_AddSubject]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_AddSubject]

 @teacher nvarchar(50),
           @subject_name nvarchar(50),
           @noLecture int,
           @step int
as
begin
INSERT INTO [dbo].[TB_Subject]
           (
           [teacher]
           ,[subject_name]
           ,[noLecture]
           ,[step])
     VALUES
           ( 
           @teacher,
           @subject_name,
           @noLecture,
           @step)
end



GO
/****** Object:  StoredProcedure [dbo].[SP_AddSubjectAndScore]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_AddSubjectAndScore]

@id_Student int,
           @subject_name nvarchar(50),
           @absence int,
           @term1 real,
           @term2 real,
           @final real
as

begin
INSERT INTO [dbo].[TB_Score]
           ([id_Student]
           ,[subject_name]
           ,[absence]
           ,[term1]
           ,[term2]
           ,[final])
     VALUES
           (@id_Student, 
           @subject_name,
           @absence, 
           @term1, 
           @term2,
           @final )
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteAbsence]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DeleteAbsence]
@id_Absence int

as

begin
DELETE FROM [dbo].[TB_Absence]
      WHERE id_Absence= @id_Absence
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteMoneyRecord]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_DeleteMoneyRecord]
@id_Mony int 
as
begin
DELETE FROM [dbo].[TB_Mony]
      WHERE id_Mony =@id_Mony
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteOneScoreFromStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DeleteOneScoreFromStudent]

@id_Score int
as
begin
DELETE FROM [dbo].[TB_Score]
      WHERE id_Score =@id_Score
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DeleteStudent]
@id_Student int
as
begin

DELETE FROM [dbo].[TB_Student]
      WHERE id_Student =@id_Student
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteSubjectFromAllStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DeleteSubjectFromAllStudent]
@subject_name nvarchar(50)
as

begin
DELETE FROM [dbo].[TB_Score]
      WHERE subject_name = @subject_name
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteSubjectOnly]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DeleteSubjectOnly]
@subject_name nvarchar(50)
as

begin
DELETE FROM [dbo].[TB_Subject]
      WHERE subject_name = @subject_name
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteUser]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_DeleteUser]
@id_User int
as

begin
DELETE FROM [dbo].[TB_User]
      WHERE id_User =@id_User
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DisplayAllStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_DisplayAllStudent]

as
begin
SELECT [id_Student]
      ,[name]
      ,[gender]
      ,[age]
      ,[department]
      ,[step]
      ,[type_study]
      ,[total_amount]
      ,[discount]
  FROM [dbo].[TB_Student] 
 
end



GO
/****** Object:  StoredProcedure [dbo].[SP_EditMoneyRecord]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[SP_EditMoneyRecord]

@id_Mony int,
@batch real,
@dateRecord datetime
as
begin

UPDATE [dbo].[TB_Mony]
   SET 
       [batch] = @batch
      ,[dateRecord] = @dateRecord
 WHERE id_Mony = @id_Mony
end



GO
/****** Object:  StoredProcedure [dbo].[SP_EditScore]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_EditScore]

@id_Score int,     

           @term1 real,
           @term2 real,
		   @average real,
           @final real
as

begin
UPDATE [dbo].[TB_Score]
   SET  
       
      [term1] = @term1
      ,[term2] = @term2
	  ,[average] =@average
      ,[final] = @final
 WHERE id_Score = @id_Score 
end




GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllAbsence]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_GetAllAbsence]

@id_Student int 
as
begin

SELECT [id_Score]
      ,[id_Student]
      ,[subject_name]
      ,[absence]
       
  FROM [dbo].[TB_Score] where id_Student = @id_Student
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllScoreForOneStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_GetAllScoreForOneStudent]
@id_Student int
as
begin
SELECT [id_Score]
      ,[id_Student]
      ,[subject_name]
      ,[term1]
      ,[term2]
	  ,[average]
      ,[final]
  FROM [dbo].[TB_Score]
  where id_Student =@id_Student
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_GetAllStudent]

as
begin

SELECT [id_Student]
      ,[name]
      ,[gender]
      ,[age]
      ,[department]
      ,[step]
      ,[type_study]
      ,[total_amount]
      ,[discount]
  FROM [dbo].[TB_Student]
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllSubject]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[SP_GetAllSubject]
 
as

begin
SELECT [id_Subject]
      ,[teacher]
      ,[subject_name]
      ,[noLecture]
      ,[step]
  FROM [dbo].[TB_Subject]
 
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllSubjectScore]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_GetAllSubjectScore]

as

begin
 select * from dbo.TB_Score
 /*WHERE id_Student = @id_Student And subject_name = @subject_name*/
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetLastIDStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_GetLastIDStudent]

as

begin

select * from dbo.TB_Student where dbo.TB_Student.id_Student in(select max( dbo.TB_Student.id_Student) from dbo.TB_Student )

end
GO
/****** Object:  StoredProcedure [dbo].[SP_GetMoneyRecordById]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[SP_GetMoneyRecordById]
@id_Mony int
as
begin
SELECT [id_Mony]
      ,[id_Student]
      ,[batch]
      ,[dateRecord]
  FROM [dbo].[TB_Mony]
  where id_Mony =@id_Mony
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetMoneyRecords]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_GetMoneyRecords]

as
begin
SELECT [id_Mony]
      ,[id_Student]
      ,[batch]
      ,[dateRecord]
  FROM [dbo].[TB_Mony]
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetMonyRecordForStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_GetMonyRecordForStudent]

@id_Student int
as
begin

SELECT [id_Mony]
      ,[id_Student]
      ,[batch]
      ,[dateRecord]
  FROM [dbo].[TB_Mony]
  where id_Student =@id_Student
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetSingleStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_GetSingleStudent]

@id_Student int
as
begin
SELECT [id_Student]
      ,[name]
      ,[gender]
      ,[age]
      ,[department]
      ,[step]
      ,[type_study]
      ,[total_amount]
      ,[discount]
  FROM [dbo].[TB_Student] 
  where id_Student = @id_Student
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetStudentsByStep]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_GetStudentsByStep]

@step int
as
begin
SELECT [id_Student]
      ,[name]
      ,[gender]
      ,[age]
      ,[department]
      ,[step]
      ,[type_study]
      ,[total_amount]
      ,[discount]
  FROM [dbo].[TB_Student]
  Where step =@step
end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetStudentsNames]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_GetStudentsNames]
@subject_name nvarchar(50)
as
begin
select name ,id_Student from dbo.TB_Student where id_Student in (select id_Student from TB_Score where subject_name = @subject_name)

end
GO
/****** Object:  StoredProcedure [dbo].[SP_IncrementAbsence]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_IncrementAbsence]
@id_Student int,
@subject_name nvarchar(50)
 
as

begin
UPDATE [dbo].[TB_Score]
   SET  
       
      [absence] =  (select absence+1 from TB_Score where id_Student = @id_Student And subject_name = @subject_name) 
       
 WHERE id_Student = @id_Student And subject_name = @subject_name
end



GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertAbsence]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_InsertAbsence]

@absence_count int
           ,@date_absence datetime
           ,@id_Student int
as
begin
INSERT INTO [dbo].[TB_Absence]
           ([absence_count]
           ,[date_absence]
           ,[id_Student])
     VALUES
           (@absence_count
           ,@date_absence
           ,@id_Student)
end



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertMoneyRecord]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[SP_InsertMoneyRecord]

@id_Student int,
@batch real,
@dateRecord datetime
as
begin

INSERT INTO [dbo].[TB_Mony]
           ([id_Student]
           ,[batch]
           ,[dateRecord])
     VALUES
           (@id_Student
           ,@batch
           ,@dateRecord)
end



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertScore]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_InsertScore]

@id_Student int,
          @subject_name nvarchar(50),
           @term1 real,
           @term2 real,
		   @avarage real,
           @final real
as

begin
INSERT INTO [dbo].[TB_Score]
           ([id_Student]
           ,[subject_name]
           ,[term1]
           ,[term2]
		   ,[avarage]
           ,[final])
     VALUES
           (@id_Student,
           @subject_name, 
           @term1, 
           @term2,
		   @avarage,
           @final)
end



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertStudent]

		@id_Student int,
		@name nvarchar(50),
        @gender nvarchar(50),
           @age datetime,
           @department nvarchar(50),
           @step int,         
           @type_study nvarchar(50),
           @total_amount real,
           @discount real
as
begin

INSERT INTO [dbo].[TB_Student]
           ([id_Student]
           ,[name]
           ,[gender]
           ,[age]
           ,[department]
           ,[step]
           ,[type_study]
           ,[total_amount]
           ,[discount])
     VALUES
           (@id_Student
           ,@name 
           ,@gender 
           ,@age 
           ,@department
           ,@step         
           ,@type_study 
           ,@total_amount
           ,@discount )
end



GO
/****** Object:  StoredProcedure [dbo].[SP_InserUser]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_InserUser]

@username nvarchar(50)
           ,@password nvarchar(50)
           ,@type nvarchar(50)
as
begin
INSERT INTO [dbo].[TB_User]
           ([username]
           ,[password]
           ,[type])
     VALUES
           (@username
           ,@password
           ,@type)
end



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllUser]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_SelectAllUser]

as

begin
SELECT [id_User]
      ,[username]
      ,[password]
      ,[type]
  FROM [dbo].[TB_User]
end



GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateStudent]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_UpdateStudent]
		@id_Student int,
		@name nvarchar(50),
        @gender nvarchar(50),
           @age datetime,
           @department nvarchar(50),
           @step int,         
           @type_study nvarchar(50),
           @total_amount real,
           @discount real
as
		
begin
UPDATE [dbo].[TB_Student]
   SET 
      [name] = @name
      ,[gender] = @gender
      ,[age] = @age
      ,[department] = @department
      ,[step] = @step
      ,[type_study] = @type_study
      ,[total_amount] = @total_amount
      ,[discount] = @discount
 WHERE id_Student = @id_Student
end



GO
/****** Object:  Table [dbo].[TB_Absence]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Absence](
	[id_Absence] [int] IDENTITY(1,1) NOT NULL,
	[absence_count] [int] NULL,
	[date_absence] [datetime] NULL,
	[id_Student] [int] NULL,
 CONSTRAINT [PK_TB_Absence] PRIMARY KEY CLUSTERED 
(
	[id_Absence] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_Mony]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Mony](
	[id_Mony] [int] IDENTITY(1,1) NOT NULL,
	[id_Student] [int] NULL,
	[batch] [real] NULL,
	[dateRecord] [datetime] NULL,
 CONSTRAINT [PK_TB_Mony] PRIMARY KEY CLUSTERED 
(
	[id_Mony] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_Score]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Score](
	[id_Score] [int] IDENTITY(1,1) NOT NULL,
	[id_Student] [int] NULL,
	[subject_name] [nvarchar](50) NULL,
	[absence] [int] NULL,
	[term1] [real] NOT NULL,
	[term2] [real] NOT NULL,
	[average] [real] NULL,
	[final] [real] NOT NULL,
 CONSTRAINT [PK_TB_Score] PRIMARY KEY CLUSTERED 
(
	[id_Score] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_Student]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Student](
	[id_Student] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[age] [datetime] NULL,
	[department] [nvarchar](50) NULL,
	[step] [int] NULL,
	[type_study] [nvarchar](50) NULL,
	[total_amount] [real] NULL,
	[discount] [real] NULL,
 CONSTRAINT [PK_TB_Student] PRIMARY KEY CLUSTERED 
(
	[id_Student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_Subject]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Subject](
	[id_Subject] [int] IDENTITY(1,1) NOT NULL,
	[teacher] [nvarchar](50) NULL,
	[subject_name] [nvarchar](50) NULL,
	[noLecture] [int] NULL,
	[step] [int] NULL,
 CONSTRAINT [PK_TB_Subject] PRIMARY KEY CLUSTERED 
(
	[id_Subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_User]    Script Date: 5/11/2021 1:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_User](
	[id_User] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](max) NULL,
	[type] [nvarchar](50) NULL,
 CONSTRAINT [PK_TB_User] PRIMARY KEY CLUSTERED 
(
	[id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[TB_Absence]  WITH CHECK ADD  CONSTRAINT [FK_TB_Absence_TB_Student] FOREIGN KEY([id_Student])
REFERENCES [dbo].[TB_Student] ([id_Student])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TB_Absence] CHECK CONSTRAINT [FK_TB_Absence_TB_Student]
GO
ALTER TABLE [dbo].[TB_Mony]  WITH CHECK ADD  CONSTRAINT [FK_TB_Mony_TB_Student] FOREIGN KEY([id_Student])
REFERENCES [dbo].[TB_Student] ([id_Student])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TB_Mony] CHECK CONSTRAINT [FK_TB_Mony_TB_Student]
GO
ALTER TABLE [dbo].[TB_Score]  WITH CHECK ADD  CONSTRAINT [FK_TB_Score_TB_Student] FOREIGN KEY([id_Student])
REFERENCES [dbo].[TB_Student] ([id_Student])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TB_Score] CHECK CONSTRAINT [FK_TB_Score_TB_Student]
GO
USE [master]
GO
ALTER DATABASE [collage] SET  READ_WRITE 
GO
