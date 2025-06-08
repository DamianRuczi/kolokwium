using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium.Models;

[Table("Studentt")]
public class Studentt
{
    [Key] public int StudentId { get; set; }

    [MaxLength(50)] public string FirstName { get; set; } = null!;

    [MaxLength(100)] public string LastName { get; set; } = null!;

    [MaxLength(150), EmailAddress] public string Email { get; set; } = null!;
    
    public virtual ICollection<Enrollment> Enrollments { get; set; } = null!;
}