using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Category { get; set; }
        public string DifficultyLevel { get; set; } // Beginner, Intermediate, Advanced
        public decimal Price { get; set; }

        // Optional: Add a list of enrollments for this course
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
