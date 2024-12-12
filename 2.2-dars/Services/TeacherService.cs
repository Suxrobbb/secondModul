using _2._2_dars.Modeles;
using System.Text.Json;
namespace _2._2_dars.Services;

public class TeacherService
{
    private string TeacherFile;

    public TeacherService()
    {
        TeacherFile ="../../../Data/Teacher.Json";
        if (File.Exists(TeacherFile) is false)
        {
            File.WriteAllText(TeacherFile, "[]");
        }
    }

    public Teacher AddTeacher(Teacher teacher)
    {
        teacher.Id= Guid.NewGuid();
        var teachers = GetAllTeachers();
        teachers.Add(teacher);
        SaveData(teachers);
        return teacher;
    }

    public Teacher GetById(Guid teacherId)
    {
        var teachers = GetTeachers();
        foreach (var teacher in teachers)
        {
            if (teacherId==teacher.Id)
            {
                return teacher;
            }
        }
        return null;
    }

    public bool DeleteTeacher(Guid teacherId)
    {
        var teachers = GetAllTeachers();
        var teacherFromDb = GetById(teacherId);
        if (teacherFromDb is null)
        {
            return false;
        }
        teachers.Remove(teacherFromDb);
        SaveData(teachers);
        return true;
    }

    public bool UpdateTeacher(Teacher teacher)
    {
        var teachers = GetAllTeachers();
        var teacherFromDb = GetById(teacher.Id);
        if (teacherFromDb is null)
        {
            return false;
        }
        var index=teachers.IndexOf(teacher);
        teachers[index] = teacher;
        SaveData(teachers);
        return true;
    }

    public List<Teacher> GetAllTeachers()
    {
        return GetAllTeachers();
    }

    private void SaveData(List<Teacher> teacher)
    {
        var teacherJson = JsonSerializer.Serialize(TeacherFile);
        File.WriteAllText(TeacherFile, teacherJson);
    }

    private List<Teacher> GetTeachers()
    {
        var teacherJson = File.ReadAllText(TeacherFile);
        var teachers = JsonSerializer.Deserialize<List<Teacher>>(teacherJson);
        return teachers;
    }

}

