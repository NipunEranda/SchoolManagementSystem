USE [sms]
GO

/****** Object:  Table [dbo].[privileges]    Script Date: 8/25/2019 2:32:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[privileges](
	[roleId] [int] NOT NULL,
	[studAdd] [tinyint] NULL,
	[studEdit] [tinyint] NULL,
	[studDelete] [tinyint] NULL,
 CONSTRAINT [privilleges_pk] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[privileges]  WITH CHECK ADD  CONSTRAINT [privilleges_fk] FOREIGN KEY([roleId])
REFERENCES [dbo].[roles] ([roleId])
GO

ALTER TABLE [dbo].[privileges] CHECK CONSTRAINT [privilleges_fk]
GO

