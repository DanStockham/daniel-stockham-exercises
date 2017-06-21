USE [ project_organizer]
GO

/****** Object:  Table [dbo].[department]    Script Date: 6/11/2017 1:26:36 PM ******/
DROP TABLE [dbo].[department]
GO

/****** Object:  Table [dbo].[department]    Script Date: 6/11/2017 1:26:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[department](
	[department_num] [int] NOT NULL,
	[name] [nchar](20) NOT NULL,

	CONSTRAINT pk_department_num PRIMARY KEY (department_num)
) ON [PRIMARY]

GO


