

public class EnrollmentService
{
    public EnrollmentRecord ProcessRegistration(Student? student, Course? course)
    {
        // TODO 1: Guard Clauses
        if (student is null) throw new ArgumentNullException(nameof(student));
        if (course is null) throw new ArgumentNullException(nameof(course));
        if (course.Capacity <= 0) throw new InvalidOperationException("Course is full or invalid.");

        // TODO 2: Switch Expression ለGPA ምድብ
        string standing = student.GPA switch
        {
            >= 3.5m => "Honors",
            >= 2.5m => "Good Standing",
            _ => "Academic Warning"
        };
        Console.WriteLine($"{student.Name} is in {standing} standing.");

        // TODO 3: Return EnrollmentRecord
        return new EnrollmentRecord(student.Id, course.Code, DateTime.UtcNow);
    }
}