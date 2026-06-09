// string? region = null;
// string? upperRegion = region?.ToUpper();
// Console.WriteLine($"Region (condtional): {upperRegion}");
// string displayRegion = region ?? "unassigned";
// Console.WriteLine($"Region (coalesced): {displayRegion }");
// region ??="Addiss-Abeba";
// Console.WriteLine($"Region (assigned): {region}");
// //Declare your first TMS Variables
// string studentName = "Abebe";
// string studentId = "STU-001";
// int enrollmentCount = 3;
// decimal grantAmount = 1999.99m;
// DateTime enrolledAt = DateTime.UtcNow;
// string? campusRegion = null;
// Console.WriteLine($"student: {studentName} ({studentId})");
// Console.WriteLine($"Cource:{enrollmentCount}");
// Console.WriteLine($"Grant:{grantAmount:F2}");
// Console.WriteLine($"Enrolled:{enrolledAt:yyyy-MM-dd}");
// Console.WriteLine($"Campus:{campusRegion ?? "Not-assigned"}");
// decimal grantPerStudent = 1999.99m;
// decimal totalAllocation = grantPerStudent * 100_000m;
// Console.WriteLine($"Total allocated (decimal): {totalAllocation}");
// Console.WriteLine($"Total allocated (formatted): {totalAllocation:F4}");
// var enrollment = new EnrollmentRecord(
//     "STU-001",
//     "CS-401",
//     DateTime.UtcNow
// );

// Console.WriteLine(enrollment);

// Uncommenting this line causes a compiler error:
// enrollment.CourseCode = "HACKED";

// var corrected = enrollment with { CourseCode = "CS-402" };
// Console.WriteLine(corrected);

// var duplicate = new EnrollmentRecord(
//     "STU-001",
//     "CS-401",
//     enrollment.EnrolledAt
// );

// Console.WriteLine($"Same data? {enrollment == duplicate}");

// var course = new Course
// {
//     Code = "CS-401",
//     Title = "Advanced C#",
//     Capacity = 30,
//     EnrolledCount = 12
// };

// Console.WriteLine(
//     $"{course.Code} - {course.Title} | Capacity: {course.Capacity}");
//     course.Capacity = -5;
//     course.Title = "   ";
// var s = new Student
// {
//     Id = "S1",
//     Name = "Abeba",
//     Age = 20,
//     GPA = 3.8m
// };

// Console.WriteLine($"Student: {s.Name}, GPA: {s.GPA}");

void PrintGradeReport(IEnumerable<IGradable> assessments)
{
    Console.WriteLine("--- Grade Report ---");

    foreach (var item in assessments)
    {
        Console.WriteLine(
            $"{item.Title}: {item.CalculateGrade():F2}%");
    }
}

IGradable[] cohortAssessments =
[
    new Quiz
    {
        Title = "C# Basics",
        CorrectAnswers = 18,
        TotalQuestions = 20
    },

    new LabAssignment
    {
        Title = "Registration API",
        FunctionalityScore = 90m,
        CodeQualityScore = 85m
    }
];

PrintGradeReport(cohortAssessments);