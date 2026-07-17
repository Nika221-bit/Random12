namespace Random.Models;

public class User2:User
{
    public User2(string name, string lastName, int age, string email, string password) : base(name, lastName, age, email, password)
    {
        
    }

    public override void Print()
    {
        base.Print();
    }

    public override User Createuser()
    {
        return base.Createuser();
    }
}