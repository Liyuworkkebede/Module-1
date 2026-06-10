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

// void PrintGradeReport(IEnumerable<IGradable> assessments)
// {
//     Console.WriteLine("--- Grade Report ---");

//     foreach (var item in assessments)
//     {
//         Console.WriteLine(
//             $"{item.Title}: {item.CalculateGrade():F2}%");
//     }
// }

// IGradable[] cohortAssessments =
// [
//     new Quiz
//     {
//         Title = "C# Basics",
//         CorrectAnswers = 18,
//         TotalQuestions = 20
//     },

//     new LabAssignment
//     {
//         Title = "Registration API",
//         FunctionalityScore = 90m,
//         CodeQualityScore = 85m
//     }
// ];

// PrintGradeReport(cohortAssessments);

// var service = new EnrollmentService();
// // Test 1: Valid registration
// var validStudent = new Student { Id = "S1", Name = "Abeba", Age = 20, GPA = 3.8m };
// var validCourse = new Course { Code = "CS-401", Title = "Advanced C#", Capacity = 30 };
// var result = service.ProcessRegistration(validStudent, validCourse);
// Console.WriteLine($"Enrolled: {result.StudentId} in {result.CourseCode}");
// // Test 2: Null student should throw
// try
// {
// service.ProcessRegistration(null, validCourse);
// }
// catch (ArgumentNullException ex)
// {
// Console.WriteLine($"Guard caught: {ex.ParamName}");
// }
// // Test 3: Full course should throw
// var fullCourse = new Course { Code = "CS-402", Title = "Full Course", Capacity = 1 };
// fullCourse.EnrolledCount = 1;
// try
// {
// service.ProcessRegistration(validStudent, fullCourse);
// }
// catch (InvalidOperationException ex)
// {
// Console.WriteLine($"Business rule: {ex.Message}");
// }
// Step 1: Student Data
// List<Student> students = [
//     new Student { Id="S1", Name = "Abeba", Age=22, GPA=3.8m },
//     new Student { Id="S2", Name = "Kidane", Age=21, GPA=2.4m },
//     new Student { Id="S3", Name = "Dawit", Age=20, GPA=3.1m },
//     new Student { Id="S4", Name = "Sara", Age=23, GPA=3.9m },
//     new Student { Id="S5", Name = "Frehiwot", Age=19, GPA=2.0m },
//     new Student { Id="S6", Name = "Yonas", Age=24, GPA=3.5m },
//     new Student { Id="S7", Name = "Meron", Age=22, GPA=1.8m },
//     new Student { Id="S8", Name = "Tesfaye", Age=21, GPA=2.9m }
// ];

// // Exercise 5 - TODO 1-4: Honors Leaderboard
// var leaderboard = students
//     .Where(s => s.GPA >= 3.5m)
//     .OrderByDescending(s => s.GPA)
//     .Select(s => s.Name)
//     .ToList();

// Console.WriteLine($"Found {leaderboard.Count} Honors Students:");
// leaderboard.ForEach(name => Console.WriteLine($"- {name}"));

// // TODO 5: Class Average
// decimal averageGpa = students.Average(s => s.GPA);
// Console.WriteLine($"\nClass Average GPA: {averageGpa:F2}");

// // TODO 6: Group By Academic Standing
// var standingGroups = students.GroupBy(s => s.GPA switch {
//     >= 3.5m => "Honors",
//     >= 2.5m => "Good Standing",
//     >= 2.0m => "Probation",
//     _ => "Academic Warning"
// });

// Console.WriteLine("\n--- Academic Standing Report ---");
// foreach (var group in standingGroups) {
//     Console.WriteLine($"\n{group.Key} ({group.Count()}):");
//     foreach (var s in group) Console.WriteLine($"- {s.Name} GPA: {s.GPA}");
// }

// // TODO 7: Spread Operator
// string[] backend = ["C#", "ASP.NET Core"];
// string[] frontend = ["TypeScript", "Angular"];
// string[] allCourses = [..backend, ..frontend, "Capstone"];
// Console.WriteLine($"\nFull curriculum: {string.Join(", ", allCourses)}");
using System.Diagnostics;


// =========================
// STOPWATCH START (ONLY ONCE)
// =========================
var sw = Stopwatch.StartNew();

// =========================
// BLOCKING vs ASYNC TEST
// =========================

// Blocking
for (int i = 0; i < 5; i++)
{
    Thread.Sleep(300);
}
Console.WriteLine($"Blocking sequential: {sw.ElapsedMilliseconds}ms");


for (int i = 0; i < 5; i++)
{
    await Task.Delay(300);
}
Console.WriteLine($"Async sequential: {sw.ElapsedMilliseconds}ms");

