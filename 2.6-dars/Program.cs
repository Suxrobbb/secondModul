using _2._6_dars.Services;
using _2._6_dars.Services.DTOs;

namespace _2._6_dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          IUserService userService = new UserService();
            UserCreateDto dto1 = new UserCreateDto()
            {
                FirstName= "nabi",
                LastName= "shabi",
                Age=20,
                Email="qovunlar@gmail.com",
                Password="Suerorr",
            };

            UserCreateDto dto2 = new UserCreateDto()
            {
                FirstName= "Ali",
                LastName= "vali", 
                Age=16,
                Email="Alihd@gmail.com",
                Password="helloed",
            };
            userService.AddUser(dto1);
            userService.AddUser(dto2);


        } 
    }
}
