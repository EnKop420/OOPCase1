using System.Text;

Student amanda = new(1, "Amanda", "Gudmand", new DateOnly(1990, 1, 1)) ;
Student alexander = new(2, "Alexander", "Runge", new DateOnly(2005, 2, 5));
Student ozan = new(3, "Ozan", "Korkmaz", new DateOnly(1999, 12, 4));
Student camilla = new(4, "Camilla", "Kløjgaard", new DateOnly(1890, 4, 4));
Student dennis = new(5, "Dennis", "Paaske", new DateOnly(1980, 3, 4));
Student rune = new(5, "Rune", "Hansen", new DateOnly(1999, 2, 9));
Student jakob = new(5, "Jakob", "Rasmussen", new DateOnly(2004, 5, 12));
Student niclas = new(5, "Niclas", "Jensen", new DateOnly(1998, 6, 20));
Student mikkelJ = new(5, "Mikkel", "Jensen", new DateOnly(2005, 7, 29));
Student mikkelR = new(5, "Mikkel", "Rantala", new DateOnly(1995, 4, 4));
Student mikkelK = new(5, "Mikkel", "Kjærgaard", new DateOnly(1997, 1, 18));
Student rasmus = new(5, "Rasmus", "Wiell", new DateOnly(2004, 3, 18));

Teacher niels = new("Lærer", "Niels", "Olesen", new DateOnly(1971, 1, 23));
Teacher peter = new("Lærer", "Peter", "Lindenskov", new DateOnly(1960, 2, 28));
Teacher henrik = new("Lærer", "Henrik", "Poulsen", new DateOnly(1970, 3, 12));
Teacher jan = new("Lærer", "Jan", "Johansen", new DateOnly(1950, 4, 21));

Course clientsideProgrammering = new(EnumFag.Clientsideprogrammering, peter);
Course grundlæggende = new(EnumFag.Grundlæggendeprogrammering, niels);
Course studieteknik = new(EnumFag.Studieteknik, niels );
Course oop = new(EnumFag.OOP, niels);
Course databaseProgrammering = new(EnumFag.Datebaseprogrammering, niels);
Course computerTeknologi = new(EnumFag.Computerteknologi, jan);
Course netværk = new(EnumFag.Netværk, henrik);

Enrollment enrollments = new();

enrollments.enrollment = new List<Enrollment>()
{
new Enrollment(amanda, clientsideProgrammering),
new Enrollment(amanda, grundlæggende),
new Enrollment(amanda, studieteknik),
new Enrollment(amanda, oop),
new Enrollment(amanda, databaseProgrammering),
new Enrollment(amanda, computerTeknologi),
new Enrollment(amanda, netværk),

new Enrollment(alexander, clientsideProgrammering),
new Enrollment(alexander, grundlæggende),
new Enrollment(alexander, studieteknik),
new Enrollment(alexander, oop),
new Enrollment(alexander, databaseProgrammering),
new Enrollment(alexander, computerTeknologi),
new Enrollment(alexander, netværk),

new Enrollment(ozan, clientsideProgrammering),
new Enrollment(ozan, grundlæggende),
new Enrollment(ozan, oop),
new Enrollment(ozan, databaseProgrammering),
new Enrollment(ozan, computerTeknologi),
new Enrollment(ozan, netværk),

new Enrollment(camilla, clientsideProgrammering),
new Enrollment(camilla, grundlæggende),
new Enrollment(camilla, oop),
new Enrollment(camilla, databaseProgrammering),
new Enrollment(camilla, computerTeknologi),
new Enrollment(camilla, netværk),

new Enrollment(dennis, clientsideProgrammering),
new Enrollment(dennis, grundlæggende),
new Enrollment(dennis, studieteknik),
new Enrollment(dennis, oop),
new Enrollment(dennis, databaseProgrammering),
new Enrollment(dennis, computerTeknologi),
new Enrollment(dennis, netværk),

new Enrollment(mikkelJ, clientsideProgrammering),
new Enrollment(mikkelJ, grundlæggende),
new Enrollment(mikkelJ, studieteknik),
new Enrollment(mikkelJ, oop),
new Enrollment(mikkelJ, databaseProgrammering),
new Enrollment(mikkelJ, computerTeknologi),
new Enrollment(mikkelJ, netværk),

new Enrollment(rune, clientsideProgrammering),
new Enrollment(rune, grundlæggende),
new Enrollment(rune, studieteknik),
new Enrollment(rune, oop),
new Enrollment(rune, databaseProgrammering),
new Enrollment(rune, computerTeknologi),
new Enrollment(rune, netværk),

new Enrollment(mikkelR, clientsideProgrammering),
new Enrollment(mikkelR, grundlæggende),
new Enrollment(mikkelR, studieteknik),
new Enrollment(mikkelR, oop),
new Enrollment(mikkelR, databaseProgrammering),
new Enrollment(mikkelR, computerTeknologi),
new Enrollment(mikkelR, netværk),

new Enrollment(mikkelK, clientsideProgrammering),
new Enrollment(mikkelK, grundlæggende),
new Enrollment(mikkelK, studieteknik),
new Enrollment(mikkelK, oop),
new Enrollment(mikkelK, databaseProgrammering),
new Enrollment(mikkelK, computerTeknologi),
new Enrollment(mikkelK, netværk),

new Enrollment(niclas, clientsideProgrammering),
new Enrollment(niclas, grundlæggende),
new Enrollment(niclas, studieteknik),
new Enrollment(niclas, oop),
new Enrollment(niclas, databaseProgrammering),
new Enrollment(niclas, computerTeknologi),
new Enrollment(niclas, netværk),

new Enrollment(rune, clientsideProgrammering),
new Enrollment(rune, grundlæggende),
new Enrollment(rune, studieteknik),
new Enrollment(rune, oop),
new Enrollment(rune, databaseProgrammering),
new Enrollment(rune, computerTeknologi),
new Enrollment(rune, netværk),

new Enrollment(rasmus, clientsideProgrammering),
new Enrollment(rasmus, grundlæggende),
new Enrollment(rasmus, studieteknik),
new Enrollment(rasmus, oop),
new Enrollment(rasmus, databaseProgrammering),
new Enrollment(rasmus, computerTeknologi),
new Enrollment(rasmus, netværk),

new Enrollment(jakob, clientsideProgrammering),
new Enrollment(jakob, grundlæggende),
new Enrollment(jakob, studieteknik),
new Enrollment(jakob, oop),
new Enrollment(jakob, databaseProgrammering),
new Enrollment(jakob, computerTeknologi),
new Enrollment(jakob, netværk),
};
enrollments.enrollment.Sort();
enrollments.enrollment.Reverse();
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