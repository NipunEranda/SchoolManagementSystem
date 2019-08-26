USE [sms]
GO

/****** Object:  Table [dbo].[users]    Script Date: 8/25/2019 2:33:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[users](
	[id] [int] NOT NULL,
	[userName] [varchar](50) NULL DEFAULT (NULL),
	[password] [varchar](50) NULL DEFAULT (NULL),
	[roleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [users_fk] FOREIGN KEY([roleId])
REFERENCES [dbo].[roles] ([roleId])
GO

ALTER TABLE [dbo].[users] CHECK CONSTRAINT [users_fk]
GO

