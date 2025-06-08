using Microsoft.EntityFrameworkCore;
using prescription_add_ep.Data;

namespace prescription_add_ep.Services;

public interface IEnrollmentService
{
    // Task<Enrollment[]> GetEnrollments(PatientRequestDto request);
    Task<String> GetStudent(int studentId);
}

public class EnrollmentService (MyDbContext context) : IEnrollmentService
{
    private readonly MyDbContext _context = context;
    
    public async Task<String> GetStudent(int studentId)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(p => p.StudentId == studentId);

        if (student == null)
        {
            return $"Patient with ID {studentId} not found";
        }

       

        return student.FirstName + " " + student.LastName;
    }
}