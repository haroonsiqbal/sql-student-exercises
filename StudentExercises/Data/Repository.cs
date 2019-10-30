using StudentExercises.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;

namespace StudentExercises
{
    public class Repository
    {
        public SqlConnection Connection
        {
            get
            {
                string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentExercises;Integrated Security=True";
                return new SqlConnection(_connectionString);
            }
        }
        public List<Exercise> GetAllExercises()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, ExerciseName from Exercise";
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Exercise> exercises = new List<Exercise>();
                    while (reader.Read())
                    {
                        int idColumnPosition = reader.GetOrdinal("Id");
                        int idValue = reader.GetInt32(idColumnPosition);
                        int ExerciseNameColumnPosition = reader.GetOrdinal("ExerciseName");
                        string ExerciseNameValue = reader.GetString(ExerciseNameColumnPosition);

                        Exercise exercise = new Exercise
                        {
                            Id = idValue,
                            ExerciseName = ExerciseNameValue
                        };
                        exercises.Add(exercise);
                    }
                    reader.Close();
                    return exercises;
                }
            }
        }

        public List<Exercise> GetAllJavaScript()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, ExerciseName, ExerciseLang FROM Exercise WHERE ExerciseLang = 'JavaScript'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Exercise> exercises = new List<Exercise>();
                    while (reader.Read())
                    {
                        int idColumnPosition = reader.GetOrdinal("Id");
                        int idValue = reader.GetInt32(idColumnPosition);
                        int ExerciseNameColumnPosition = reader.GetOrdinal("ExerciseName");
                        string ExerciseNameValue = reader.GetString(ExerciseNameColumnPosition);
                        int ExerciseLangColumnPosition = reader.GetOrdinal("ExerciseLang");
                        string ExerciseLangValue = reader.GetString(ExerciseLangColumnPosition);

                        Exercise exercise = new Exercise
                        {
                            Id = idValue,
                            ExerciseName = ExerciseNameValue,
                            ExerciseLang = ExerciseLangValue
                        };
                        exercises.Add(exercise);
                    }
                    reader.Close();
                    return exercises;
                }
            }
        }

        public void AddExercise(Exercise exercise)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Exercise (ExerciseName, ExerciseLang, StudentId, InstructorId) Values (@exerciseName, @exerciseLang, @exercisestuId, @exerciseinstId)";
                    cmd.Parameters.Add(new SqlParameter("@exerciseName", exercise.ExerciseName));
                    cmd.Parameters.Add(new SqlParameter("@exerciseLang", exercise.ExerciseLang));
                    cmd.Parameters.Add(new SqlParameter("@exercisestuId", exercise.StudentId));
                    cmd.Parameters.Add(new SqlParameter("@exerciseinstId", exercise.InstructorId));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Instructor> GetAllInstructors()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, InstFirstName, InstLastName, InstCohort from Instructor";
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Instructor> instructors = new List<Instructor>();
                    while (reader.Read())
                    {
                        int idColumnPosition = reader.GetOrdinal("Id");
                        int idValue = reader.GetInt32(idColumnPosition);
                        int InstFirstNameColumnPosition = reader.GetOrdinal("InstFirstName");
                        string InstFirstNameValue = reader.GetString(InstFirstNameColumnPosition);
                        int InstLastNameColumnPosition = reader.GetOrdinal("InstLastName");
                        string InstLastNameValue = reader.GetString(InstLastNameColumnPosition);
                        int InstCohortColumnPosition = reader.GetOrdinal("InstCohort");
                        int InstCohortValue = reader.GetInt32(InstCohortColumnPosition);

                        Instructor instructor = new Instructor
                        {
                            Id = idValue,
                            InstFirstName = InstFirstNameValue,
                            InstLastName = InstLastNameValue,
                            InstCohort = InstCohortValue
                        };
                        instructors.Add(instructor);
                    }
                    reader.Close();
                    return instructors;
                }
            }
        }

        public void AddInstructor(Instructor instructor)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Instructor (InstFirstName, InstLastName, InstSlackHandle, InstCohort, InstSpeciality) Values (@instFirstName, @instLastName, @instSlackHandle, @instCohort, @instSpeciality)";
                    cmd.Parameters.Add(new SqlParameter("@instFirstName", instructor.InstFirstName));
                    cmd.Parameters.Add(new SqlParameter("@instLastName", instructor.InstLastName));
                    cmd.Parameters.Add(new SqlParameter("@instSlackHandle", instructor.InstSlackHandle));
                    cmd.Parameters.Add(new SqlParameter("@instCohort", instructor.InstCohort));
                    cmd.Parameters.Add(new SqlParameter("@instSpeciality", instructor.InstSpeciality));
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

