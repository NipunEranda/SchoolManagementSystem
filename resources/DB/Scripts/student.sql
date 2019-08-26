USE [sms]
GO

/****** Object:  Table [dbo].[student]    Script Date: 8/25/2019 2:33:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[student](
	[sid] [bigint] NOT NULL,
	[nic] [varchar](20) NULL,
	[firstName] [varchar](20) NULL,
	[lastName] [varchar](20) NULL,
	[birthdate] [varchar](20) NULL,
	[address] [varchar](100) NULL,
	[telephone] [varchar](10) NULL,
	[gender] [tinyint] NULL,
	[image] [image] NULL,
	[gradeId] [int] NULL,
	[classId] [int] NULL,
 CONSTRAINT [student_pk] PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

