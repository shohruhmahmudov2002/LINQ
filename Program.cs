using System.Collections;

namespace LINQ;
internal class Program
{
    static void Main(string[] args)
    {
        #region LINQ Query Syntax
        /*
        //1.LINQ Query Syntax
        //var numbers = Enumerable.Range(1, 100);
        //Console.WriteLine(string.Join(",", GetEvenNumbers()));

        //var evenNumbers = numbers.Where(n => n % 2 == 0);
        //Console.WriteLine(string.Join(",", evenNumbers));

        //var evenNumbersLINQ = from number in numbers
        //                      where number % 2 == 0
        //                      select number;
        //Console.WriteLine(string.Join(",", evenNumbersLINQ));

        //Filtering, Sorting, Projection, Grouping, Joining, Aggregation (Sum, Average, Count, Min, Max)



        List<int> GetEvenNumbers()
        {
            var list = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    list.Add(number);
                }
            }
            return list;
        }
        */
        #endregion
        #region Draft
        //var students = new List<Students>
        //{
        //    new Students { StudentID = 1, FirstName = "Hulkarbonu", LastName = "Rahimova", Email = "hulkarrah@gmail.com"},
        //    new Students { StudentID = 2, FirstName = "Shohruh", LastName = "Mahmudov", Email = "shohruhmahmudov@gmail.com" },
        //    new Students { StudentID = 3, FirstName = "Iroda", LastName = "Mahmudova", Email = "irodamahmudova@gmail.com" }
        //};

        //var femaleStudents = students.
        //    Where(s => s.LastName.EndsWith("va")).
        //    Select(s => s.LastName);

        //femaleStudents.ToConsole();
        ////var evenNUmbersList = GetEvenNumbers(Enumerable.Range(1, 100));
        //var evenNumbersListEnumerable = GetEvenNumbersEnumerable(Enumerable.Range(1, 100));

        //foreach(var number in evenNumbersListEnumerable)
        //{
        //    Console.WriteLine(number);
        //}

        //IEnumerable<int> GetEvenNumbersEnumerable(IEnumerable<int> numbers)
        //{
        //    foreach (var number in numbers)
        //    {
        //        if(number % 2 == 0)
        //        {
        //            yield return number;
        //        }
        //    }
        //}

        //var enumerator = femaleStudents.GetEnumerator();
        //while (enumerator.MoveNext())
        //{
        //    var current = enumerator.Current;
        //    Console.WriteLine(current);
        //}

        //enumerator.MoveNext();
        //var firstName = enumerator.Current;
        //Console.WriteLine(firstName);
        #endregion

    //Insertion
        // 1. Fill Students
        var students = new List<Student>
        {
            new Student { StudentID = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", DateOfBirth = new DateTime(2000, 5, 15) },
            new Student { StudentID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", DateOfBirth = new DateTime(1998, 8, 20) },
            new Student { StudentID = 3, FirstName = "Michael", LastName = "Brown", Email = "michael.brown@example.com", DateOfBirth = new DateTime(1995, 12, 1) },
            new Student { StudentID = 4, FirstName = "Emily", LastName = "Clark", Email = "emily.clark@example.com", DateOfBirth = new DateTime(1997, 7, 25) },
            new Student { StudentID = 5, FirstName = "David", LastName = "Johnson", Email = "david.johnson@example.com", DateOfBirth = new DateTime(1999, 3, 10) },
            new Student { StudentID = 6, FirstName = "Sophia", LastName = "Martinez", Email = "sophia.martinez@example.com", DateOfBirth = new DateTime(2001, 6, 18) },
            new Student { StudentID = 7, FirstName = "Daniel", LastName = "Lee", Email = "daniel.lee@example.com", DateOfBirth = new DateTime(1996, 9, 5) },
            new Student { StudentID = 8, FirstName = "Olivia", LastName = "Anderson", Email = "olivia.anderson@example.com", DateOfBirth = new DateTime(2002, 11, 30) },
            new Student { StudentID = 9, FirstName = "James", LastName = "White", Email = "james.white@example.com", DateOfBirth = new DateTime(1994, 4, 22) },
            new Student { StudentID = 10, FirstName = "Isabella", LastName = "Harris", Email = "isabella.harris@example.com", DateOfBirth = new DateTime(1997, 2, 14) }
        };

        // 2. Fill Courses
        var courses = new List<Course>
        {
            new Course { CourseID = 1, CourseName = "Introduction to C#", Category = "Programming", DifficultyLevel = "Beginner", Price = 99.99m },
            new Course { CourseID = 2, CourseName = "Data Science Basics", Category = "Data Science", DifficultyLevel = "Intermediate", Price = 199.99m },
            new Course { CourseID = 3, CourseName = "Advanced Web Development", Category = "Web Development", DifficultyLevel = "Advanced", Price = 299.99m },
            new Course { CourseID = 4, CourseName = "Introduction to Python", Category = "Programming", DifficultyLevel = "Beginner", Price = 79.99m },
            new Course { CourseID = 5, CourseName = "Machine Learning Fundamentals", Category = "Data Science", DifficultyLevel = "Advanced", Price = 349.99m },
            new Course { CourseID = 6, CourseName = "React and Modern UI Design", Category = "Web Development", DifficultyLevel = "Intermediate", Price = 149.99m },
            new Course { CourseID = 7, CourseName = "Database Management Systems", Category = "Databases", DifficultyLevel = "Intermediate", Price = 129.99m },
            new Course { CourseID = 8, CourseName = "Cybersecurity Essentials", Category = "Security", DifficultyLevel = "Advanced", Price = 199.99m },
            new Course { CourseID = 9, CourseName = "Cloud Computing with AWS", Category = "Cloud", DifficultyLevel = "Intermediate", Price = 249.99m },
            new Course { CourseID = 10, CourseName = "Game Development with Unity", Category = "Game Development", DifficultyLevel = "Beginner", Price = 179.99m }
        };

        // 3. Fill Instructors
        var instructors = new List<Instructor>
        {
            new Instructor {
                InstructorID = 1, FirstName = "Emma", LastName = "Williams",
                Email = "emma.williams@example.com", HireDate = new DateTime(2015, 6, 1),
                Courses = new List<Course>
                {
                    courses[0], // Introduction to C#
                    courses[3], // Introduction to Python
                    courses[5]  // React and Modern UI Design
                }
            },
            new Instructor {
                InstructorID = 2, FirstName = "Liam", LastName = "Taylor",
                Email = "liam.taylor@example.com", HireDate = new DateTime(2018, 9, 15),
                Courses = new List<Course>
                {
                    courses[1], // Data Science Basics
                    courses[4]  // Machine Learning Fundamentals
                }
            },
            new Instructor {
                InstructorID = 3, FirstName = "Noah", LastName = "Walker",
                Email = "noah.walker@example.com", HireDate = new DateTime(2017, 3, 10),
                Courses = new List<Course>
                {
                    courses[2], // Advanced Web Development
                    courses[6], // Database Management Systems
                    courses[7]  // Cybersecurity Essentials
                }
            },
            new Instructor {
                InstructorID = 4, FirstName = "Sophia", LastName = "Lopez",
                Email = "sophia.lopez@example.com", HireDate = new DateTime(2016, 11, 25),
                Courses = new List<Course>
                {
                    courses[0], // Introduction to C#
                    courses[9]  // Game Development with Unity
                }
            },
            new Instructor {
                InstructorID = 5, FirstName = "Ethan", LastName = "Scott",
                Email = "ethan.scott@example.com", HireDate = new DateTime(2014, 5, 30),
                Courses = new List<Course>
                {
                    courses[4], // Machine Learning Fundamentals
                    courses[8]  // Cloud Computing with AWS
                }
            },
            new Instructor {
                InstructorID = 6, FirstName = "Olivia", LastName = "Baker",
                Email = "olivia.baker@example.com", HireDate = new DateTime(2019, 7, 12),
                Courses = new List<Course>
                {
                    courses[5], // React and Modern UI Design
                    courses[7]  // Cybersecurity Essentials
                }
            },
            new Instructor {
                InstructorID = 7, FirstName = "Lucas", LastName = "Carter",
                Email = "lucas.carter@example.com", HireDate = new DateTime(2020, 1, 5),
                Courses = new List<Course>
                {
                    courses[1], // Data Science Basics
                    courses[6]  // Database Management Systems
                }
            },
            new Instructor {
                InstructorID = 8, FirstName = "Ava", LastName = "Mitchell",
                Email = "ava.mitchell@example.com", HireDate = new DateTime(2013, 10, 18),
                Courses = new List<Course>
                {
                    courses[2], // Advanced Web Development
                    courses[8]  // Cloud Computing with AWS
                }
            },
            new Instructor {
                InstructorID = 9, FirstName = "Mason", LastName = "Perez",
                Email = "mason.perez@example.com", HireDate = new DateTime(2012, 8, 21),
                Courses = new List<Course>
                {
                    courses[3], // Introduction to Python
                    courses[9]  // Game Development with Unity
                }
            },
            new Instructor {
                InstructorID = 10, FirstName = "Ella", LastName = "Hill",
                Email = "ella.hill@example.com", HireDate = new DateTime(2021, 6, 14),
                Courses = new List<Course>
                {
                    courses[0], // Introduction to C#
                    courses[5], // React and Modern UI Design
                    courses[6]  // Database Management Systems
                }
            }
        };

        // 4. Fill Enrollments
        var enrollments = new List<Enrollment>
        {
            new Enrollment { EnrollmentID = 1, StudentID = 1, CourseID = 1, EnrollmentDate = DateTime.Now.AddMonths(-2), CompletionStatus = "Completed", Score = 85.5m },
            new Enrollment { EnrollmentID = 2, StudentID = 2, CourseID = 2, EnrollmentDate = DateTime.Now.AddMonths(-1), CompletionStatus = "In Progress", Score = 70.0m },
            new Enrollment { EnrollmentID = 3, StudentID = 3, CourseID = 3, EnrollmentDate = DateTime.Now.AddMonths(-3), CompletionStatus = "Dropped", Score = 50.0m },
            new Enrollment { EnrollmentID = 4, StudentID = 1, CourseID = 4, EnrollmentDate = DateTime.Now.AddMonths(-1), CompletionStatus = "Completed", Score = 90.0m },
            new Enrollment { EnrollmentID = 5, StudentID = 2, CourseID = 1, EnrollmentDate = DateTime.Now.AddMonths(-3), CompletionStatus = "Completed", Score = 95.0m },
            new Enrollment { EnrollmentID = 6, StudentID = 4, CourseID = 5, EnrollmentDate = DateTime.Now.AddMonths(-2), CompletionStatus = "In Progress", Score = 88.0m },
            new Enrollment { EnrollmentID = 7, StudentID = 5, CourseID = 6, EnrollmentDate = DateTime.Now.AddMonths(-4), CompletionStatus = "Completed", Score = 78.5m },
            new Enrollment { EnrollmentID = 8, StudentID = 6, CourseID = 7, EnrollmentDate = DateTime.Now.AddMonths(-5), CompletionStatus = "Completed", Score = 91.0m },
            new Enrollment { EnrollmentID = 9, StudentID = 7, CourseID = 8, EnrollmentDate = DateTime.Now.AddMonths(-3), CompletionStatus = "Dropped", Score = 55.0m },
            new Enrollment { EnrollmentID = 10, StudentID = 8, CourseID = 9, EnrollmentDate = DateTime.Now.AddMonths(-1), CompletionStatus = "In Progress", Score = 80.0m }
        };

//Task Part
        // 1.
        Console.Write("1. ");
        var fullName = students.Select(s => s.FullName);
        Console.WriteLine(string.Join(", ", fullName));

        // 2.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("2. ");
        var courseProgramming = courses.Where(c => c.Category == "Programming");

        foreach (var course in courseProgramming)
        {
            Console.WriteLine(course.CourseName + " " + course.Price);
        }

        // 3.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("3. ");
        var studentsSpecifiedEmail = students.Where(s => s.Email.EndsWith("example.com")).Select(s => s.FullName);
        Console.WriteLine(string.Join(", ", studentsSpecifiedEmail));

        // 4.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("4. ");
        var coursesAbovePrice = courses.Where(c => c.Price > 100).Select(c => c.CourseName);
        Console.WriteLine(string.Join(", ", coursesAbovePrice));

        // 5.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("5. ");
        var enrollmentCount = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
            new
            {
                e.EnrollmentID,
                c.CourseName
            })
            .Count(c => c.CourseName == "Introduction to C#");
        Console.WriteLine(enrollmentCount);

        // 6.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("6. ");
        var studentSpecificCourse = students
            .Join(enrollments, s => s.StudentID, e => e.StudentID, (s, e) =>
            new
            {
                s.FullName,
                e.CourseID
            })
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
            new
            {
                e.FullName,
                c.CourseName
            })
            .Where(c => c.CourseName == "Data Science Basics")
            .Select(e => e.FullName);
        Console.WriteLine(string.Join(", ", studentSpecificCourse));

        // 7.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("7. ");
        var courseNoEnrollment = courses
            .GroupJoin(enrollments, c => c.CourseID, e => e.CourseID, (c, e) =>
            new
            {
                c.CourseName,
                hasEnrollment = e.Any()
            })
            .Where(x => !x.hasEnrollment)
            .Select(c => c.CourseName);
        Console.WriteLine(string.Join(", ", courseNoEnrollment));  //GroupJoin is used for Left Join

        // 8.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("8. ");
        var avgScoreByCourse = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
            new
            {
                c.CourseName,
                e.Score,
                e.CourseID
            })
            .GroupBy(e => new { e.CourseID, e.CourseName })
            .Select(x => new
            {
                CourseName = x.Key.CourseName,
                AverageScore = x.Average(e => e.Score)
            });

