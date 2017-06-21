USE [ project_organizer]
GO

/****** Object:  Table [dbo].[project]    Script Date: 6/11/2017 1:53:25 PM ******/
DROP TABLE [dbo].[project]
GO

/****** Object:  Table [dbo].[project]    Script Date: 6/11/2017 1:53:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[project](
	[project_num] [int] NOT NULL,
	[name] [nchar](30) NULL,
	[startdate] [date] NULL

	CONSTRAINT pk_project_num PRIMARY KEY (project_num)
) ON [PRIMARY]

GO


