namespace _2._6_dars.Services.DTOs;

public class UserUpdateDto : BaseUserDto
{
    public Guid Id { get; set; }
    public string Password { get; set; }
}
