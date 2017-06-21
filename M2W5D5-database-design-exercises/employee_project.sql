USE [ project_organizer]
GO

/****** Object:  Table [dbo].[employee_project]    Script Date: 6/11/2017 1:55:27 PM ******/
DROP TABLE [dbo].[employee_project]
GO

/****** Object:  Table [dbo].[employee_project]    Script Date: 6/11/2017 1:55:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employee_project](
	[employee_num] [int] NOT NULL,
	[project_num] [int] NOT NULL

	CONSTRAINT pk_employee_project_num PRIMARY KEY (employee_num),
	CONSTRAINT fk_employee_project_num FOREIGN KEY (employee_num) REFERENCES employee(employee_num),
	CONSTRAINT fk_project_employee_num FOREIGN KEY (project_num) REFERENCES project(project_num)

) ON [PRIMARY]

GO


