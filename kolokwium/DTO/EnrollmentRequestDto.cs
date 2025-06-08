namespace kolokwium.DTO;

public class CourseRequestDto
{
    public string Title { get; set; }
    public string? Credits { get; set; }
    public string Teacher { get; set; }
    
    public List<StudentRequestDto> Students { get; set; } = new();
}

public class StudentRequestDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
}