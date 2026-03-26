namespace cw2;

public class Employee : User
{
    public string Department { get; }
    public Employee(string firstName, string lastName, string department) : base(firstName, lastName)
    {
        if (string.IsNullOrWhiteSpace(department)) throw new ArgumentException("Dział jest wymagany");
        Department = department;
    }
}