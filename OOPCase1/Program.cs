Student amanda = new(1, "Amanda", "Gudmand", new DateOnly(1990, 1, 1)) ;
Student alexander = new(2, "Alexander", "Runge", new DateOnly(2005, 2, 5));
Student ozan = new(3, "Ozan", "Korkmaz", new DateOnly(1999, 12, 4));
Student camilla = new(4, "Camilla", "Kløjgaard", new DateOnly(1890, 4, 4));
Student dennis = new(5, "Dennis", "Paaske", new DateOnly(1980, 3, 4));

Teacher niels = new("Lærer", "Niels", "Olesen", new DateOnly(1971, 1, 23));

Course grundlæggende = new("Grundelæggende Programmering", niels);
Course studieteknik = new("Studieteknik", niels );
Course oop = new("OOP", niels);

Enrollment enrollments = new();

enrollments.enrollment = new List<Enrollment>()
{
new Enrollment(amanda, grundlæggende),
new Enrollment(amanda, studieteknik),
new Enrollment(amanda, oop),

new Enrollment(alexander, grundlæggende),
new Enrollment(alexander, studieteknik),
new Enrollment(alexander, oop),

new Enrollment(ozan, grundlæggende),
new Enrollment(ozan, oop),

new Enrollment(camilla, grundlæggende),
new Enrollment(camilla, oop),

new Enrollment(dennis, grundlæggende),
new Enrollment(dennis, studieteknik),
new Enrollment(dennis, oop),
};

List<string?> test = niels.getAllCourses(enrollments);

foreach (var item in test)
{
    Console.WriteLine(item);
}
List<string?> test1 = amanda.getAllCourses(enrollments);

foreach (var item in test1)
{
    Console.WriteLine(item);
}

string? test3 = niels.getDateOfBirth();

Console.WriteLine(test3);

string? test4 = alexander.getDateOfBirth();

Console.WriteLine(test4);