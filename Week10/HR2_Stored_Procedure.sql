
use HR2

/* Query the employee first and last name and salary with highest salary in the company*/

CREATE PROCEDURE spHighSalary
AS
BEGIN
SELECT FIRST_NAME, LAST_NAME, SALARY FROM EMPLOYEES
where SALARY = (select max(SALARY) from EMPLOYEES)
END


/* Query the employee first and last name and salary with lowest salary in the company*/

CREATE PROCEDURE spLowSalary
AS
BEGIN
SELECT FIRST_NAME, LAST_NAME, SALARY FROM EMPLOYEES
where SALARY = (select min(SALARY) from EMPLOYEES)
END




/* Query the employees first and last names and their salaries of a user specified department*/

CREATE PROCEDURE spEmployeeSalary
@DEPARTMENT_NAME varchar(30)
AS
BEGIN
select FIRST_NAME, LAST_NAME, SALARY from EMPLOYEES
where DEPARTMENT_ID = (select DEPARTMENT_ID from DEPARTMENTS where DEPARTMENT_NAME like @DEPARTMENT_NAME)
end



