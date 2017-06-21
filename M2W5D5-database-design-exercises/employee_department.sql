USE [ project_organizer]
GO

/****** Object:  Table [dbo].[employee_department]    Script Date: 6/11/2017 1:38:36 PM ******/
DROP TABLE [dbo].[employee_department]
GO

/****** Object:  Table [dbo].[employee_department]    Script Date: 6/11/2017 1:38:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employee_department](
	[department_num] [int] NOT NULL,
	[employee_num] [int] NOT NULL

	CONSTRAINT pk_employee_department_num PRIMARY KEY (employee_num),
	CONSTRAINT fk_department_employee_num FOREIGN KEY (department_num) REFERENCES department(department_num),
	CONSTRAINT fk_employee_department_num FOREIGN KEY (employee_num) REFERENCES employee(employee_num)
) ON [PRIMARY]

GO


