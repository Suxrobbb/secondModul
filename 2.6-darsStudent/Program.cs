using _2._6_darsStudent.Services;
using _2._6_darsStudent.Services.DTOs;

namespace _2._6_darsStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentService studentService = new StudentService();
            var students = studentService.GetStudents();
            StudentCreateDto dto = new StudentCreateDto()
            {
                FirstName = "Ali",
                LastName = "Vali",
                Age = 17,
                Email = "Ali@gmail.com",
                Password = "4545",
            };

            StudentCreateDto dto2 = new StudentCreateDto()
            {
                FirstName = "d3ri",
                LastName = "Valdf3i",
                Age = 37,
                Email = "sjahjudwi@gmail.com",
                Password = "45eede5",
            };
            studentService.AddStudent(dto);
            studentService.AddStudent(dto2);
            Console.WriteLine(studentService);
        }
    }
}
