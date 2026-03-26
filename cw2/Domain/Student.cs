namespace cw2;

public class Student : User
{
    public string IndexNumber { get; }
    public Student(string firstName, string lastName, string indexNumber) : base(firstName, lastName)
    {
        if (string.IsNullOrWhiteSpace(indexNumber)) throw new ArgumentException("Numer indeksu jest wymagany");
        IndexNumber = indexNumber;
    }
}