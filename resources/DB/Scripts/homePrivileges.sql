USE [sms]
GO

/****** Object:  Table [dbo].[homePrivileges]    Script Date: 8/25/2019 2:32:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[homePrivileges](
	[roleId] [int] NOT NULL,
	[student] [tinyint] NULL,
	[staff] [tinyint] NULL,
	[classes] [tinyint] NULL,
	[courses] [tinyint] NULL,
	[timetables] [tinyint] NULL,
	[payments] [tinyint] NULL,
	[events] [tinyint] NULL,
	[library] [tinyint] NULL,
	[examinations] [tinyint] NULL,
	[inventory] [tinyint] NULL,
	[roles] [tinyint] NULL,
	[users] [tinyint] NULL,
 CONSTRAINT [homePrivilleges_pk] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[homePrivileges]  WITH CHECK ADD  CONSTRAINT [homePrivilleges_fk] FOREIGN KEY([roleId])
REFERENCES [dbo].[roles] ([roleId])
GO

ALTER TABLE [dbo].[homePrivileges] CHECK CONSTRAINT [homePrivilleges_fk]
GO

