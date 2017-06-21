USE [ project_organizer]
GO

/****** Object:  Table [dbo].[employee]    Script Date: 6/11/2017 1:21:48 PM ******/
DROP TABLE [dbo].[employee]
GO

/****** Object:  Table [dbo].[employee]    Script Date: 6/11/2017 1:21:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employee](
	[employee_num] [int] NOT NULL,
	[job_title] [nchar](20) NULL,
	[last_name] [nchar](30) NULL,
	[first_name] [nchar](30) NULL,
	[gender] [nchar](10) NULL,
	[birthday] [date] NULL,
	[hiredate] [date] NOT NULL,
	[department_num] [int] NULL

	CONSTRAINT pk_employee_num PRIMARY KEY (employee_num)
	--CONSTRAINT fk_emailContactId FOREIGN KEY (department_num) REFERENCES department(department_num)
) ON [PRIMARY]

GO


