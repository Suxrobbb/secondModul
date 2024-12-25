using _2._6_darsStudent.DataAccess.Entites;
using System.Text.Json;

namespace _2._6_darsStudent.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private string path;
        private List<Student> _students;
        public StudentRepository()
        {
            path="../../../DataAccess/Data/Students.json";
            _students=new List<Student>();
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");
            }
            _students=ReadStudents();
        }

        public bool CheckEmailContains(string email)
        {
            var students = ReadStudents();
            foreach (var student in students)
            {
                if(student.Email == email)
                {
                    return true;
                }
            }
            return false;

        }

        public Student ReadStudentById(Guid id)
        {
            var students= ReadStudents();
            foreach (var student in students)
            {
                if(student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public List<Student> ReadStudents()
        {
            var studentsJson = File.ReadAllText(path);
            var students = JsonSerializer.Deserialize<List<Student>>(studentsJson);
            return students;
        }

        public bool RemoveStudent(Guid id)
        {
            var deletingStudents=ReadStudentById(id);
            if(deletingStudents == null)
            {
                return false;
            }
            _students.Remove(deletingStudents);
            SaveData();
            return true;

        }

        public bool UpdateStudent(Student student)
        {
            var updatingStudents = ReadStudentById(student.Id);
            if (updatingStudents == null)
            {
                return false;
            }
            var index=_students.IndexOf(student);
            _students[index] = student;
            SaveData();
            return true;
        }

        public Student WriteStudent(Student student)
        {
            _students.Add(student);
            SaveData();
            return student;
        }

        private void SaveData()
        {
            var jsonData=JsonSerializer.Serialize(_students);
            File.WriteAllText(path, jsonData);
        }

    }
}