using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Models;

[Table("Enrollment")]

[PrimaryKey(nameof(StudentId), nameof(CourseId))]
public class Enrollment
{
    [Key, Column(Order = 0)] public int StudentId { get; set; }
    [Key, Column(Order = 1)] public int CourseId { get; set; }
    
    [ForeignKey(nameof(StudentId))] public virtual Studentt Student { get; set; } = null!;
    
    [ForeignKey(nameof(CourseId))] public virtual Course Course { get; set; } = null!;
    
    public DateTime EnrollmentDate { get; set; }
}