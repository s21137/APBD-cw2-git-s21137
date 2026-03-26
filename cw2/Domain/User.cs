namespace cw2;

public abstract class User
{
    public Guid Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string FullName => $"{FirstName} {LastName}";

    protected User(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("Imię nie może być puste");
        if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("Nazwisko nie może być puste");
        
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
    }
}
