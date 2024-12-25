using System.Security.Cryptography.X509Certificates;

namespace _2._6_darsStudent.Services.DTOs;

public class StudentUpdateDto:BaseStudentDto
{
    public Guid Id { get; set; }

    public string Password {  get; set; }
    
}