        foreach (var course in avgScoreByCourse)
        {
            Console.WriteLine($"{course.CourseName} - {course.AverageScore:F2}");
        }

        // 9.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("9. ");
        var instructorCourses = instructors
            .Where(i => i.Courses.Count() >= 3)
            .Select(i => i.FullName);
        Console.WriteLine(string.Join(", ", instructorCourses));

        // 10.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("10. ");
        var studentsAboveScore = students
            .Join(enrollments, s => s.StudentID, e => e.StudentID, (s, e) =>
            new
            {
                s.FullName,
                e.Score
            })
            .Where(e => e.Score >= 90)
            .Select(s => s.FullName);
        Console.WriteLine(string.Join(", ", studentsAboveScore));

        // 11.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("11. ");
        var topStudentsByCourse = enrollments
            .Join(students, e => e.StudentID, s => s.StudentID, (e, s) =>
            new
            {
                s.FullName,
                e.CourseID,
                e.Score
            })
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
            new
            {
                c.CourseName,
                e.FullName,
                e.Score
            })
            .GroupBy(e => e.CourseName)
            .Select(x => x.OrderByDescending(e => e.Score).Take(3));

        foreach (var student in topStudentsByCourse)
        {
            int rank = 1;
            foreach (var s in student)
            {
                Console.WriteLine($"{rank}. {s.FullName} - {s.CourseName} - {s.Score}");
                rank++;
            }
        }

        // 12.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("12. ");
        var revByCategory = courses
            .GroupBy(c => c.Category)
            .Select(courses => new
            {
                Category = courses.Key,
                TotalRevenu = courses.Sum(c => c.Price)
            });

        foreach (var course in revByCategory)
        {
            Console.WriteLine($"{course.Category} - {course.TotalRevenu:F2}");
        }

        // 13.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("13. ");
        var studentsNotEnrolled = students
            .GroupJoin(enrollments, s => s.StudentID, e => e.StudentID, (s, e) =>
            new
            {
                s.FullName,
                hasEnrollment = e.Any()
            })
            .Where(x => !x.hasEnrollment)
            .Select(e => e.FullName);
        Console.WriteLine(string.Join(", ", studentsNotEnrolled));

        // 14.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("14. ");
        var courseCompletionStatus = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
            new
            {
                e.CourseID,
                c.CourseName,
                e.CompletionStatus,
            })
            .GroupBy(e => new { e.CourseID, e.CourseName })
            .Select(x => new
            {
                CourseName = x.Key.CourseName,
                CompletedPercentage = (double)x.Count(e => e.CompletionStatus == "Completed") / x.Count() * 100
            });

        foreach (var course in courseCompletionStatus)
        {
            Console.WriteLine($"{course.CourseName} - {course.CompletedPercentage:F2}%");
        }

        // 15.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("15. ");
        var revenueByInstructor = instructors
            .Select(i =>
            new
            {
                i.FullName,
                TotalRevenue = i.Courses.Sum(course => enrollments
                .Where(e => e.CourseID == course.CourseID)
                .Count() * course.Price)
            });
        foreach (var instructor in revenueByInstructor)
        {
            Console.WriteLine($"{instructor.FullName} - {instructor.TotalRevenue:F2}");
        }

        // 16.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("16. ");
        var notificationTopStudents = enrollments
            .Join(students, e => e.StudentID, s => s.StudentID, (e, s) =>
            new
            {
                s.FullName,
                e.Score,
                Notification = "Congratulations! You are one of the top students in the course."
            })
            .Where(e => e.Score >= 90);
        foreach (var student in notificationTopStudents)
        {
            Console.WriteLine($"{student.FullName} - {student.Notification}");
        }

        // 17.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("17. ");
        var topCourses = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
            new
            { 
                c.CourseName,
                e.CourseID,
            })
            .GroupBy(e => new {e.CourseID, e.CourseName})
            .Select(x => new
            {
                CourseName = x.Key.CourseName,
                TotalEnrollments = x.Count()
            })
            .OrderByDescending(o => o.TotalEnrollments)
            .Take(3);

        foreach (var course in topCourses)
        {
            Console.WriteLine($"{course.CourseName} - {course.TotalEnrollments}");
        }

        // 18.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("18. ");
        var studentsPercentage = enrollments
            .Join(students, e => e.StudentID, s => s.StudentID, (e, s) =>
            new
            {
                e.StudentID,
                s.FullName,
                e.CompletionStatus
            })
            .GroupBy(e => new {e.StudentID, e.FullName})
            .Select(x => new
            {
                StudentName = x.Key.FullName,
                Percentage = (double)x.Count(e => e.CompletionStatus == "Completed") / x.Count() * 100
            });

        foreach(var student in studentsPercentage)
        {
            Console.WriteLine($"{student.StudentName} - {student.Percentage:F2}%");
        }

        // 19.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("19. ");
        var enrollmentTrend = enrollments
            .GroupBy(e => new { e.EnrollmentDate.Year, e.EnrollmentDate.Month })
            .Select(x => new
            {
                Year = x.Key.Year,
                Month = x.Key.Month,
                TotalEnrollments = x.Count()
            })
            .OrderBy(e => e.Year).ThenBy(e => e.Month);

        foreach(var enrollment in enrollmentTrend)
        {
            Console.WriteLine($"{enrollment.Year}-{enrollment.Month} - {enrollment.TotalEnrollments}");
        }

        // 20.
        Console.WriteLine("\n----------------------------\n");
        Console.Write("20. ");
        var topCategory = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
            new
            {
                c.Category,
                e.CourseID
            })
            .GroupBy(e => new {e.CourseID, e.Category})
            .Select(x => new
            {
                Category = x.Key.Category,
                TotalEnrollments = x.Count()
            })
            .OrderByDescending(e => e.TotalEnrollments)
            .First();

        Console.WriteLine("Top Category: " + topCategory.Category);

    }
}
#region Draft
//public class Students
//{
//    public int StudentID { get; set; }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Email { get; set; }
//}

//public class MyCollection : IEnumerable<Students>
//{
//    public IEnumerator<Students> GetEnumerator()
//    {
//        throw new NotImplementedException();
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}

//public class PdpGroups : IEnumerable
//{
//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return new PdpGroup();
//    }
//}

//public class PdpGroup : IEnumerator
//{
//    public string[] Groups = {"G7", "G8", "G9", "G10"};
//    private int Position = -1;
//    public bool MoveNext()
//    {
//        if(Position >= Groups.Length)
//        {
//            return false;
//        }
//        Position++;
//        return true;
//    }
//    public void Reset()
//    {
//        Position = -1;
//    }
//    public object Current { get => Groups[Position]; }
//}
#endregion
