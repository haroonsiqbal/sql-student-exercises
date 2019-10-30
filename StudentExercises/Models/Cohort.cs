using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Models
{
    class Cohort
    {
        public int Id { get; set; }
        public string CohortName { get; set; }
        List<Cohort> cohortlist = new List<Cohort>();
    }
}
