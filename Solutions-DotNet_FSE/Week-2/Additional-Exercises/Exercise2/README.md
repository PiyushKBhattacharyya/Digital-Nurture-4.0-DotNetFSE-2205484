# Scalar Functions
## Objective
This assignment demonstrates how to create and use a scalar function in SQL Server
---
## Database Schema Overview

```sql
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10, 2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
```
---
## Sample Data
```sql
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Bob', 'Johnson', 3, 5500.00, '2021-07-01');
```
---
## Exercise
### Scalar Function Creation
*Goal:* Create a function to calculate annual salary of an employee.
```sql
CREATE FUNCTION fn_CalculateAnnualSalary (@EmpID INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @AnnualSalary DECIMAL(10,2);

    SELECT @AnnualSalary = Salary * 12
    FROM Employees
    WHERE EmployeeID = @EmpID;

    RETURN @AnnualSalary;
END;
```

### Calling the Function
```sql
SELECT dbo.fn_CalculateAnnualSalary(1) AS AnnualSalary;
```
---
## Summary of Indexes

| Object Type             | Name   | Purpose              
|--------------------|------------|----------------------------|
| Scalar Function     | fn_CalculateAnnualSalary   | Calculates annual salary for given EmployeeID                |
| Input Parameter          | @EmpID(INT)     | Employee identifier                  |
| Return Type   | DECIMAL(10,2)     | Annual salary      | 
---