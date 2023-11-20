Create Database [StudentsDB]
GO

USE [StudentsDB]
GO

Create Table [dbo].[Student](
    [StudentId]     INT        IDENTITY (1, 1) NOT NULL,
    [Name]       NCHAR (20) NOT NULL,
     CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([StudentId] ASC)
);
GO

Create Table [dbo].[StudentGrade](
    [GradeId]  INT        IDENTITY (1, 1) NOT NULL,
    [StudentId]      NCHAR (20) NOT NULL,
    [Score] INT        NOT NULL,
    CONSTRAINT [PK_StuedntGrade] PRIMARY KEY CLUSTERED ([GradeId] ASC),
    CONSTRAINT [PK_StuedntGrade] Foreign KEY ([StudentId]) references [dbo].[Student].[StudentId]
);
GO