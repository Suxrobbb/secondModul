using System.Security.Cryptography;

namespace _2._5_dars.Models;

public class User
{
    private string fristName;

    public string FirstName
    {
        get { return fristName; }
        set { fristName = value; }
    }

    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private long phoneNumber;

    public long PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }











}
