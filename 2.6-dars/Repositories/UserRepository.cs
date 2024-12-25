﻿using _2._6_dars.DataAccess.Entities;
using _2._6_dars.Services.DTOs;
using System.Text.Json;

namespace _2._6_dars.Repositories;

public class UserRepository : IUserRepository
{
    private string path;
    private List<User> _users;

    public UserRepository()
    {
        path= "../../../DataAccess/Data/Users.json";
        _users = new List<User>();
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "[]");
        }
        else
        {
            _users=ReadUsers();
        }
    }

    public bool CheckEmailContains(string email)
    {
        var users=ReadUsers();
        foreach(var user in users)
        {
            if(user.Email == email)
            {
                return true;
            }
        }
        return false;
    }

    public User ReadUserById(Guid id)
    {
        foreach (var user in _users)
        {
            if(user.Id == id)
            {
                return user;
            }
        }
        return null;
    }

    public List<User> ReadUsers()
    {
        var usersJson = File.ReadAllText(path);
        var users = JsonSerializer.Deserialize<List<User>>(usersJson);
        return users;
    }

    public bool RemoveUser(Guid id)
    {
        var deletingUser = ReadUserById(id);
        if (deletingUser == null)
        {
            return false;
        }
        _users.Remove(deletingUser);
        SaveData();
        return true;
    }

    public bool UpdateUser(User user)
    {
        var uptadingUser=ReadUserById(user.Id);
        if(uptadingUser == null)
        {
            return false;
        }
        var index=_users.IndexOf(uptadingUser);
        _users[index] = user;
        return true;
    }

    public User WriteUser(User user)
    {
        _users.Add(user);
        SaveData();
        return user;
    }


    private void SaveData()
    {
        var jsonData=JsonSerializer.Serialize(_users);
        File.WriteAllText( path,jsonData);
    }

    UserRepository IUserRepository.WriteUser(User user)
    {
        throw new NotImplementedException();
    }
}
