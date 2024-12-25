using _2._6_darsStudent.DataAccess.Entites;

namespace _2._6_darsStudent.Repository;


public interface IStudentRepository
{
    Student WriteStudent(Student student);
    bool RemoveStudent(Guid id);
    bool UpdateStudent(Student student);
    Student ReadStudentById(Guid id);
    List<Student> ReadStudents();
    bool CheckEmailContains(string email);
}
