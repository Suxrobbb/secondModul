using _2._6_dars.Services.DTOs;

namespace _2._6_dars.Services
{
    public interface IUserService
    {
        UserGetDto AddUser(UserCreateDto dto);
        bool DeleteUser(Guid id);
        bool UpdateUser(UserUpdateDto userUpdeteDto);
        List<UserGetDto> GetUsers();

    }
}