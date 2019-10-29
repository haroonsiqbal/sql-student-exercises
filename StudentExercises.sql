--Create Tables--
CREATE TABLE Cohort (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	CohortName VARCHAR(55) NOT NULL,
);

CREATE TABLE Instructor (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	InstFirstName VARCHAR(55) NOT NULL,
	InstLastName VARCHAR(55) NOT NULL,
	InstSlackHandle VARCHAR(55) NOT NULL,
	InstCohort INTEGER NOT NULL,
	InstSpeciality VARCHAR(55) NOT NULL
);

CREATE TABLE Student (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	StuFirstName VARCHAR(55) NOT NULL,
	StuLastName VARCHAR(55) NOT NULL,
	StuSlackHandle VARCHAR(55) NOT NULL,
	CohortId INTEGER NOT NULL,
	InstructorId INTEGER NOT NULL,
	CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id),
	CONSTRAINT FK_Student_Instructor FOREIGN KEY(InstructorId) REFERENCES Instructor(Id)
);


CREATE TABLE Exercise (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	ExerciseName VARCHAR(55) NOT NULL,
	ExerciseLang VARCHAR(55) NOT NULL,
	StudentId INTEGER NOT NULL,
	InstructorId INTEGER NOT NULL
	CONSTRAINT FK_Exercise_Student FOREIGN KEY(StudentId) REFERENCES Student(Id),
	CONSTRAINT FK_Exercise_Instructor FOREIGN KEY(InstructorId) REFERENCES Instructor(Id)

);

--Insert data into tables--
INSERT INTO Cohort (CohortName) VALUES ('Cohort 34');
INSERT INTO Cohort (CohortName) VALUES ('Cohort 35');

INSERT INTO Instructor (InstFirstName, InstLastName, InstSlackHandle, InstCohort, InstSpeciality) VALUES ('Andy', 'Collins', 'tgwtg', 34, 'dry humor');
INSERT INTO Instructor (InstFirstName, InstLastName, InstSlackHandle, InstCohort, InstSpeciality) VALUES ('Bryan', 'Nielsen', 'bryman', 34, 'high fives');
INSERT INTO Instructor (InstFirstName, InstLastName, InstSlackHandle, InstCohort, InstSpeciality) VALUES ('Adam', 'Schaefer', 'adamsong', 34, 'music');
INSERT INTO Instructor (InstFirstName, InstLastName, InstSlackHandle, InstCohort, InstSpeciality) VALUES ('Steve', 'Brownlee', 'coach', 35, 'ping pong');

INSERT INTO Student (StuFirstName, StuLastName, StuSlackHandle, CohortId, InstructorId) VALUES ('Haroon', 'Iqbal', 'haroonsiqbal', 1, 1);
INSERT INTO Student (StuFirstName, StuLastName, StuSlackHandle, CohortId, InstructorId) VALUES ('Bennett', 'Foster', 'bennieandthejets', 1, 2);
INSERT INTO Student (StuFirstName, StuLastName, StuSlackHandle, CohortId, InstructorId) VALUES ('Ellie', 'Ash', 'elliemash', 1, 3);
INSERT INTO Student (StuFirstName, StuLastName, StuSlackHandle, CohortId, InstructorId) VALUES ('Joey', 'Donuts', 'joeybagodonuts', 2, 4);
INSERT INTO Student (StuFirstName, StuLastName, StuSlackHandle, CohortId, InstructorId) VALUES ('Stevey', 'Simons', 'simonsayscode', 2, 4);

INSERT INTO Exercise (ExerciseName, ExerciseLang, StudentId, InstructorId) VALUES ('Trestlebridge', 'C#', 1, 1);
INSERT INTO Exercise (ExerciseName, ExerciseLang, StudentId, InstructorId) VALUES ('Kennel', 'React', 2, 2);
INSERT INTO Exercise (ExerciseName, ExerciseLang, StudentId, InstructorId) VALUES ('Chicken Monkey', 'JavaScript', 3, 3);
INSERT INTO Exercise (ExerciseName, ExerciseLang, StudentId, InstructorId) VALUES ('Flexbox', 'CSS', 4, 4);
INSERT INTO Exercise (ExerciseName, ExerciseLang, StudentId, InstructorId) VALUES ('Celebrity Tribute', 'HTML', 5, 4);





