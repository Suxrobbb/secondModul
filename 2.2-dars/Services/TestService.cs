using _2._2_dars.Modeles;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace _2._2_dars.Services;

public class TestService
{
    private string testFilePath;

    public TestService()
    {
        testFilePath="../../Data/Test.Json";
        if (File.Exists(testFilePath))
        {
            File.WriteAllText(testFilePath, "[]");
        }
    }

    public Test AddTest(Test test)
    {
        test.Id = Guid.NewGuid();
        var tests = GetTest();
        tests.Add(test);
        SaveData(tests);
        return test;
    }
    public Test GetById(Guid testId)
    {
        var tests = GetTest();
        foreach (var test in tests)
        {
            if (testId == test.Id)
            {
                return test;
            }
        }
        return null;
    }

    public bool DeleteTest(Guid testId)
    {
        var tests = GetTest();
        var testFromDb = GetById(testId);
        if (testFromDb is null)
        {
            return false;
        }
        tests.Remove(testFromDb);
        SaveData(tests);
        return true;
    }

    public bool UpdateTest(Test test)
    {
        var tests = GetTest();
        var testFromDb = GetById(test.Id);
        if (testFromDb is null)
        {
            return false;
        }
        var index = tests.IndexOf(test);
        tests[index]= test;
        SaveData(tests);
        return true;
    }

    public List<Test> GetAllTests()
    {
        return GetTest();
    }
    private void SaveData(List<Test> test)
    {
        var testJson=JsonSerializer.Serialize(test);
        File.WriteAllText(testFilePath,testJson);
    }

    private List<Test> GetTest()
    {
        var testJson=File.ReadAllText(testFilePath);
        var tests=JsonSerializer.Deserialize<List<Test>>(testJson);
        return tests;
    }
}
