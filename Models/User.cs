namespace Random.Models;

public class User
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public User(string name, string lastName, int age, string email, string password)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Email = email;
        Password = password;
    }

    public virtual void Print()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("LastName: " + LastName);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Password: " + Password);
    }

    public virtual  User  Createuser()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        string Lastname = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your email: ");
        string Email = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();
        
        User user = new User(name, Lastname, age, Email, password);
        return user;
    }
    
    
}