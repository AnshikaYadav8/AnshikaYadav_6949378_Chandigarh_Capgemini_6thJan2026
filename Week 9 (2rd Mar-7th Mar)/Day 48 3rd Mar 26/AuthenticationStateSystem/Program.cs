using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public int Id;
    public string Email;
    public string Password;
    public string Location;
    public int IncorrectAttempt = 0;

    public User(int id, string email, string password, string location)
    {
        Id = id;
        Email = email;
        Password = password;
        Location = location;
    }
}

class ApplicationAuthState
{
    List<User> registeredUsers = new List<User>();
    List<User> loggedUsers = new List<User>();
    List<string> allowedLocations;

    public ApplicationAuthState(List<string> locations)
    {
        allowedLocations = locations;
    }

    public string Register(User u)
    {
        if (registeredUsers.Any(x => x.Email == u.Email))
            return $"{u.Email} is already registered!";

        registeredUsers.Add(u);
        return $"{u.Email} registered successfully!";
    }

    public string Login(User u)
    {
        if (!registeredUsers.Any(x => x.Email == u.Email))
            return $"{u.Email} is not registered!";

        if (!allowedLocations.Contains(u.Location))
            return $"{u.Email} is not allowed to login from this location!";

        loggedUsers.Add(u);
        return $"{u.Email} logged in successfully!";
    }

    public string Logout(User u)
    {
        if (!loggedUsers.Contains(u))
            return $"{u.Email} is not logged in!";

        loggedUsers.Remove(u);
        return $"{u.Email} logged out successfully!";
    }
}

class Program
{
    static void Main()
    {
        var locations = new List<string> { "USA", "UK" };

        var auth = new ApplicationAuthState(locations);

        var user = new User(1, "user@email.com", "1234", "USA");

        Console.WriteLine(auth.Register(user));
        Console.WriteLine(auth.Login(user));
        Console.WriteLine(auth.Logout(user));
    }
}