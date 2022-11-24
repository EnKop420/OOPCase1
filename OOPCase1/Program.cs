using System.Text;
Enrollment enrollments = new();
Student amanda = new(1, "Amanda", "Gudmand", new DateOnly(1990, 1, 1));


enrollments.enrollment = new List<Enrollment>();
//{
//new Enrollment(amanda, clientsideProgrammering),
//new Enrollment(amanda, grundlæggende),
//new Enrollment(amanda, studieteknik),
//new Enrollment(amanda, oop),
//new Enrollment(amanda, databaseProgrammering),
//new Enrollment(amanda, computerTeknologi),
//new Enrollment(amanda, netværk),
//};

enrollments.enrollment.Sort();
enrollments.enrollment.Reverse();
while (true)
{
    try
    {
        Console.WriteLine("Angiv elevens ID");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Angiv elevens fornavn");
        string? FirstName = Console.ReadLine();
        Console.WriteLine("Angiv elevens efternavn");
        string? LastName = Console.ReadLine();
        Console.WriteLine("Angiv elevens fødselsdato (MM.dd.yyyy");
        DateOnly DateOfBirth = DateOnly.Parse(Console.ReadLine());

        foreach (var item in enrollments.enrollment)
        {
            Console.WriteLine(item.CourseInfo.CourseName);
        }

        Console.WriteLine("Angiv hvilket fag du vil tilmelde eleven");

        string? CourseInStringValue= Console.ReadLine();
        Course fag = new(); 
        fag = fag.GetCourse(CourseInStringValue);

            if (fag == null)
            {
                throw new Exception("Faget fandtes ikke prøv igen...");
            }

        enrollments.CreateStudent(new Student(id, FirstName, LastName, DateOfBirth), fag);



        Console.Clear();
        foreach (var item in enrollments.enrollment)
        {
            Console.WriteLine($"{item.StudentInfo.FirstName} {item.StudentInfo.LastName}\n{item.StudentInfo.DateOfBirth}\nFag tilmeldt: {item.CourseInfo.CourseName} Lærer: {item.CourseInfo.TeacherInfo.FirstName} {item.CourseInfo.TeacherInfo.LastName}");
        }
    }
    catch (Exception e)
    {

        Console.WriteLine(e.Message);
        Console.ReadKey();
        Console.Clear();
    }

}

//try
//{

//    foreach(Enrollment item in enrollments.enrollment)
//    {
//        item.CourseInfo.GetAllStudents(enrollments.enrollment);
//        break;
//    }

//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}

//foreach (var item in alexander.getAllCourses(enrollments))
//{
//    Console.WriteLine(item);
//}