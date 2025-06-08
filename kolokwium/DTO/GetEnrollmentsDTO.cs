namespace kolokwium.DTO;

public class GetEnrollmentsDTO
{
    public DateTime EnrollmentDate { get; set; }
    public StudentDetailsDto Student { get; set; } = null!;
    public CourseDetailsDto Course { get; set; } = null!;
}

public class CourseDetailsDto
{
    public int CourseId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Credits { get; set; } = string.Empty;
    public string Teacher { get; set; } = string.Empty;
}

public class StudentDetailsDto
{
    public int StudentId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
}


