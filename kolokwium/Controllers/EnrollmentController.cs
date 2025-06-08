using kolokwium.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using prescription_add_ep.Services;

namespace prescription_add_ep.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnrollmentController(IEnrollmentService enrollmentService)
{
   
    [HttpGet]
    public async Task<IActionResult> GetAllEnrollments()
    {
       return await enrollmentService.GetEnrollments();
    }
    
}