using System;
using System.Collections.Generic;
using System.Linq;
using StudentExercises.Models;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            List<Exercise> exercises = repository.GetAllExercises();
            List<Exercise> exercisesjava = repository.GetAllJavaScript();
            PrintExerciseReport("All Exercises", exercises);
            Pause();
            PrintExerciseReport("All JavaScript Exercises", exercisesjava);
            Pause();
            Exercise fizzbuzz = new Exercise { ExerciseName = "Fizz Buzz", ExerciseLang = "JavaScript", StudentId = 4, InstructorId = 4 };
            repository.AddExercise(fizzbuzz);
            PrintExerciseReport("All Exercises Plus fizzbuzz", exercises);
            Pause();
            List<Instructor> instructors = repository.GetAllInstructors();
            PrintInstructorReport("All Instructors", instructors);
            Pause();
            Instructor jenna = new Instructor { InstFirstName = "Jenna", InstLastName = "Solis", InstSlackHandle = "jennasolis", InstCohort = 34, InstSpeciality = "animal factories" };
            repository.AddInstructor(jenna);
            PrintInstructorReport("All Instructors plus Jenna", instructors);
            Pause();
        }
        public static void PrintExerciseReport(string title, List<Exercise> exercises)
        {
            int i = 1;
            Console.WriteLine(title);
            foreach (Exercise item in exercises)
            {
                Console.WriteLine($"{i++}. {item.ExerciseName} {item.ExerciseLang}");
            };
        }
        public static void PrintInstructorReport(string title, List<Instructor> instructors)
        {
            int i = 1;
            Console.WriteLine(title);
            foreach (Instructor item in instructors)
            {
                Console.WriteLine($"{i++}. {item.InstFirstName} {item.InstLastName}, {item.InstCohort}");
            };
        }
        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
