namespace _2._7_dars.Services.DTOs;

public class StudentUpdateDto : BaseStudentDto
{
    public Guid Id { get; set; }
    public string Password { get; set; }
}
