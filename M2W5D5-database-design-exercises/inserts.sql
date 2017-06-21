BEGIN TRANSACTION
INSERT INTO employee(employee_num,job_title, last_name, first_name, gender, birthday, hiredate)
VALUES (1, 'Project Manager', 'Freddy', 'Emery', 'Male', '10-25-1981', '09-10-2010');

INSERT INTO employee(employee_num, job_title, last_name, first_name, gender, birthday, hiredate)
VALUES (2, 'Lead Accountant', 'Freddy', 'Mackamore', 'Male', '05-21-1984', '12-01-2009');

INSERT INTO employee(employee_num, job_title, last_name, first_name, gender, birthday, hiredate)
VALUES (3, 'Business Analyst ', 'Dan', 'Bro', 'Male', '08-22-1987', '07-18-2010');

INSERT INTO employee(employee_num, job_title, last_name, first_name, gender, birthday, hiredate)
VALUES (4, 'Sr. Business Analyst', 'Alex', 'Ludwick', 'Male', '10-25-1981', '09-12-2012');

INSERT INTO employee(employee_num, job_title, last_name, first_name, gender, birthday, hiredate)
VALUES (5, 'InfoSec Anaylst', 'Ahmed', 'Miller', 'Male', '12-31-1987', '09-10-2010');

INSERT INTO employee(employee_num, job_title, last_name, first_name, gender, birthday, hiredate)
VALUES (6, 'App Developer', 'Andrea', 'Flick', 'Female', '02-25-1980', '10-10-2010');

INSERT INTO employee(employee_num, job_title, last_name, first_name, gender, birthday, hiredate)
VALUES (7, 'Graphic Designer', 'Noe', 'Bodi', 'Female', '11-25-1989', '09-11-2012');

INSERT INTO employee(employee_num, job_title, last_name, first_name, gender, birthday, hiredate)
VALUES (8, 'Project Manager', 'Alice', 'Wanderlae', 'Female', '10-25-1987', '09-01-2015');

COMMIT TRANSACTION

BEGIN TRANSACTION

INSERT INTO department(department_num, name)
VALUES (1, 'Finance');

INSERT INTO department(department_num, name)
VALUES (2, 'App Development');

INSERT INTO department(department_num, name)
VALUES (3, 'Business Strategy');

COMMIT TRANSACTION

BEGIN TRANSACTION 

INSERT INTO project(project_num, name, startdate)
VALUES (1, 'Project Argo', '10-20-2010');

INSERT INTO project(project_num, name, startdate)
VALUES (2, 'Project Beta', '08-20-2011');

INSERT INTO project(project_num, name, startdate)
VALUES (3, 'Project Ocean', '09-15-2012');

INSERT INTO project(project_num, name, startdate)
VALUES(4, 'Project Mantis', '05-10-2016');

COMMIT TRANSACTION

BEGIN TRANSACTION

INSERT INTO employee_department(department_num, employee_num)
VALUES (1,1)

INSERT INTO employee_department(department_num, employee_num)
VALUES (1,2)

INSERT INTO employee_department(department_num, employee_num)
VALUES (2,6)

INSERT INTO employee_department(department_num, employee_num)
VALUES (2,5)

INSERT INTO employee_department(department_num, employee_num)
VALUES (2,7)

INSERT INTO employee_department(department_num, employee_num)
VALUES (3,3)

INSERT INTO employee_department(department_num, employee_num)
VALUES (3,4)

INSERT INTO employee_department(department_num, employee_num)
VALUES (3,8)

COMMIT TRANSACTION

BEGIN TRANSACTION

INSERT INTO employee_project(employee_num, project_num)
VALUES (1, 1)

INSERT INTO employee_project(employee_num, project_num)
VALUES (2, 1)

INSERT INTO employee_project(employee_num, project_num)
VALUES (3, 2)

INSERT INTO employee_project(employee_num, project_num)
VALUES (4, 2)

INSERT INTO employee_project(employee_num, project_num)
VALUES (5, 3)

INSERT INTO employee_project(employee_num, project_num)
VALUES (6, 3)

INSERT INTO employee_project(employee_num, project_num)
VALUES (7, 4)

INSERT INTO employee_project(employee_num, project_num)
VALUES (8, 4)

COMMIT TRANSACTION


