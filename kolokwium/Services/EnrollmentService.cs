using System.ComponentModel.DataAnnotations;
using kolokwium.DTO;
using kolokwium.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prescription_add_ep.Data;

namespace prescription_add_ep.Services;

public interface IEnrollmentService
{
    Task<IActionResult> GetEnrollments();
}

public class EnrollmentService (MyDbContext context) : IEnrollmentService
{
    private readonly MyDbContext _context = context;

    public async Task<IActionResult> GetEnrollments()
    {
        
            var enrollments = context.Enrollments
                .Include(e => e.Student)
                .Include(e => e.Course)
                .ToList();
            
            
            if (enrollments == null || !enrollments.Any())
            {
                return new NotFoundObjectResult("No enrollments found");
            }
            
            var enrollmentDtos = enrollments.Select(e => new GetEnrollmentsDTO
            {
                EnrollmentDate = e.EnrollmentDate,
                Student = new StudentDetailsDto
                {
                    StudentId = e.Student.StudentId,
                    FirstName = e.Student.FirstName,
                    LastName = e.Student.LastName,
                    Email = e.Student.Email
                },
                Course = new CourseDetailsDto
                {
                    CourseId = e.Course.CourseId,
                    Title = e.Course.Title,
                    Credits = e.Course.Credits.ToString(),
                    Teacher = e.Course.Teacher
                }
            }).ToList();

            return new OkObjectResult(enrollmentDtos);
    }
    
}