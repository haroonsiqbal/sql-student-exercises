
SELECT s.StuFirstName, s.StuLastName, c.CohortName
FROM Student s
LEFT JOIN Cohort c on s.CohortId = c.Id;

SELECT s.StuFirstName, s.StuLastName, c.CohortName
FROM Student s
LEFT JOIN Cohort c on s.CohortId = c.Id
WHERE c.Id = 1;

SELECT * FROM Instructor
ORDER BY InstLastName;

SELECT DISTINCT InstSpeciality
FROM Instructor;

SELECT s.StuFirstName, s.StuLastName, e.ExerciseName
FROM Student s
LEFT JOIN Exercise e on e.StudentId = s.Id;

SELECT s.StuFirstName, s.StuLastName, COUNT(e.ExerciseName)
FROM Student s
LEFT JOIN Exercise e on e.StudentId = s.Id
GROUP BY StuFirstName, StuLastName
;