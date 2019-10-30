using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Models
{
    class Student
    {
        public int Id { get; set; }
        public string StuFirstName { get; set; }
        public string StuLastName { get; set; }
        public string StuSlackHandle { get; set; }
        public int CohortId { get; set; }
        public int InstructorId { get; set; }
        List<Student> studentlist = new List<Student>();
    }
}
