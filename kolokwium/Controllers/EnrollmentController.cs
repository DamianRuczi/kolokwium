using Microsoft.AspNetCore.Mvc;
using prescription_add_ep.Services;

namespace prescription_add_ep.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnrollmentController(IEnrollmentService enrollmentService)
{
    [HttpGet("{patientId}")]
    public async Task<String> GetPatientDetails(int patientId)
    {
        return await enrollmentService.GetStudent(patientId);
    }
}