using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        // Full name property for convenience
        public string FullName => $"{FirstName} {LastName}";

        // Optional: Add a list of courses taught by this instructor
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
