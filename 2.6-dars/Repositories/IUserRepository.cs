using _2._6_dars.DataAccess.Entities;

namespace _2._6_dars.Repositories
{
    public interface IUserRepository
    {
        UserRepository WriteUser(User user);
        bool RemoveUser(Guid id);
        bool UpdateUser(User user);
        User ReadUserById(Guid id);
        List<User> ReadUsers();
        bool CheckEmailContains (string email);
    }
}