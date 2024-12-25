using _2._6_darsStudent.DataAccess.Entites;
using _2._6_darsStudent.Repository;
using _2._6_darsStudent.Services.DTOs;

namespace _2._6_darsStudent.Services;


public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    public StudentService()
    {
        _studentRepository=new StudentRepository();
    }

    public StudentGetDto AddStudent(StudentCreateDto dto)
    {
        var checkingEmail = _studentRepository.CheckEmailContains(dto.Email);
        if (!dto.Email.EndsWith("@gmail.com") || checkingEmail)
        {
            return null;
        }
        var student=ConvertToStudentEntity(dto);
        var studentFromDb=_studentRepository.WriteStudent(student);
        var studentDto=ConvertToDto(studentFromDb);
        return studentDto;
    }

    public bool DeleteStudent(Guid id)
    {
        var res=_studentRepository.RemoveStudent(id);
        return res;
    }

    public List<StudentGetDto> GetStudents()
    {
        var students=_studentRepository.ReadStudents();
        var studentsGetDto=new List<StudentGetDto>();
        foreach(var student in students)
        {
            studentsGetDto.Add(ConvertToDto(student));
        }
        return studentsGetDto;
    }

    public bool UpdateStudent(StudentUpdateDto studentUpdateDto)
    {
        var student = ConvertToStudentEntity(studentUpdateDto);
        var res=_studentRepository.UpdateStudent(student);
        return res;

    }
    private Student ConvertToStudentEntity(StudentCreateDto dto)
    {
        var student = new Student()
        {
            Id=Guid.NewGuid(),
            Email=dto.Email,
            FirstName=dto.FirstName,
            LastName=dto.LastName,
            Age=dto.Age,
            Password=dto.Password,
        };
        return student;
    }
    private Student ConvertToStudentEntity(StudentUpdateDto dto)
    {
        var student = new Student()
        {
            Id = dto.Id,
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Age = dto.Age,
            Password = dto.Password,
        };
        return student;
    }
    private StudentGetDto ConvertToDto(Student student)
    {
        var dto= new StudentGetDto()
        {
            Id=student.Id,
            FirstName=student.FirstName,
            LastName=student.LastName,
            Age=student.Age,
            Email=student.Email,
        };
        return dto;
    }

}
