using _2._6_darsStudent.Services.DTOs;

namespace _2._6_darsStudent.Services
{
    public interface IStudentService
    {
        StudentGetDto AddStudent(StudentCreateDto dto);
        bool DeleteStudent(Guid id);
        bool UpdateStudent(StudentUpdateDto dto);
        List<StudentGetDto> GetStudents();
    }
}      