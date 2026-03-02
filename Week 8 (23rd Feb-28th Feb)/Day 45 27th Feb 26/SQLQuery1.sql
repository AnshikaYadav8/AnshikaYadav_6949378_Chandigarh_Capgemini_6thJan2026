create database UniversityDB;
use UniversityDB;

CREATE TABLE Departments (
    DeptId INT PRIMARY KEY IDENTITY(1,1),
    DeptName NVARCHAR(100) NOT NULL
);

CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    DeptId INT NOT NULL,
    CONSTRAINT FK_Courses_Departments
        FOREIGN KEY (DeptId)
        REFERENCES Departments(DeptId)
);

CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    DeptId INT NOT NULL,
    CONSTRAINT FK_Students_Departments
        FOREIGN KEY (DeptId)
        REFERENCES Departments(DeptId)
);

CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL,
    CourseId INT NOT NULL,
    Grade CHAR(2),

    CONSTRAINT FK_Enrollments_Students
        FOREIGN KEY (StudentId)
        REFERENCES Students(StudentId),

    CONSTRAINT FK_Enrollments_Courses
        FOREIGN KEY (CourseId)
        REFERENCES Courses(CourseId)
);

-- Departments
INSERT INTO Departments (DeptName)
VALUES ('Computer Science'),
       ('Mathematics'),
       ('Physics');

-- Courses
INSERT INTO Courses (CourseName, DeptId)
VALUES ('Data Structures', 1),
       ('Algorithms', 1),
       ('Linear Algebra', 2),
       ('Quantum Mechanics', 3);

-- Students
INSERT INTO Students (FirstName, LastName, Email, DeptId)
VALUES ('Alice', 'Johnson', 'alice@uni.com', 1),
       ('Bob', 'Smith', 'bob@uni.com', 2),
       ('Charlie', 'Brown', 'charlie@uni.com', 3);

-- Enrollments
INSERT INTO Enrollments (StudentId, CourseId, Grade)
VALUES (1, 1, 'A'),
       (1, 2, 'B'),
       (2, 3, 'A'),
       (3, 4, 'C');

CREATE PROCEDURE sp_InsertStudent
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @DeptId INT
AS
BEGIN
    INSERT INTO Students (FirstName, LastName, Email, DeptId)
    VALUES (@FirstName, @LastName, @Email, @DeptId);
END;

CREATE PROCEDURE sp_UpdateStudent
    @StudentId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @DeptId INT
AS
BEGIN
    UPDATE Students
    SET FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        DeptId = @DeptId
    WHERE StudentId = @StudentId;
END;

CREATE PROCEDURE sp_DeleteStudent
    @StudentId INT
AS
BEGIN
    DELETE FROM Students
    WHERE StudentId = @StudentId;
END;

CREATE PROCEDURE sp_GetAllStudents
AS
BEGIN
    SELECT * FROM Students;
END;

CREATE PROCEDURE sp_GetStudentById
    @StudentId INT
AS
BEGIN
    SELECT * FROM Students
    WHERE StudentId = @StudentId;
END;

EXEC sp_GetAllStudents;

EXEC sp_GetStudentById @StudentId = 1;

EXEC sp_UpdateStudent
    @StudentId = 1,
    @FirstName = 'Alice',
    @LastName = 'Johnson',
    @Email = 'alice_new@uni.com',
    @DeptId = 2;

DELETE FROM Enrollments WHERE StudentId = 3;
EXEC sp_DeleteStudent 3;