using _2._7_dars.Repositories;
using _2._7_dars.Services.DTOs;
using _2._7_dars.Services.Enums;

namespace _2._7_dars.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    public StudentService()
    {
        _studentRepository = new StudentRepository();
    }
    public Guid AddStudent(StudentCreateDto studentCreateDto)
    {
        var res = ValidateStudentCreateDto(studentCreateDto);
        if (res == false)
        {
            throw new Exception("Hatolik yuz berdi adding while");
        }

        var entity = ConverToEntity(studentCreateDto);
        var id = _studentRepository.WriteStudent(entity);
        return id;
    }

    public void DeleteStudent(Guid studentId)
    {
        throw new NotImplementedException();
    }

    public StudentGetDto GetStudentById(Guid studentId)
    {
        throw new NotImplementedException();
    }

    public List<StudentGetDto> GetStudents()
    {
        throw new NotImplementedException();
    }

    public List<StudentGetDto> GetStudentsByDegree(DegreeStatusDto degreeStatusDto)
    {
        throw new NotImplementedException();
    }

    public List<StudentGetDto> GetStudentsByGender(GenderDto genderDto)
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(StudentUpdateDto studentUpdateDto)
    {
        throw new NotImplementedException();
    }
    private bool ValidateStudentCreateDto(StudentCreateDto obj)
    {
        _studentRepository.EmailContains(obj.Email);

        if (string.IsNullOrWhiteSpace(obj.FirstName) || obj.FirstName.Length > 50)
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(obj.LastName) || obj.LastName.Length > 50)
        {
            return false;
        }

        if (obj.Age < 15 || obj.Age > 150)
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(obj.Email) || !obj.Email.EndsWith("@gmail.com")
            || obj.Email.Length > 100 || obj.Email.Length <= 10)
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(obj.Password) || obj.Password.Length > 50 || obj.Password.Length < 8)
        {
            return false;
        }

        return true;
    }
}
