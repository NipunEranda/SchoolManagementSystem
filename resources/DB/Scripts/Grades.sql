USE [sms]
GO

/****** Object:  Table [dbo].[Grades]    Script Date: 8/25/2019 2:32:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Grades](
	[gradeId] [int] NOT NULL,
	[sectionId] [int] NULL,
	[gradeName] [char](2) NULL,
	[status] [tinyint] NULL,
 CONSTRAINT [grades_pk] PRIMARY KEY CLUSTERED 
(
	[gradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Grades]  WITH CHECK ADD  CONSTRAINT [grades_fk] FOREIGN KEY([sectionId])
REFERENCES [dbo].[sections] ([sectionId])
GO

ALTER TABLE [dbo].[Grades] CHECK CONSTRAINT [grades_fk]
GO