// Async parallel
sw.Restart();
var tasks = Enumerable.Range(0, 5).Select(_ => Task.Delay(300));
await Task.WhenAll(tasks);
Console.WriteLine($"Async parallel: {sw.ElapsedMilliseconds}ms");


// =========================
// FETCH METHODS
// =========================
async Task<Student> FetchStudentAsync(string id)
{
    Console.WriteLine($"Fetching {id}...");
    await Task.Delay(300);

    return new Student
    {
        Id = id,
        Name = $"Student-{id}",
        Age = 20,
        GPA = id switch
        {
            "S1" => 3.8m,
            "S2" => 2.4m,
            "S3" => 3.5m,
            "S4" => 1.9m,
            "S5" => 3.2m,
            _ => 2.5m
        }
    };
}

async Task<Course> FetchCourseAsync(string code)
{
    Console.WriteLine($"Fetching course {code}...");
    await Task.Delay(200);

    return new Course
    {
        Code = code,
        Title = $"Course-{code}",
        Capacity = code switch
        {
            "CRS-101" => 2,
            "CRS-201" => 30,
            "CRS-301" => 15,
            _ => 25
        }
    };
}

// =========================
// SAFE EMAIL (Fire & Forget)
// =========================
async Task SendConfirmationAsync(Student student)
{
    try
    {
        await Task.Delay(100);
        Console.WriteLine($"Email sent to {student.Name}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Email failed for {student.Name}: {ex.Message}");
    }
}

// =========================
// LOAD DATA IN PARALLEL
// =========================
string[] studentIds = ["S1", "S2", "S3", "S4", "S5"];
string[] courseCodes = ["CRS-101", "CRS-201", "CRS-301"];

var studentTasks = studentIds.Select(FetchStudentAsync);
var courseTasks = courseCodes.Select(FetchCourseAsync);

Student[] students = await Task.WhenAll(studentTasks);
Course[] courses = await Task.WhenAll(courseTasks);

Console.WriteLine($"\nLoaded {students.Length} students and {courses.Length} courses in {sw.ElapsedMilliseconds}ms");

foreach (var s in students)
{
    Console.WriteLine($"{s.Name} GPA: {s.GPA}");
}

// =========================
// ENROLLMENT ENGINE
// =========================
var enrollCourse = new Course
{
    Code = "CRS-101",
    Title = "C# Mastery",
    Capacity = 2
};

var enrollService = new EnrollmentService();

var enrollments = new List<EnrollmentRecord>();
var failures = new List<string>();

enrollService.OnEnrolled = student =>
{
    Console.WriteLine($"SMS SENT: Welcome to TMS, {student.Name}!");
};

foreach (var student in students)
{
    try
    {
        var record = enrollService.ProcessRegistration(student, enrollCourse);

        enrollCourse.EnrolledCount++;

        enrollments.Add(record);

        Console.WriteLine($"Enrolled: {student.Name}");
        _ = SendConfirmationAsync(student);
    }
    catch (CapacityReachedException ex)
    {
        failures.Add($"{student.Name}: {ex.Message}");
        Console.WriteLine($"Rejected: {student.Name} {ex.Message}");
    }
}

// =========================
// DOMAIN TEST (Exercise 7)
// =========================
try
{
    var overflowCourse = new Course
    {
        Code = "CRS-999",
        Title = "Overflow Test",
        Capacity = 1,
        EnrolledCount = 1
    };

    var service = new EnrollmentService();

    service.ProcessRegistration(
        new Student
        {
            Id = "S99",
            Name = "Test Student",
            Age = 20,
            GPA = 3.0m
        },
        overflowCourse
    );
}
catch (CapacityReachedException ex)
{
    Console.WriteLine("\nDomain exception caught:");
    Console.WriteLine($"Course: {ex.CourseCode}");
    Console.WriteLine($"Message: {ex.Message}");
}

// =========================
// FINAL REPORT
// =========================
sw.Stop();

decimal classAverage = students.Length > 0
    ? students.Average(s => s.GPA)
    : 0m;

Console.WriteLine("\n========== ENROLLMENT SUMMARY ==========");
Console.WriteLine($"Total students loaded: {students.Length}");
Console.WriteLine($"Successful enrollments: {enrollments.Count}");
Console.WriteLine($"Failed enrollments: {failures.Count}");
Console.WriteLine($"Class average GPA: {classAverage:F2}");
Console.WriteLine($"Total elapsed time: {sw.ElapsedMilliseconds}ms");

if (failures.Count > 0)
{
    Console.WriteLine("\n--- Failure Details ---");
    foreach (var f in failures)
    {
        Console.WriteLine($" {f}");
    }
}

Console.WriteLine("========================================");